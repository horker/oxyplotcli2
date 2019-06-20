using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horker.PSOxyPlot.TypeAdaptors
{
    public class InterpolationAlgorithm
    {
        private static Tuple<string, OxyPlot.IInterpolationAlgorithm>[] AlgorithmNames = new[]
        {
            Tuple.Create("CanonicalSpline".ToLower(), OxyPlot.InterpolationAlgorithms.CanonicalSpline),
            Tuple.Create("CatmullRomSpline".ToLower(), OxyPlot.InterpolationAlgorithms.CatmullRomSpline),
            Tuple.Create("UniformCatmullRomSpline".ToLower(), OxyPlot.InterpolationAlgorithms.UniformCatmullRomSpline),
            Tuple.Create("ChordalCatmullRomSpline".ToLower(), OxyPlot.InterpolationAlgorithms.ChordalCatmullRomSpline)
        };

        public OxyPlot.IInterpolationAlgorithm Value { get; private set; }

        public InterpolationAlgorithm(OxyPlot.IInterpolationAlgorithm algorithm)
        {
            Value = algorithm;
        }

        public InterpolationAlgorithm(string algorithmName)
        {
            if (string.IsNullOrEmpty(algorithmName))
            {
                Value = null;
                return;
            }

            var n = algorithmName.ToLower();
            foreach (var tuple in AlgorithmNames)
            {
                if (tuple.Item1.IndexOf(n) >= 0)
                {
                    Value = tuple.Item2;
                    return;
                }
            }
            throw new ArgumentException($"Unknown interpolation algorithm '{algorithmName}'; Specify one of the following: CanonicalSpline, CatmullRomSpline, UniformCatmullRomSpline or ChordalCatmullRomSpline");
        }
    }
}
