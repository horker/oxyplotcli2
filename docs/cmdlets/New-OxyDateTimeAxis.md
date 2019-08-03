---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: http://en.wikipedia.org/wiki/Contour_line
schema: 2.0.0
---

# New-OxyDateTimeAxis

## SYNOPSIS

Returns an object that represents an axis presenting System.DateTime values.
 
The actual numeric values on the axis are days since 1900/01/01.
 Use the static ToDouble and ToDateTime to convert numeric values to and from DateTimes.
 The StringFormat value can be used to force formatting of the axis values
 "yyyy-MM-dd" shows date
 "w" or "ww" shows week number
 "h:mm" shows hours and minutes


## SYNTAX

```
New-OxyDateTimeAxis [-CalendarWeekRule <CalendarWeekRule>] [-FirstDayOfWeek <DayOfWeek>]
 [-IntervalType <DateTimeIntervalType>] [-MinorIntervalType <DateTimeIntervalType>] [-TimeZone <TimeZoneInfo>]
 [-FormatAsFractions <Bool>] [-FractionUnit <Double>] [-FractionUnitSymbol <String>]
 [-AbsoluteMaximum <Double>] [-AbsoluteMinimum <Double>] [-Angle <Double>] [-AxisTickToLabelDistance <Double>]
 [-AxisTitleDistance <Double>] [-AxisDistance <Double>] [-AxislineColor <OxyColor>]
 [-AxislineStyle <LineStyle>] [-AxislineThickness <Double>] [-ClipTitle <Bool>] [-CropGridlines <Bool>]
 [-EndPosition <Double>] [-ExtraGridlineColor <OxyColor>] [-ExtraGridlineStyle <LineStyle>]
 [-ExtraGridlineThickness <Double>] [-ExtraGridlines <Double[]>]
 [-FilterFunction <System.Func`2[System.Double,System.Boolean]>] [-FilterMaxValue <Double>]
 [-FilterMinValue <Double>] [-IntervalLength <Double>] [-IsAxisVisible <Bool>] [-IsPanEnabled <Bool>]
 [-IsZoomEnabled <Bool>] [-Key <String>] [-LabelFormatter <System.Func`2[System.Double,System.String]>]
 [-Layer <AxisLayer>] [-MajorGridlineColor <OxyColor>] [-MajorGridlineStyle <LineStyle>]
 [-MajorGridlineThickness <Double>] [-MajorStep <Double>] [-MajorTickSize <Double>] [-Maximum <Double>]
 [-MaximumPadding <Double>] [-MaximumRange <Double>] [-Minimum <Double>] [-MinimumMajorStep <Double>]
 [-MinimumMinorStep <Double>] [-MinimumPadding <Double>] [-MinimumRange <Double>]
 [-MinorGridlineColor <OxyColor>] [-MinorGridlineStyle <LineStyle>] [-MinorGridlineThickness <Double>]
 [-MinorStep <Double>] [-MinorTicklineColor <OxyColor>] [-MinorTickSize <Double>] [-Position <AxisPosition>]
 [-PositionAtZeroCrossing <Bool>] [-PositionTier <Int32>] [-StartPosition <Double>] [-StringFormat <String>]
 [-TickStyle <TickStyle>] [-TicklineColor <OxyColor>] [-Title <String>] [-TitleClippingLength <Double>]
 [-TitleColor <OxyColor>] [-TitleFont <String>] [-TitleFontSize <Double>] [-TitleFontWeight <Double>]
 [-TitleFormatString <String>] [-TitlePosition <Double>] [-Unit <String>] [-UseSuperExponentialFormat <Bool>]
 [-Font <String>] [-FontSize <Double>] [-FontWeight <Double>] [-Tag <Object>] [-TextColor <OxyColor>]
 [-ToolTip <String>] [-Selectable <Bool>] [-SelectionMode <SelectionMode>] [-AddTo <PlotModel>] [-PassThru]
 [-Style <String>] [<CommonParameters>]
```

## DESCRIPTION

Returns an object that represents an axis presenting System.DateTime values.
 
The actual numeric values on the axis are days since 1900/01/01.
 Use the static ToDouble and ToDateTime to convert numeric values to and from DateTimes.
 The StringFormat value can be used to force formatting of the axis values
 "yyyy-MM-dd" shows date
 "w" or "ww" shows week number
 "h:mm" shows hours and minutes


## PARAMETERS

### -AbsoluteMaximum



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AbsoluteMinimum



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddTo

Specifies the PlotModel object to which the object is added.

```yaml
Type: OxyPlot.PlotModel
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Angle



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxisDistance

Specifies the isDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxisTickToLabelDistance

Specifies the isTickToLabelDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxisTitleDistance

Specifies the isTitleDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxislineColor

Specifies the islineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxislineStyle

Specifies the islineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxislineThickness

Specifies the islineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarWeekRule



```yaml
Type: System.Globalization.CalendarWeekRule
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClipTitle



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CropGridlines



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndPosition



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtraGridlineColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtraGridlineStyle



```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtraGridlineThickness



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtraGridlines



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterFunction



```yaml
Type: System.Func`2[System.Double,System.Boolean]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterMaxValue



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilterMinValue



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FirstDayOfWeek



```yaml
Type: System.DayOfWeek
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Font



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FontSize



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FontWeight



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FormatAsFractions



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FractionUnit



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FractionUnitSymbol



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IntervalLength



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IntervalType



```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAxisVisible



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsPanEnabled



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsZoomEnabled



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Key



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelFormatter



```yaml
Type: System.Func`2[System.Double,System.String]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Layer



```yaml
Type: OxyPlot.Axes.AxisLayer
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MajorGridlineColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MajorGridlineStyle



```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MajorGridlineThickness



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MajorStep



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MajorTickSize



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Maximum



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumPadding



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaximumRange



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Minimum



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumMajorStep



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumMinorStep



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumPadding



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumRange



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorGridlineColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorGridlineStyle



```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorGridlineThickness



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorIntervalType



```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorStep



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorTickSize



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinorTicklineColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru

Returns a created object when the -AddTo, -OutFile or -Show parameter is specified.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Position



```yaml
Type: OxyPlot.Axes.AxisPosition
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PositionAtZeroCrossing



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PositionTier



```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Selectable



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelectionMode



```yaml
Type: OxyPlot.SelectionMode
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartPosition



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StringFormat



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Style

Specifies the style.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag



```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TickStyle



```yaml
Type: OxyPlot.Axes.TickStyle
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TicklineColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeZone



```yaml
Type: System.TimeZoneInfo
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleClippingLength



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleColor



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFont



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFontSize



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFontWeight



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFormatString



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitlePosition



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToolTip



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Unit



```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseSuperExponentialFormat



```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### OxyPlot.Axes.DateTimeAxis
## NOTES

## RELATED LINKS


