---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: http://en.wikipedia.org/wiki/Pie_chart
schema: 2.0.0
---

# New-OxyPlotModel

## SYNOPSIS
{{Fill in the Synopsis}}

## SYNTAX

```
New-OxyPlotModel [[-Series] <Series>] [[-SeriesInfo] <ISeriesInfo>] [[-Axis] <Axis[]>]
 [[-Annotation] <Annotation[]>] [[-OutFile] <String>] [[-OutWidth] <Int32>] [[-OutHeight] <Int32>]
 [-SvgIsDocument] [-PassThru] [[-Style] <String>] [-AsUIElement] [-Show] [-ReuseWindow]
 [[-DefaultFont] <String>] [[-DefaultFontSize] <Double>] [[-Background] <OxyColor>] [[-Culture] <CultureInfo>]
 [[-DefaultColors] <System.Collections.Generic.IList`1[OxyPlot.OxyColor]>] [[-IsLegendVisible] <Bool>]
 [[-LegendBackground] <OxyColor>] [[-LegendBorder] <OxyColor>] [[-LegendBorderThickness] <Double>]
 [[-LegendColumnSpacing] <Double>] [[-LegendFont] <String>] [[-LegendFontSize] <Double>]
 [[-LegendTextColor] <OxyColor>] [[-LegendFontWeight] <Double>] [[-LegendItemAlignment] <HorizontalAlignment>]
 [[-LegendItemOrder] <LegendItemOrder>] [[-LegendItemSpacing] <Double>] [[-LegendLineSpacing] <Double>]
 [[-LegendMargin] <Double>] [[-LegendMaxWidth] <Double>] [[-LegendMaxHeight] <Double>]
 [[-LegendOrientation] <LegendOrientation>] [[-LegendPadding] <Double>] [[-LegendPlacement] <LegendPlacement>]
 [[-LegendPosition] <LegendPosition>] [[-LegendSymbolLength] <Double>] [[-LegendSymbolMargin] <Double>]
 [[-LegendSymbolPlacement] <LegendSymbolPlacement>] [[-LegendTitle] <String>] [[-LegendTitleColor] <OxyColor>]
 [[-LegendTitleFont] <String>] [[-LegendTitleFontSize] <Double>] [[-LegendTitleFontWeight] <Double>]
 [[-Padding] <Double[]>] [[-AxisTierDistance] <Double>] [[-PlotAreaBackground] <OxyColor>]
 [[-PlotAreaBorderColor] <OxyColor>] [[-PlotAreaBorderThickness] <Double[]>] [[-PlotMargins] <Double[]>]
 [[-PlotType] <PlotType>]
 [[-RenderingDecorator] <System.Func`2[OxyPlot.IRenderContext,OxyPlot.IRenderContext]>] [[-Subtitle] <String>]
 [[-SubtitleFont] <String>] [[-SubtitleFontSize] <Double>] [[-SubtitleFontWeight] <Double>]
 [[-TextColor] <OxyColor>] [[-Title] <String>] [[-TitleToolTip] <String>] [[-TitleColor] <OxyColor>]
 [[-SubtitleColor] <OxyColor>] [[-TitleHorizontalAlignment] <TitleHorizontalAlignment>] [[-TitleFont] <String>]
 [[-TitleFontSize] <Double>] [[-TitleFontWeight] <Double>] [[-TitlePadding] <Double>]
 [[-SelectionColor] <OxyColor>] [[-AxStartAngle] <Double>] [[-AxEndAngle] <Double>]
 [[-AxFormatAsFractions] <Bool>] [[-AxFractionUnit] <Double>] [[-AxFractionUnitSymbol] <String>]
 [[-AxAbsoluteMaximum] <Double>] [[-AxAbsoluteMinimum] <Double>] [[-AxAngle] <Double>]
 [[-AxAxisTickToLabelDistance] <Double>] [[-AxAxisTitleDistance] <Double>] [[-AxAxisDistance] <Double>]
 [[-AxAxislineColor] <OxyColor>] [[-AxAxislineStyle] <LineStyle>] [[-AxAxislineThickness] <Double>]
 [[-AxClipTitle] <Bool>] [[-AxCropGridlines] <Bool>] [[-AxEndPosition] <Double>]
 [[-AxExtraGridlineColor] <OxyColor>] [[-AxExtraGridlineStyle] <LineStyle>]
 [[-AxExtraGridlineThickness] <Double>] [[-AxExtraGridlines] <Double[]>]
 [[-AxFilterFunction] <System.Func`2[System.Double,System.Boolean]>] [[-AxFilterMaxValue] <Double>]
 [[-AxFilterMinValue] <Double>] [[-AxIntervalLength] <Double>] [[-AxIsAxisVisible] <Bool>]
 [[-AxIsPanEnabled] <Bool>] [[-AxIsZoomEnabled] <Bool>] [[-AxKey] <String>]
 [[-AxLabelFormatter] <System.Func`2[System.Double,System.String]>] [[-AxLayer] <AxisLayer>]
 [[-AxMajorGridlineColor] <OxyColor>] [[-AxMajorGridlineStyle] <LineStyle>]
 [[-AxMajorGridlineThickness] <Double>] [[-AxMajorStep] <Double>] [[-AxMajorTickSize] <Double>]
 [[-AxMaximum] <Double>] [[-AxMaximumPadding] <Double>] [[-AxMaximumRange] <Double>] [[-AxMinimum] <Double>]
 [[-AxMinimumMajorStep] <Double>] [[-AxMinimumMinorStep] <Double>] [[-AxMinimumPadding] <Double>]
 [[-AxMinimumRange] <Double>] [[-AxMinorGridlineColor] <OxyColor>] [[-AxMinorGridlineStyle] <LineStyle>]
 [[-AxMinorGridlineThickness] <Double>] [[-AxMinorStep] <Double>] [[-AxMinorTicklineColor] <OxyColor>]
 [[-AxMinorTickSize] <Double>] [[-AxPosition] <AxisPosition>] [[-AxPositionAtZeroCrossing] <Bool>]
 [[-AxPositionTier] <Int32>] [[-AxStartPosition] <Double>] [[-AxStringFormat] <String>]
 [[-AxTickStyle] <TickStyle>] [[-AxTicklineColor] <OxyColor>] [[-AxTitle] <String>]
 [[-AxTitleClippingLength] <Double>] [[-AxTitleColor] <OxyColor>] [[-AxTitleFont] <String>]
 [[-AxTitleFontSize] <Double>] [[-AxTitleFontWeight] <Double>] [[-AxTitleFormatString] <String>]
 [[-AxTitlePosition] <Double>] [[-AxUnit] <String>] [[-AxUseSuperExponentialFormat] <Bool>]
 [[-AxFont] <String>] [[-AxFontSize] <Double>] [[-AxFontWeight] <Double>] [[-AxTag] <Object>]
 [[-AxTextColor] <OxyColor>] [[-AxToolTip] <String>] [[-AxSelectable] <Bool>]
 [[-AxSelectionMode] <SelectionMode>] [[-AxGapWidth] <Double>] [[-AxIsTickCentered] <Bool>]
 [[-AxItemsSource] <IEnumerable>] [[-AxLabelField] <String>] [[-AxInvalidCategoryColor] <OxyColor>]
 [[-AxPalette] <OxyPaletteItem[]>] [[-AxCalendarWeekRule] <CalendarWeekRule>] [[-AxFirstDayOfWeek] <DayOfWeek>]
 [[-AxIntervalType] <DateTimeIntervalType>] [[-AxMinorIntervalType] <DateTimeIntervalType>]
 [[-AxTimeZone] <TimeZoneInfo>] [[-AxInvalidNumberColor] <OxyColor>] [[-AxHighColor] <OxyColor>]
 [[-AxLowColor] <OxyColor>] [[-AxRenderAsImage] <Bool>] [[-AxBase] <Double>] [[-AxPowerPadding] <Bool>]
 [[-AyStartAngle] <Double>] [[-AyEndAngle] <Double>] [[-AyFormatAsFractions] <Bool>]
 [[-AyFractionUnit] <Double>] [[-AyFractionUnitSymbol] <String>] [[-AyAbsoluteMaximum] <Double>]
 [[-AyAbsoluteMinimum] <Double>] [[-AyAngle] <Double>] [[-AyAxisTickToLabelDistance] <Double>]
 [[-AyAxisTitleDistance] <Double>] [[-AyAxisDistance] <Double>] [[-AyAxislineColor] <OxyColor>]
 [[-AyAxislineStyle] <LineStyle>] [[-AyAxislineThickness] <Double>] [[-AyClipTitle] <Bool>]
 [[-AyCropGridlines] <Bool>] [[-AyEndPosition] <Double>] [[-AyExtraGridlineColor] <OxyColor>]
 [[-AyExtraGridlineStyle] <LineStyle>] [[-AyExtraGridlineThickness] <Double>] [[-AyExtraGridlines] <Double[]>]
 [[-AyFilterFunction] <System.Func`2[System.Double,System.Boolean]>] [[-AyFilterMaxValue] <Double>]
 [[-AyFilterMinValue] <Double>] [[-AyIntervalLength] <Double>] [[-AyIsAxisVisible] <Bool>]
 [[-AyIsPanEnabled] <Bool>] [[-AyIsZoomEnabled] <Bool>] [[-AyKey] <String>]
 [[-AyLabelFormatter] <System.Func`2[System.Double,System.String]>] [[-AyLayer] <AxisLayer>]
 [[-AyMajorGridlineColor] <OxyColor>] [[-AyMajorGridlineStyle] <LineStyle>]
 [[-AyMajorGridlineThickness] <Double>] [[-AyMajorStep] <Double>] [[-AyMajorTickSize] <Double>]
 [[-AyMaximum] <Double>] [[-AyMaximumPadding] <Double>] [[-AyMaximumRange] <Double>] [[-AyMinimum] <Double>]
 [[-AyMinimumMajorStep] <Double>] [[-AyMinimumMinorStep] <Double>] [[-AyMinimumPadding] <Double>]
 [[-AyMinimumRange] <Double>] [[-AyMinorGridlineColor] <OxyColor>] [[-AyMinorGridlineStyle] <LineStyle>]
 [[-AyMinorGridlineThickness] <Double>] [[-AyMinorStep] <Double>] [[-AyMinorTicklineColor] <OxyColor>]
 [[-AyMinorTickSize] <Double>] [[-AyPosition] <AxisPosition>] [[-AyPositionAtZeroCrossing] <Bool>]
 [[-AyPositionTier] <Int32>] [[-AyStartPosition] <Double>] [[-AyStringFormat] <String>]
 [[-AyTickStyle] <TickStyle>] [[-AyTicklineColor] <OxyColor>] [[-AyTitle] <String>]
 [[-AyTitleClippingLength] <Double>] [[-AyTitleColor] <OxyColor>] [[-AyTitleFont] <String>]
 [[-AyTitleFontSize] <Double>] [[-AyTitleFontWeight] <Double>] [[-AyTitleFormatString] <String>]
 [[-AyTitlePosition] <Double>] [[-AyUnit] <String>] [[-AyUseSuperExponentialFormat] <Bool>]
 [[-AyFont] <String>] [[-AyFontSize] <Double>] [[-AyFontWeight] <Double>] [[-AyTag] <Object>]
 [[-AyTextColor] <OxyColor>] [[-AyToolTip] <String>] [[-AySelectable] <Bool>]
 [[-AySelectionMode] <SelectionMode>] [[-AyGapWidth] <Double>] [[-AyIsTickCentered] <Bool>]
 [[-AyItemsSource] <IEnumerable>] [[-AyLabelField] <String>] [[-AyInvalidCategoryColor] <OxyColor>]
 [[-AyPalette] <OxyPaletteItem[]>] [[-AyCalendarWeekRule] <CalendarWeekRule>] [[-AyFirstDayOfWeek] <DayOfWeek>]
 [[-AyIntervalType] <DateTimeIntervalType>] [[-AyMinorIntervalType] <DateTimeIntervalType>]
 [[-AyTimeZone] <TimeZoneInfo>] [[-AyInvalidNumberColor] <OxyColor>] [[-AyHighColor] <OxyColor>]
 [[-AyLowColor] <OxyColor>] [[-AyRenderAsImage] <Bool>] [[-AyBase] <Double>] [[-AyPowerPadding] <Bool>]
 [<CommonParameters>]
```

## DESCRIPTION
{{Fill in the Description}}

## EXAMPLES

### Example 1
```
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -Annotation
{{Fill Annotation Description}}

```yaml
Type: OxyPlot.Annotations.Annotation[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsUIElement
{{Fill AsUIElement Description}}

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAbsoluteMaximum
{{Fill AxAbsoluteMaximum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 74
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAbsoluteMinimum
{{Fill AxAbsoluteMinimum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 75
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAngle
{{Fill AxAngle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 76
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAxisDistance
{{Fill AxAxisDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 79
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAxisTickToLabelDistance
{{Fill AxAxisTickToLabelDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 77
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAxisTitleDistance
{{Fill AxAxisTitleDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 78
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAxislineColor
{{Fill AxAxislineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 80
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAxislineStyle
{{Fill AxAxislineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 81
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxAxislineThickness
{{Fill AxAxislineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 82
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxBase
{{Fill AxBase Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 159
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxCalendarWeekRule
{{Fill AxCalendarWeekRule Description}}

```yaml
Type: System.Globalization.CalendarWeekRule
Parameter Sets: (All)
Aliases:
Accepted values: FirstDay, FirstFullWeek, FirstFourDayWeek

Required: False
Position: 150
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxClipTitle
{{Fill AxClipTitle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 83
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxCropGridlines
{{Fill AxCropGridlines Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 84
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxEndAngle
{{Fill AxEndAngle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 70
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxEndPosition
{{Fill AxEndPosition Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 85
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxExtraGridlineColor
{{Fill AxExtraGridlineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 86
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxExtraGridlineStyle
{{Fill AxExtraGridlineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 87
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxExtraGridlineThickness
{{Fill AxExtraGridlineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 88
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxExtraGridlines
{{Fill AxExtraGridlines Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 89
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFilterFunction
{{Fill AxFilterFunction Description}}

```yaml
Type: System.Func`2[System.Double,System.Boolean]
Parameter Sets: (All)
Aliases:

Required: False
Position: 90
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFilterMaxValue
{{Fill AxFilterMaxValue Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 91
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFilterMinValue
{{Fill AxFilterMinValue Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 92
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFirstDayOfWeek
{{Fill AxFirstDayOfWeek Description}}

```yaml
Type: System.DayOfWeek
Parameter Sets: (All)
Aliases:
Accepted values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday

Required: False
Position: 151
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFont
{{Fill AxFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 136
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFontSize
{{Fill AxFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 137
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFontWeight
{{Fill AxFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 138
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFormatAsFractions
{{Fill AxFormatAsFractions Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 71
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFractionUnit
{{Fill AxFractionUnit Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 72
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxFractionUnitSymbol
{{Fill AxFractionUnitSymbol Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 73
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxGapWidth
{{Fill AxGapWidth Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 144
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxHighColor
{{Fill AxHighColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 156
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxIntervalLength
{{Fill AxIntervalLength Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 93
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxIntervalType
{{Fill AxIntervalType Description}}

```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:
Accepted values: Auto, Manual, Milliseconds, Seconds, Minutes, Hours, Days, Weeks, Months, Years

Required: False
Position: 152
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxInvalidCategoryColor
{{Fill AxInvalidCategoryColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 148
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxInvalidNumberColor
{{Fill AxInvalidNumberColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 155
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxIsAxisVisible
{{Fill AxIsAxisVisible Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 94
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxIsPanEnabled
{{Fill AxIsPanEnabled Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 95
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxIsTickCentered
{{Fill AxIsTickCentered Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 145
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxIsZoomEnabled
{{Fill AxIsZoomEnabled Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 96
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxItemsSource
{{Fill AxItemsSource Description}}

```yaml
Type: System.Collections.IEnumerable
Parameter Sets: (All)
Aliases:

Required: False
Position: 146
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxKey
{{Fill AxKey Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 97
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxLabelField
{{Fill AxLabelField Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 147
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxLabelFormatter
{{Fill AxLabelFormatter Description}}

```yaml
Type: System.Func`2[System.Double,System.String]
Parameter Sets: (All)
Aliases:

Required: False
Position: 98
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxLayer
{{Fill AxLayer Description}}

```yaml
Type: OxyPlot.Axes.AxisLayer
Parameter Sets: (All)
Aliases:
Accepted values: BelowSeries, AboveSeries

Required: False
Position: 99
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxLowColor
{{Fill AxLowColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 157
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMajorGridlineColor
{{Fill AxMajorGridlineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 100
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMajorGridlineStyle
{{Fill AxMajorGridlineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 101
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMajorGridlineThickness
{{Fill AxMajorGridlineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 102
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMajorStep
{{Fill AxMajorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 103
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMajorTickSize
{{Fill AxMajorTickSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 104
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMaximum
{{Fill AxMaximum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 105
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMaximumPadding
{{Fill AxMaximumPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 106
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMaximumRange
{{Fill AxMaximumRange Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 107
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinimum
{{Fill AxMinimum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 108
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinimumMajorStep
{{Fill AxMinimumMajorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 109
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinimumMinorStep
{{Fill AxMinimumMinorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 110
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinimumPadding
{{Fill AxMinimumPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 111
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinimumRange
{{Fill AxMinimumRange Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 112
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorGridlineColor
{{Fill AxMinorGridlineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 113
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorGridlineStyle
{{Fill AxMinorGridlineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 114
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorGridlineThickness
{{Fill AxMinorGridlineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 115
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorIntervalType
{{Fill AxMinorIntervalType Description}}

```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:
Accepted values: Auto, Manual, Milliseconds, Seconds, Minutes, Hours, Days, Weeks, Months, Years

Required: False
Position: 153
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorStep
{{Fill AxMinorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 116
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorTickSize
{{Fill AxMinorTickSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 118
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxMinorTicklineColor
{{Fill AxMinorTicklineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 117
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxPalette
{{Fill AxPalette Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 149
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxPosition
{{Fill AxPosition Description}}

```yaml
Type: OxyPlot.Axes.AxisPosition
Parameter Sets: (All)
Aliases:
Accepted values: None, Left, Right, Top, Bottom

Required: False
Position: 119
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxPositionAtZeroCrossing
{{Fill AxPositionAtZeroCrossing Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 120
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxPositionTier
{{Fill AxPositionTier Description}}

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 121
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxPowerPadding
{{Fill AxPowerPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 160
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxRenderAsImage
{{Fill AxRenderAsImage Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 158
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxSelectable
{{Fill AxSelectable Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 142
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxSelectionMode
{{Fill AxSelectionMode Description}}

```yaml
Type: OxyPlot.SelectionMode
Parameter Sets: (All)
Aliases:
Accepted values: All, Single, Multiple

Required: False
Position: 143
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxStartAngle
{{Fill AxStartAngle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 69
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxStartPosition
{{Fill AxStartPosition Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 122
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxStringFormat
{{Fill AxStringFormat Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 123
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTag
{{Fill AxTag Description}}

```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 139
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTextColor
{{Fill AxTextColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 140
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTickStyle
{{Fill AxTickStyle Description}}

```yaml
Type: OxyPlot.Axes.TickStyle
Parameter Sets: (All)
Aliases:
Accepted values: Crossing, Inside, Outside, None

Required: False
Position: 124
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTicklineColor
{{Fill AxTicklineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 125
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTimeZone
{{Fill AxTimeZone Description}}

```yaml
Type: System.TimeZoneInfo
Parameter Sets: (All)
Aliases:

Required: False
Position: 154
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitle
{{Fill AxTitle Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 126
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitleClippingLength
{{Fill AxTitleClippingLength Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 127
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitleColor
{{Fill AxTitleColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 128
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitleFont
{{Fill AxTitleFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 129
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitleFontSize
{{Fill AxTitleFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 130
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitleFontWeight
{{Fill AxTitleFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 131
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitleFormatString
{{Fill AxTitleFormatString Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 132
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxTitlePosition
{{Fill AxTitlePosition Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 133
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxToolTip
{{Fill AxToolTip Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 141
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxUnit
{{Fill AxUnit Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 134
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxUseSuperExponentialFormat
{{Fill AxUseSuperExponentialFormat Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 135
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Axis
{{Fill Axis Description}}

```yaml
Type: OxyPlot.Axes.Axis[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxisTierDistance
{{Fill AxisTierDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 47
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAbsoluteMaximum
{{Fill AyAbsoluteMaximum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 166
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAbsoluteMinimum
{{Fill AyAbsoluteMinimum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 167
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAngle
{{Fill AyAngle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 168
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAxisDistance
{{Fill AyAxisDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 171
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAxisTickToLabelDistance
{{Fill AyAxisTickToLabelDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 169
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAxisTitleDistance
{{Fill AyAxisTitleDistance Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 170
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAxislineColor
{{Fill AyAxislineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 172
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAxislineStyle
{{Fill AyAxislineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 173
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyAxislineThickness
{{Fill AyAxislineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 174
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyBase
{{Fill AyBase Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 251
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyCalendarWeekRule
{{Fill AyCalendarWeekRule Description}}

```yaml
Type: System.Globalization.CalendarWeekRule
Parameter Sets: (All)
Aliases:
Accepted values: FirstDay, FirstFullWeek, FirstFourDayWeek

Required: False
Position: 242
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyClipTitle
{{Fill AyClipTitle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 175
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyCropGridlines
{{Fill AyCropGridlines Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 176
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyEndAngle
{{Fill AyEndAngle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 162
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyEndPosition
{{Fill AyEndPosition Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 177
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyExtraGridlineColor
{{Fill AyExtraGridlineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 178
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyExtraGridlineStyle
{{Fill AyExtraGridlineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 179
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyExtraGridlineThickness
{{Fill AyExtraGridlineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 180
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyExtraGridlines
{{Fill AyExtraGridlines Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 181
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFilterFunction
{{Fill AyFilterFunction Description}}

```yaml
Type: System.Func`2[System.Double,System.Boolean]
Parameter Sets: (All)
Aliases:

Required: False
Position: 182
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFilterMaxValue
{{Fill AyFilterMaxValue Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 183
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFilterMinValue
{{Fill AyFilterMinValue Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 184
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFirstDayOfWeek
{{Fill AyFirstDayOfWeek Description}}

```yaml
Type: System.DayOfWeek
Parameter Sets: (All)
Aliases:
Accepted values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday

Required: False
Position: 243
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFont
{{Fill AyFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 228
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFontSize
{{Fill AyFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 229
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFontWeight
{{Fill AyFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 230
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFormatAsFractions
{{Fill AyFormatAsFractions Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 163
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFractionUnit
{{Fill AyFractionUnit Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 164
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyFractionUnitSymbol
{{Fill AyFractionUnitSymbol Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 165
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyGapWidth
{{Fill AyGapWidth Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 236
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyHighColor
{{Fill AyHighColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 248
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyIntervalLength
{{Fill AyIntervalLength Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 185
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyIntervalType
{{Fill AyIntervalType Description}}

```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:
Accepted values: Auto, Manual, Milliseconds, Seconds, Minutes, Hours, Days, Weeks, Months, Years

Required: False
Position: 244
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyInvalidCategoryColor
{{Fill AyInvalidCategoryColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 240
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyInvalidNumberColor
{{Fill AyInvalidNumberColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 247
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyIsAxisVisible
{{Fill AyIsAxisVisible Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 186
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyIsPanEnabled
{{Fill AyIsPanEnabled Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 187
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyIsTickCentered
{{Fill AyIsTickCentered Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 237
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyIsZoomEnabled
{{Fill AyIsZoomEnabled Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 188
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyItemsSource
{{Fill AyItemsSource Description}}

```yaml
Type: System.Collections.IEnumerable
Parameter Sets: (All)
Aliases:

Required: False
Position: 238
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyKey
{{Fill AyKey Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 189
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyLabelField
{{Fill AyLabelField Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 239
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyLabelFormatter
{{Fill AyLabelFormatter Description}}

```yaml
Type: System.Func`2[System.Double,System.String]
Parameter Sets: (All)
Aliases:

Required: False
Position: 190
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyLayer
{{Fill AyLayer Description}}

```yaml
Type: OxyPlot.Axes.AxisLayer
Parameter Sets: (All)
Aliases:
Accepted values: BelowSeries, AboveSeries

Required: False
Position: 191
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyLowColor
{{Fill AyLowColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 249
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMajorGridlineColor
{{Fill AyMajorGridlineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 192
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMajorGridlineStyle
{{Fill AyMajorGridlineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 193
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMajorGridlineThickness
{{Fill AyMajorGridlineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 194
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMajorStep
{{Fill AyMajorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 195
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMajorTickSize
{{Fill AyMajorTickSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 196
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMaximum
{{Fill AyMaximum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 197
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMaximumPadding
{{Fill AyMaximumPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 198
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMaximumRange
{{Fill AyMaximumRange Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 199
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinimum
{{Fill AyMinimum Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 200
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinimumMajorStep
{{Fill AyMinimumMajorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 201
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinimumMinorStep
{{Fill AyMinimumMinorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 202
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinimumPadding
{{Fill AyMinimumPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 203
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinimumRange
{{Fill AyMinimumRange Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 204
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorGridlineColor
{{Fill AyMinorGridlineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 205
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorGridlineStyle
{{Fill AyMinorGridlineStyle Description}}

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 206
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorGridlineThickness
{{Fill AyMinorGridlineThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 207
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorIntervalType
{{Fill AyMinorIntervalType Description}}

```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:
Accepted values: Auto, Manual, Milliseconds, Seconds, Minutes, Hours, Days, Weeks, Months, Years

Required: False
Position: 245
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorStep
{{Fill AyMinorStep Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 208
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorTickSize
{{Fill AyMinorTickSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 210
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyMinorTicklineColor
{{Fill AyMinorTicklineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 209
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyPalette
{{Fill AyPalette Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 241
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyPosition
{{Fill AyPosition Description}}

```yaml
Type: OxyPlot.Axes.AxisPosition
Parameter Sets: (All)
Aliases:
Accepted values: None, Left, Right, Top, Bottom

Required: False
Position: 211
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyPositionAtZeroCrossing
{{Fill AyPositionAtZeroCrossing Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 212
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyPositionTier
{{Fill AyPositionTier Description}}

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 213
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyPowerPadding
{{Fill AyPowerPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 252
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyRenderAsImage
{{Fill AyRenderAsImage Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 250
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AySelectable
{{Fill AySelectable Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 234
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AySelectionMode
{{Fill AySelectionMode Description}}

```yaml
Type: OxyPlot.SelectionMode
Parameter Sets: (All)
Aliases:
Accepted values: All, Single, Multiple

Required: False
Position: 235
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyStartAngle
{{Fill AyStartAngle Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 161
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyStartPosition
{{Fill AyStartPosition Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 214
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyStringFormat
{{Fill AyStringFormat Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 215
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTag
{{Fill AyTag Description}}

```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 231
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTextColor
{{Fill AyTextColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 232
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTickStyle
{{Fill AyTickStyle Description}}

```yaml
Type: OxyPlot.Axes.TickStyle
Parameter Sets: (All)
Aliases:
Accepted values: Crossing, Inside, Outside, None

Required: False
Position: 216
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTicklineColor
{{Fill AyTicklineColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 217
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTimeZone
{{Fill AyTimeZone Description}}

```yaml
Type: System.TimeZoneInfo
Parameter Sets: (All)
Aliases:

Required: False
Position: 246
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitle
{{Fill AyTitle Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 218
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitleClippingLength
{{Fill AyTitleClippingLength Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 219
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitleColor
{{Fill AyTitleColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 220
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitleFont
{{Fill AyTitleFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 221
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitleFontSize
{{Fill AyTitleFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 222
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitleFontWeight
{{Fill AyTitleFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 223
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitleFormatString
{{Fill AyTitleFormatString Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 224
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyTitlePosition
{{Fill AyTitlePosition Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 225
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyToolTip
{{Fill AyToolTip Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 233
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyUnit
{{Fill AyUnit Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 226
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyUseSuperExponentialFormat
{{Fill AyUseSuperExponentialFormat Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 227
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Background
{{Fill Background Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 15
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Culture
{{Fill Culture Description}}

```yaml
Type: System.Globalization.CultureInfo
Parameter Sets: (All)
Aliases:

Required: False
Position: 16
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultColors
{{Fill DefaultColors Description}}

```yaml
Type: System.Collections.Generic.IList`1[OxyPlot.OxyColor]
Parameter Sets: (All)
Aliases:

Required: False
Position: 17
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultFont
{{Fill DefaultFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 13
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultFontSize
{{Fill DefaultFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 14
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsLegendVisible
{{Fill IsLegendVisible Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 18
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendBackground
{{Fill LegendBackground Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 19
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendBorder
{{Fill LegendBorder Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 20
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendBorderThickness
{{Fill LegendBorderThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 21
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendColumnSpacing
{{Fill LegendColumnSpacing Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 22
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendFont
{{Fill LegendFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 23
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendFontSize
{{Fill LegendFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 24
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendFontWeight
{{Fill LegendFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 26
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendItemAlignment
{{Fill LegendItemAlignment Description}}

```yaml
Type: OxyPlot.HorizontalAlignment
Parameter Sets: (All)
Aliases:
Accepted values: Center, Right, Left

Required: False
Position: 27
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendItemOrder
{{Fill LegendItemOrder Description}}

```yaml
Type: OxyPlot.LegendItemOrder
Parameter Sets: (All)
Aliases:
Accepted values: Normal, Reverse

Required: False
Position: 28
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendItemSpacing
{{Fill LegendItemSpacing Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 29
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendLineSpacing
{{Fill LegendLineSpacing Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 30
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendMargin
{{Fill LegendMargin Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 31
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendMaxHeight
{{Fill LegendMaxHeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 33
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendMaxWidth
{{Fill LegendMaxWidth Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 32
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendOrientation
{{Fill LegendOrientation Description}}

```yaml
Type: OxyPlot.LegendOrientation
Parameter Sets: (All)
Aliases:
Accepted values: Horizontal, Vertical

Required: False
Position: 34
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendPadding
{{Fill LegendPadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 35
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendPlacement
{{Fill LegendPlacement Description}}

```yaml
Type: OxyPlot.LegendPlacement
Parameter Sets: (All)
Aliases:
Accepted values: Inside, Outside

Required: False
Position: 36
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendPosition
{{Fill LegendPosition Description}}

```yaml
Type: OxyPlot.LegendPosition
Parameter Sets: (All)
Aliases:
Accepted values: TopLeft, TopCenter, TopRight, BottomLeft, BottomCenter, BottomRight, LeftTop, LeftMiddle, LeftBottom, RightTop, RightMiddle, RightBottom

Required: False
Position: 37
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendSymbolLength
{{Fill LegendSymbolLength Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 38
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendSymbolMargin
{{Fill LegendSymbolMargin Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 39
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendSymbolPlacement
{{Fill LegendSymbolPlacement Description}}

```yaml
Type: OxyPlot.LegendSymbolPlacement
Parameter Sets: (All)
Aliases:
Accepted values: Left, Right

Required: False
Position: 40
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendTextColor
{{Fill LegendTextColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 25
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendTitle
{{Fill LegendTitle Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 41
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendTitleColor
{{Fill LegendTitleColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 42
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendTitleFont
{{Fill LegendTitleFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 43
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendTitleFontSize
{{Fill LegendTitleFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 44
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegendTitleFontWeight
{{Fill LegendTitleFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 45
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutFile
{{Fill OutFile Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutHeight
{{Fill OutHeight Description}}

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutWidth
{{Fill OutWidth Description}}

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Padding
{{Fill Padding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 46
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
{{Fill PassThru Description}}

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlotAreaBackground
{{Fill PlotAreaBackground Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 48
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlotAreaBorderColor
{{Fill PlotAreaBorderColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 49
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlotAreaBorderThickness
{{Fill PlotAreaBorderThickness Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 50
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlotMargins
{{Fill PlotMargins Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 51
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlotType
{{Fill PlotType Description}}

```yaml
Type: OxyPlot.PlotType
Parameter Sets: (All)
Aliases:
Accepted values: XY, Cartesian, Polar

Required: False
Position: 52
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RenderingDecorator
{{Fill RenderingDecorator Description}}

```yaml
Type: System.Func`2[OxyPlot.IRenderContext,OxyPlot.IRenderContext]
Parameter Sets: (All)
Aliases:

Required: False
Position: 53
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReuseWindow
{{Fill ReuseWindow Description}}

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 12
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelectionColor
{{Fill SelectionColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 68
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Series
{{Fill Series Description}}

```yaml
Type: OxyPlot.Series.Series
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SeriesInfo
{{Fill SeriesInfo Description}}

```yaml
Type: Horker.OxyPlotCli.ISeriesInfo
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Show
{{Fill Show Description}}

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Style
{{Fill Style Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subtitle
{{Fill Subtitle Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 54
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubtitleColor
{{Fill SubtitleColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 62
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubtitleFont
{{Fill SubtitleFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 55
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubtitleFontSize
{{Fill SubtitleFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 56
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubtitleFontWeight
{{Fill SubtitleFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 57
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SvgIsDocument
{{Fill SvgIsDocument Description}}

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextColor
{{Fill TextColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 58
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
{{Fill Title Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 59
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleColor
{{Fill TitleColor Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 61
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFont
{{Fill TitleFont Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 64
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFontSize
{{Fill TitleFontSize Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 65
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleFontWeight
{{Fill TitleFontWeight Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 66
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleHorizontalAlignment
{{Fill TitleHorizontalAlignment Description}}

```yaml
Type: OxyPlot.TitleHorizontalAlignment
Parameter Sets: (All)
Aliases:
Accepted values: CenteredWithinPlotArea, CenteredWithinView

Required: False
Position: 63
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitlePadding
{{Fill TitlePadding Description}}

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 67
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TitleToolTip
{{Fill TitleToolTip Description}}

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 60
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### OxyPlot.Series.Series
### Horker.OxyPlotCli.ISeriesInfo
## OUTPUTS

### OxyPlot.PlotModel
## NOTES

## RELATED LINKS
