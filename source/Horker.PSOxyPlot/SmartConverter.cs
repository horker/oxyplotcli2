using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot
{
    class SmartConverter
    {
        private static readonly Regex NUMERIC_RE = new Regex(@"(NaN|(?:[+-]?((?:[\d,]+\.?(?:\d*))|(?:\.\d+))(?:[eE][+-]?\d+)?))");

        // ref.
        // Currency Symbols
        // http://www.unicode.org/charts/PDF/U20A0.pdf
        // Halfwidth and fullwidth form
        // http://www.unicode.org/charts/PDF/UFF00.pdf
        //
        // Note: The backslash is displayed as currency sign in several Asian environments.

        private static readonly Regex CURRENCY_RE = new Regex("[\u20a0-\u20cf\u0024\u00a2\u00a3\u00a4\u00a5\u0192\u058f\u060b\u09f2\u09f3\u0af1\u0bf9\u0e3f\u17db\u2133\u5143\u5186\u5706\u5713\ufdfc\uff04\uffe0\uffe1\uffe5\uffe6\\\\]");

        public static string ExtractNumber(string input)
        {
            var match = NUMERIC_RE.Match(input);
            return match.Captures[0].Value.Replace(",", "");
        }

        private static T ReturnFallbackValue<T>(object input, T? fallback, Exception cause)
            where T : struct
        {
            if (fallback.HasValue)
                return fallback.Value;
            throw new ArgumentException($"Failed convert into type {nameof(T)}: {input}", cause);
        }

        public static double ToDouble(object input, double? fallback = null)
        {
            if (input is PSObject pso)
                input = pso.BaseObject;

            if (input is double d)
                return d;

            if (input is bool b)
                return b ? 1.0 : 0.0;

            try
            {
                if (input is string)
                {
                    var s = input as string;
                    s = CURRENCY_RE.Replace(s, "");
                    var success = double.TryParse(s, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double result);
                    if (!success)
                        return ReturnFallbackValue(input, fallback, null);

                    return result;
                }

                return Convert.ToDouble(input);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static float ToSingle(object input, float? fallback = null)
        {
            try
            {
                return (float)ToDouble(input, fallback);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static float ToFloat(object input, float? fallback = null)
        {
            return ToSingle(input, fallback);
        }

        public static long ToInt64(object input, long? fallback = null)
        {
            if (input is PSObject pso)
                input = pso.BaseObject;

            if (input is long i)
                return i;

            if (input is bool b)
                return b ? 1 : 0;

            try
            {
                if (input is string s)
                {
                    s = CURRENCY_RE.Replace(s, "");
                    var success = long.TryParse(s, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out long result);
                    if (!success)
                        return ReturnFallbackValue(input, fallback, null);

                    return result;
                }

                return Convert.ToInt32(input);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static long ToLong(object input, long? fallback = null)
        {
            return ToInt64(input, fallback);
        }

        public static int ToInt32(object input, int? fallback = null)
        {
            try
            {
                return (int)ToInt64(input, fallback);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static int ToInt(object input, int? fallback = null)
        {
            return ToInt32(input, fallback);
        }

        public static short ToInt16(object input, short? fallback = null)
        {
            try
            {
                return (short)ToInt64(input, fallback);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static short ToShort(object input, short? fallback = null)
        {
            return ToInt16(input, fallback);
        }

        public static byte ToUInt8(object input, byte? fallback = null)
        {
            try
            {
                return (byte)ToInt64(input, fallback);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static byte ToByte(object input, byte? fallback = null)
        {
            return ToUInt8(input, fallback);
        }

        public static sbyte ToInt8(object input, sbyte? fallback = null)
        {
            try
            {
                return (sbyte)ToInt64(input, fallback);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static sbyte ToSByte(object input, sbyte? fallback = null)
        {
            return ToInt8(input, fallback);
        }

        public static bool ToBool(object input, bool? fallback = null)
        {
            if (input is PSObject pso)
                input = pso.BaseObject;

            if (input is bool b)
                return b;

            if (TypeTest.IsNumeric(input.GetType()))
            {
                var value = (int)(double)input;
                if (value == 1 || value == -1)
                    return true;
                if (value == 0)
                    return false;
            }

            if (input is string s)
            {
                s = s.ToLower();
                if (s == "t" || s == "true")
                    return true;
                if (s == "f" || s == "false")
                    return false;
            }

            return ReturnFallbackValue(input, fallback, null);
        }

        public static DateTime ToDateTime(object input, bool assumeLocal = true, string format = null, CultureInfo culture = null, DateTime? fallback = null)
        {
            if (input is PSObject pso)
                input = pso.BaseObject;

            if (input is DateTime dt)
                return dt;

            if (input is DateTimeOffset dto)
                return dto.DateTime;

            try
            {
                if (input is string s)
                {
                    DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
                    if (assumeLocal)
                        style |= DateTimeStyles.AssumeLocal;
                    else
                        style |= DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal;


                    if (culture == null)
                        culture = CultureInfo.CurrentCulture;

                    if (string.IsNullOrEmpty(format))
                        return DateTime.Parse(s, culture.DateTimeFormat, style);
                    else
                        return DateTime.ParseExact(s, format, culture, style);
                }

                return Convert.ToDateTime(input);
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }

        public static DateTimeOffset ToDateTimeOffset(object input, bool assumeLocal = true, string format = null, CultureInfo culture = null, DateTimeOffset? fallback = null)
        {
            if (input is PSObject pso)
                input = pso.BaseObject;

            if (input is DateTimeOffset dto)
                return dto;

            if (input is DateTime dt)
                return new DateTimeOffset(dt);

            try
            {
                if (input is string s)
                {
                    DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
                    if (assumeLocal)
                        style |= DateTimeStyles.AssumeLocal;
                    else
                        style |= DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal;

                    if (culture == null)
                        culture = CultureInfo.CurrentCulture;

                    if (string.IsNullOrEmpty(format))
                        return DateTimeOffset.Parse(s, culture.DateTimeFormat, style);
                    else
                        return DateTimeOffset.ParseExact(s, format, culture, style);
                }

                return new DateTimeOffset(Convert.ToDateTime(input));
            }
            catch (Exception e)
            {
                return ReturnFallbackValue(input, fallback, e);
            }
        }
    }
}
