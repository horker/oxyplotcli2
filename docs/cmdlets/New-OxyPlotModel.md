---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/New-OxyPlotModel.md
schema: 2.0.0
---

# New-OxyPlotModel

## SYNOPSIS

Returns an object that represents a plot.
 


## SYNTAX

```
New-OxyPlotModel [-InputObject <Object>] [[-Series] <Series[]>] [[-SeriesInfo] <ISeriesInfo[]>]
 [-PlotModel <PlotModel>] [[-Axis] <Axis[]>] [[-Annotation] <Annotation[]>] [[-OutFile] <String>]
 [[-OutWidth] <Int32>] [[-OutHeight] <Int32>] [-SvgIsDocument] [-PassThru] [[-Style] <String>] [-AsPlotView]
 [-Show] [-ReuseWindow] [[-DefaultFont] <String>] [[-DefaultFontSize] <Double>] [[-Background] <OxyColor>]
 [[-Culture] <CultureInfo>] [[-DefaultColors] <System.Collections.Generic.IList`1[OxyPlot.OxyColor]>]
 [[-IsLegendVisible] <Bool>] [[-LegendBackground] <OxyColor>] [[-LegendBorder] <OxyColor>]
 [[-LegendBorderThickness] <Double>] [[-LegendColumnSpacing] <Double>] [[-LegendFont] <String>]
 [[-LegendFontSize] <Double>] [[-LegendTextColor] <OxyColor>] [[-LegendFontWeight] <Double>]
 [[-LegendItemAlignment] <HorizontalAlignment>] [[-LegendItemOrder] <LegendItemOrder>]
 [[-LegendItemSpacing] <Double>] [[-LegendLineSpacing] <Double>] [[-LegendMargin] <Double>]
 [[-LegendMaxWidth] <Double>] [[-LegendMaxHeight] <Double>] [[-LegendOrientation] <LegendOrientation>]
 [[-LegendPadding] <Double>] [[-LegendPlacement] <LegendPlacement>] [[-LegendPosition] <LegendPosition>]
 [[-LegendSymbolLength] <Double>] [[-LegendSymbolMargin] <Double>]
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

Returns an object that represents a plot.
 


## PARAMETERS

### -Annotation



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

### -AxAbsoluteMaximum

Specifies the AbsoluteMaximum parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AbsoluteMinimum parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Angle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxisDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxisTickToLabelDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxisTitleDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxislineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxislineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxislineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Base parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the CalendarWeekRule parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ClipTitle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the CropGridlines parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the EndAngle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the EndPosition parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlines parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FilterFunction parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FilterMaxValue parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FilterMinValue parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FirstDayOfWeek parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Font parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FontSize parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FontWeight parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FormatAsFractions parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FractionUnit parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FractionUnitSymbol parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the GapWidth parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the HighColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IntervalLength parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IntervalType parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the InvalidCategoryColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the InvalidNumberColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsAxisVisible parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsPanEnabled parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsTickCentered parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsZoomEnabled parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ItemsSource parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Key parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the LabelField parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the LabelFormatter parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Layer parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the LowColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorGridlineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorGridlineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorGridlineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorStep parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorTickSize parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Maximum parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MaximumPadding parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MaximumRange parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Minimum parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumMajorStep parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumMinorStep parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumPadding parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumRange parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorGridlineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorGridlineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorGridlineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorIntervalType parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorStep parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorTickSize parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorTicklineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Palette parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Position parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the PositionAtZeroCrossing parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the PositionTier parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the PowerPadding parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the RenderAsImage parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Selectable parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the SelectionMode parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the StartAngle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the StartPosition parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the StringFormat parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Tag parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TextColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TickStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TicklineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TimeZone parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Title parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleClippingLength parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFont parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFontSize parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFontWeight parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFormatString parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitlePosition parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ToolTip parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Unit parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the UseSuperExponentialFormat parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the is parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the isTierDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AbsoluteMaximum parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AbsoluteMinimum parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Angle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxisDistance parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxisTickToLabelDistance parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxisTitleDistance parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxislineColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxislineStyle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the AxislineThickness parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Base parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the CalendarWeekRule parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ClipTitle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the CropGridlines parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the EndAngle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the EndPosition parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlineColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlineStyle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlineThickness parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ExtraGridlines parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FilterFunction parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FilterMaxValue parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FilterMinValue parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FirstDayOfWeek parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Font parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FontSize parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FontWeight parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FormatAsFractions parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FractionUnit parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the FractionUnitSymbol parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the GapWidth parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the HighColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IntervalLength parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IntervalType parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the InvalidCategoryColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the InvalidNumberColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsAxisVisible parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsPanEnabled parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsTickCentered parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the IsZoomEnabled parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ItemsSource parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Key parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the LabelField parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the LabelFormatter parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Layer parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the LowColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorGridlineColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorGridlineStyle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorGridlineThickness parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorStep parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MajorTickSize parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Maximum parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MaximumPadding parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MaximumRange parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Minimum parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumMajorStep parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumMinorStep parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumPadding parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinimumRange parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorGridlineColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorGridlineStyle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorGridlineThickness parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorIntervalType parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorStep parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorTickSize parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the MinorTicklineColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Palette parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Position parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the PositionAtZeroCrossing parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the PositionTier parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the PowerPadding parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the RenderAsImage parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Selectable parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the SelectionMode parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the StartAngle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the StartPosition parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the StringFormat parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Tag parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TextColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TickStyle parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TicklineColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TimeZone parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Title parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleClippingLength parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleColor parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFont parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFontSize parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFontWeight parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitleFormatString parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the TitlePosition parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the ToolTip parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the Unit parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Specifies the UseSuperExponentialFormat parameter of the y-axis. For more details, refer to the help topic of the axis of interest.

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

Sets the color of the background of the plot.
 
If the background color is set to OxyPlot.OxyColors.Undefined, the default color of the plot view will be used.


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

Sets the culture.
 


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

Sets the default colors.
 


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

Sets the default font.
 
This font is used for text on axes, series, legends and plot titles unless other fonts are specified.


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

Sets the default size of the fonts.
 


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

Sets a value indicating whether the legend is visible. The titles of the series must be set to use the legend.
 


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

Sets the background color of the legend. Use null for no background.
 


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

Sets the border color of the legend.
 


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

Sets the thickness of the legend border. Use 0 for no border.
 


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

Sets the spacing between columns of legend items (only for vertical orientation).
 


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

Sets the legend font.
 


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

Sets the size of the legend font.
 


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

Sets the legend font weight.
 


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

Sets the legend item alignment.
 


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

Sets the legend item order.
 


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

Sets the horizontal spacing between legend items when the orientation is horizontal.
 


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

Sets the vertical spacing between legend items.
 


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

Sets the legend margin.
 


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

Sets the max height of the legend.
 


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

Sets the max width of the legend.
 


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

Sets the legend orientation.
 


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

Sets the legend padding.
 


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

Sets the legend placement.
 


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

Sets the legend position.
 


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

Sets the length of the legend symbols (the default value is 16).
 


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

Sets the legend symbol margins (distance between the symbol and the text).
 


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

Sets the legend symbol placement.
 


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

Sets the color of the legend text.
 
If this value is null, the TextColor will be used.


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

Sets the legend title.
 


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

Sets the color of the legend title.
 
If this value is null, the TextColor will be used.


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

Sets the legend title font.
 


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

Sets the size of the legend title font.
 


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

Sets the legend title font weight.
 


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

Specifies the output file name. The output format is determined based on the file extension, which should be either ".png" or ".svg".

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

Specifies the height of the output image. Use with the -OutFile parameter.

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

Specifies the width of the output image. Use with the -OutFile parameter.

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

Sets the padding around the plot.
 


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

Returns a created object when the -AddTo, -OutFile or -Show parameter is specified.

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

Sets the color of the background of the plot area.
 


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

Sets the color of the border around the plot area.
 


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

Sets the thickness of the border around the plot area.
 


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

Sets the margins around the plot (this should be large enough to fit the axes).
 If any of the values is set to double.NaN, the margin is adjusted to the value required by the axes.
 


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

Sets the type of the coordinate system.
 


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

Sets the rendering decorator.
 


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

Indicates to reuse the most recently used window to show the chart instead of creating a new one. Use with the -Show parameter.

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

Sets the color of the selection.
 


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

Gets the series.
 


```yaml
Type: OxyPlot.Series.Series[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SeriesInfo



```yaml
Type: Horker.OxyPlotCli.ISeriesInfo[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Show

Shows the chart in the GUI window.

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

Specifies the style.

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

Sets the subtitle.
 


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

Sets the color of the subtitle.
 


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

Sets the subtitle font. If this property is null, the Title font will be used.
 


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

Sets the size of the subtitle font.
 


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

Sets the subtitle font weight.
 


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

Indicates that a SVG file should be generated as a complete document. Use with the -OutFile parameter.

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

Sets the default color of the text in the plot (titles, legends, annotations, axes).
 


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

Sets the title.
 


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

Sets the color of the title.
 
If the value is null, the TextColor will be used.


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

Sets the title font.
 


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

Sets the size of the title font.
 


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

Sets the title font weight.
 


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

Sets the horizontal alignment of the title and subtitle.
 


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

Sets the padding around the title.
 


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

Sets the title tool tip.
 


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

### -InputObject

Specifies a dataset that represents the data points of the series.

```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PlotModel



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

### -AsPlotView

Returns an object as a PlotView object.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### OxyPlot.Series.Series
### Horker.OxyPlotCli.ISeriesInfo
## OUTPUTS

### OxyPlot.PlotModel
## NOTES

## RELATED LINKS


