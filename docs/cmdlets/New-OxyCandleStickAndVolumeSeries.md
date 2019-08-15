---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/New-OxyCandleStickAndVolumeSeries.md
schema: 2.0.0
---

# New-OxyCandleStickAndVolumeSeries

## SYNOPSIS

Returns an object that represents a dual view (candlestick + volume) series for OHLCV bars
 
 Note that to use this series, one *must* define two y-axes, one named "Bars" and the other named
 "Volume". Typically would set up the volume on StartPosition =0, EndPosition = fraction and for
 the bar axis StartPosition = fraction + delta, EndPosition = 1.0.
 
See [link](http://www.mathworks.com/help/toolbox/finance/highlowfts.html)


## SYNTAX

```
New-OxyCandleStickAndVolumeSeries [[-InputObject] <PSObject>] [[-XName] <String>] [[-OpenName] <String>]
 [[-HighName] <String>] [[-LowName] <String>] [[-CloseName] <String>] [[-BuyVolumeName] <String>]
 [[-SellVolumeName] <String>] [[-GroupName] <String>] [[-X] <Double[]>] [[-Open] <Double[]>]
 [[-High] <Double[]>] [[-Low] <Double[]>] [[-Close] <Double[]>] [[-BuyVolume] <Double[]>]
 [[-SellVolume] <Double[]>] [[-Group] <Object[]>] [[-AddTo] <PlotModel>] [[-OutFile] <String>]
 [[-OutWidth] <Int32>] [[-OutHeight] <Int32>] [-SvgIsDocument] [-PassThru] [[-Style] <String>] [-AsPlotView]
 [-Show] [-ReuseWindow] [[-Items] <System.Collections.Generic.List`1[OxyPlot.Series.OhlcvItem]>]
 [[-VolumeAxisKey] <String>] [[-BarAxisKey] <String>] [[-VolumeStyle] <VolumeStyle>]
 [[-StrokeThickness] <Double>] [[-StrokeIntensity] <Double>] [[-SeparatorStrokeThickness] <Double>]
 [[-SeparatorLineStyle] <LineStyle>] [[-PositiveColor] <OxyColor>] [[-NegativeColor] <OxyColor>]
 [[-SeparatorColor] <OxyColor>] [[-PositiveHollow] <Bool>] [[-NegativeHollow] <Bool>] [[-CandleWidth] <Double>]
 [[-XAxisKey] <String>] [[-YAxisKey] <String>] [[-ItemsSource] <IEnumerable>] [[-Background] <OxyColor>]
 [[-IsVisible] <Bool>] [[-Title] <String>] [[-RenderInLegend] <Bool>] [[-TrackerFormatString] <String>]
 [[-TrackerKey] <String>] [[-Font] <String>] [[-FontSize] <Double>] [[-FontWeight] <Double>] [[-Tag] <Object>]
 [[-TextColor] <OxyColor>] [[-ToolTip] <String>] [[-Selectable] <Bool>] [[-SelectionMode] <SelectionMode>]
 [[-AxType] <String>] [[-AxStartAngle] <Double>] [[-AxEndAngle] <Double>] [[-AxFormatAsFractions] <Bool>]
 [[-AxFractionUnit] <Double>] [[-AxFractionUnitSymbol] <String>] [[-AxAbsoluteMaximum] <Double>]
 [[-AxAbsoluteMinimum] <Double>] [[-AxAngle] <Double>] [[-AxAxisTickToLabelDistance] <Double>]
 [[-AxAxisTitleDistance] <Double>] [[-AxAxisDistance] <Double>] [[-AxAxislineColor] <OxyColor>]
 [[-AxAxislineStyle] <LineStyle>] [[-AxAxislineThickness] <Double>] [[-AxClipTitle] <Bool>]
 [[-AxCropGridlines] <Bool>] [[-AxEndPosition] <Double>] [[-AxExtraGridlineColor] <OxyColor>]
 [[-AxExtraGridlineStyle] <LineStyle>] [[-AxExtraGridlineThickness] <Double>] [[-AxExtraGridlines] <Double[]>]
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
 [[-AyType] <String>] [[-AyStartAngle] <Double>] [[-AyEndAngle] <Double>] [[-AyFormatAsFractions] <Bool>]
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
 [[-AzType] <String>] [[-AzStartAngle] <Double>] [[-AzEndAngle] <Double>] [[-AzFormatAsFractions] <Bool>]
 [[-AzFractionUnit] <Double>] [[-AzFractionUnitSymbol] <String>] [[-AzAbsoluteMaximum] <Double>]
 [[-AzAbsoluteMinimum] <Double>] [[-AzAngle] <Double>] [[-AzAxisTickToLabelDistance] <Double>]
 [[-AzAxisTitleDistance] <Double>] [[-AzAxisDistance] <Double>] [[-AzAxislineColor] <OxyColor>]
 [[-AzAxislineStyle] <LineStyle>] [[-AzAxislineThickness] <Double>] [[-AzClipTitle] <Bool>]
 [[-AzCropGridlines] <Bool>] [[-AzEndPosition] <Double>] [[-AzExtraGridlineColor] <OxyColor>]
 [[-AzExtraGridlineStyle] <LineStyle>] [[-AzExtraGridlineThickness] <Double>] [[-AzExtraGridlines] <Double[]>]
 [[-AzFilterFunction] <System.Func`2[System.Double,System.Boolean]>] [[-AzFilterMaxValue] <Double>]
 [[-AzFilterMinValue] <Double>] [[-AzIntervalLength] <Double>] [[-AzIsAxisVisible] <Bool>]
 [[-AzIsPanEnabled] <Bool>] [[-AzIsZoomEnabled] <Bool>] [[-AzKey] <String>]
 [[-AzLabelFormatter] <System.Func`2[System.Double,System.String]>] [[-AzLayer] <AxisLayer>]
 [[-AzMajorGridlineColor] <OxyColor>] [[-AzMajorGridlineStyle] <LineStyle>]
 [[-AzMajorGridlineThickness] <Double>] [[-AzMajorStep] <Double>] [[-AzMajorTickSize] <Double>]
 [[-AzMaximum] <Double>] [[-AzMaximumPadding] <Double>] [[-AzMaximumRange] <Double>] [[-AzMinimum] <Double>]
 [[-AzMinimumMajorStep] <Double>] [[-AzMinimumMinorStep] <Double>] [[-AzMinimumPadding] <Double>]
 [[-AzMinimumRange] <Double>] [[-AzMinorGridlineColor] <OxyColor>] [[-AzMinorGridlineStyle] <LineStyle>]
 [[-AzMinorGridlineThickness] <Double>] [[-AzMinorStep] <Double>] [[-AzMinorTicklineColor] <OxyColor>]
 [[-AzMinorTickSize] <Double>] [[-AzPosition] <AxisPosition>] [[-AzPositionAtZeroCrossing] <Bool>]
 [[-AzPositionTier] <Int32>] [[-AzStartPosition] <Double>] [[-AzStringFormat] <String>]
 [[-AzTickStyle] <TickStyle>] [[-AzTicklineColor] <OxyColor>] [[-AzTitle] <String>]
 [[-AzTitleClippingLength] <Double>] [[-AzTitleColor] <OxyColor>] [[-AzTitleFont] <String>]
 [[-AzTitleFontSize] <Double>] [[-AzTitleFontWeight] <Double>] [[-AzTitleFormatString] <String>]
 [[-AzTitlePosition] <Double>] [[-AzUnit] <String>] [[-AzUseSuperExponentialFormat] <Bool>]
 [[-AzFont] <String>] [[-AzFontSize] <Double>] [[-AzFontWeight] <Double>] [[-AzTag] <Object>]
 [[-AzTextColor] <OxyColor>] [[-AzToolTip] <String>] [[-AzSelectable] <Bool>]
 [[-AzSelectionMode] <SelectionMode>] [[-AzGapWidth] <Double>] [[-AzIsTickCentered] <Bool>]
 [[-AzItemsSource] <IEnumerable>] [[-AzLabelField] <String>] [[-AzInvalidCategoryColor] <OxyColor>]
 [[-AzPalette] <OxyPaletteItem[]>] [[-AzCalendarWeekRule] <CalendarWeekRule>] [[-AzFirstDayOfWeek] <DayOfWeek>]
 [[-AzIntervalType] <DateTimeIntervalType>] [[-AzMinorIntervalType] <DateTimeIntervalType>]
 [[-AzTimeZone] <TimeZoneInfo>] [[-AzInvalidNumberColor] <OxyColor>] [[-AzHighColor] <OxyColor>]
 [[-AzLowColor] <OxyColor>] [[-AzRenderAsImage] <Bool>] [[-AzBase] <Double>] [[-AzPowerPadding] <Bool>]
 [<CommonParameters>]
```

## DESCRIPTION

Returns an object that represents a dual view (candlestick + volume) series for OHLCV bars
 
 Note that to use this series, one *must* define two y-axes, one named "Bars" and the other named
 "Volume". Typically would set up the volume on StartPosition =0, EndPosition = fraction and for
 the bar axis StartPosition = fraction + delta, EndPosition = 1.0.
 
See [link](http://www.mathworks.com/help/toolbox/finance/highlowfts.html)


## PARAMETERS

### -AddTo

Specifies the PlotModel object to which the object is added.

```yaml
Type: OxyPlot.PlotModel
Parameter Sets: (All)
Aliases:

Required: False
Position: 17
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
Position: 64
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
Position: 65
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
Position: 66
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
Position: 69
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
Position: 67
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
Position: 68
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
Position: 70
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
Position: 71
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
Position: 72
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
Position: 149
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
Position: 140
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
Position: 73
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
Position: 74
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
Position: 60
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
Position: 75
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
Position: 76
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
Position: 77
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
Position: 78
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
Position: 79
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
Position: 80
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
Position: 81
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
Position: 82
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
Position: 141
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
Position: 126
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
Position: 127
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
Position: 128
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
Position: 61
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
Position: 62
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
Position: 63
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
Position: 134
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
Position: 146
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
Position: 83
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
Position: 142
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
Position: 138
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
Position: 145
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
Position: 84
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
Position: 85
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
Position: 135
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
Position: 86
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
Position: 136
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
Position: 87
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
Position: 137
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
Position: 88
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
Position: 89
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
Position: 147
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
Position: 90
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
Position: 91
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
Position: 92
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
Position: 93
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
Position: 94
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
Position: 95
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
Position: 96
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
Position: 97
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
Position: 98
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
Position: 99
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
Position: 100
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
Position: 101
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
Position: 102
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
Position: 103
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
Position: 104
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
Position: 105
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
Position: 143
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
Position: 106
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
Position: 108
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
Position: 107
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
Position: 139
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
Position: 109
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
Position: 110
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
Position: 111
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
Position: 150
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
Position: 148
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
Position: 132
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
Position: 133
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
Position: 59
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
Position: 112
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
Position: 113
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
Position: 129
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
Position: 130
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
Position: 114
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
Position: 115
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
Position: 144
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
Position: 116
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
Position: 117
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
Position: 118
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
Position: 119
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
Position: 120
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
Position: 121
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
Position: 122
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
Position: 123
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
Position: 131
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AxType

Specifies the (partial) type name of the x-axis.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 58
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
Position: 124
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
Position: 125
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
Position: 157
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
Position: 158
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
Position: 159
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
Position: 162
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
Position: 160
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
Position: 161
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
Position: 163
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
Position: 164
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
Position: 165
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
Position: 242
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
Position: 233
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
Position: 166
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
Position: 167
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
Position: 153
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
Position: 168
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
Position: 169
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
Position: 170
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
Position: 171
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
Position: 172
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
Position: 173
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
Position: 174
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
Position: 175
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
Position: 234
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
Position: 219
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
Position: 220
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
Position: 221
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
Position: 154
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
Position: 155
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
Position: 156
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
Position: 227
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
Position: 239
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
Position: 176
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
Position: 235
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
Position: 231
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
Position: 238
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
Position: 177
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
Position: 178
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
Position: 228
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
Position: 179
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
Position: 229
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
Position: 180
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
Position: 230
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
Position: 181
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
Position: 182
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
Position: 240
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
Position: 183
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
Position: 184
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
Position: 185
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
Position: 186
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
Position: 187
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
Position: 188
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
Position: 189
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
Position: 190
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
Position: 191
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
Position: 192
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
Position: 193
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
Position: 194
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
Position: 195
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
Position: 196
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
Position: 197
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
Position: 198
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
Position: 236
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
Position: 199
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
Position: 201
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
Position: 200
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
Position: 232
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
Position: 202
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
Position: 203
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
Position: 204
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
Position: 243
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
Position: 241
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
Position: 225
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
Position: 226
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
Position: 152
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
Position: 205
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
Position: 206
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
Position: 222
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
Position: 223
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
Position: 207
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
Position: 208
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
Position: 237
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
Position: 209
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
Position: 210
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
Position: 211
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
Position: 212
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
Position: 213
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
Position: 214
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
Position: 215
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
Position: 216
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
Position: 224
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AyType

Specifies the (partial) type name of the y-axis.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 151
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
Position: 217
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
Position: 218
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAbsoluteMaximum

Specifies the AbsoluteMaximum parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 250
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAbsoluteMinimum

Specifies the AbsoluteMinimum parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

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

### -AzAngle

Specifies the Angle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 252
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAxisDistance

Specifies the AxisDistance parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 255
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAxisTickToLabelDistance

Specifies the AxisTickToLabelDistance parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 253
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAxisTitleDistance

Specifies the AxisTitleDistance parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 254
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAxislineColor

Specifies the AxislineColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 256
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAxislineStyle

Specifies the AxislineStyle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 257
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzAxislineThickness

Specifies the AxislineThickness parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 258
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzBase

Specifies the Base parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 335
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzCalendarWeekRule

Specifies the CalendarWeekRule parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Globalization.CalendarWeekRule
Parameter Sets: (All)
Aliases:
Accepted values: FirstDay, FirstFullWeek, FirstFourDayWeek

Required: False
Position: 326
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzClipTitle

Specifies the ClipTitle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 259
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzCropGridlines

Specifies the CropGridlines parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 260
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzEndAngle

Specifies the EndAngle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 246
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzEndPosition

Specifies the EndPosition parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 261
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzExtraGridlineColor

Specifies the ExtraGridlineColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 262
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzExtraGridlineStyle

Specifies the ExtraGridlineStyle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 263
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzExtraGridlineThickness

Specifies the ExtraGridlineThickness parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 264
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzExtraGridlines

Specifies the ExtraGridlines parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 265
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFilterFunction

Specifies the FilterFunction parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Func`2[System.Double,System.Boolean]
Parameter Sets: (All)
Aliases:

Required: False
Position: 266
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFilterMaxValue

Specifies the FilterMaxValue parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 267
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFilterMinValue

Specifies the FilterMinValue parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 268
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFirstDayOfWeek

Specifies the FirstDayOfWeek parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.DayOfWeek
Parameter Sets: (All)
Aliases:
Accepted values: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday

Required: False
Position: 327
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFont

Specifies the Font parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 312
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFontSize

Specifies the FontSize parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 313
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFontWeight

Specifies the FontWeight parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 314
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFormatAsFractions

Specifies the FormatAsFractions parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 247
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFractionUnit

Specifies the FractionUnit parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 248
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzFractionUnitSymbol

Specifies the FractionUnitSymbol parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 249
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzGapWidth

Specifies the GapWidth parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 320
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzHighColor

Specifies the HighColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 332
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzIntervalLength

Specifies the IntervalLength parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 269
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzIntervalType

Specifies the IntervalType parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:
Accepted values: Auto, Manual, Milliseconds, Seconds, Minutes, Hours, Days, Weeks, Months, Years

Required: False
Position: 328
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzInvalidCategoryColor

Specifies the InvalidCategoryColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 324
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzInvalidNumberColor

Specifies the InvalidNumberColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 331
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzIsAxisVisible

Specifies the IsAxisVisible parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 270
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzIsPanEnabled

Specifies the IsPanEnabled parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 271
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzIsTickCentered

Specifies the IsTickCentered parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 321
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzIsZoomEnabled

Specifies the IsZoomEnabled parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 272
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzItemsSource

Specifies the ItemsSource parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Collections.IEnumerable
Parameter Sets: (All)
Aliases:

Required: False
Position: 322
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzKey

Specifies the Key parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 273
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzLabelField

Specifies the LabelField parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 323
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzLabelFormatter

Specifies the LabelFormatter parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Func`2[System.Double,System.String]
Parameter Sets: (All)
Aliases:

Required: False
Position: 274
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzLayer

Specifies the Layer parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.Axes.AxisLayer
Parameter Sets: (All)
Aliases:
Accepted values: BelowSeries, AboveSeries

Required: False
Position: 275
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzLowColor

Specifies the LowColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 333
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMajorGridlineColor

Specifies the MajorGridlineColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 276
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMajorGridlineStyle

Specifies the MajorGridlineStyle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 277
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMajorGridlineThickness

Specifies the MajorGridlineThickness parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 278
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMajorStep

Specifies the MajorStep parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 279
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMajorTickSize

Specifies the MajorTickSize parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 280
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMaximum

Specifies the Maximum parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 281
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMaximumPadding

Specifies the MaximumPadding parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 282
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMaximumRange

Specifies the MaximumRange parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 283
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinimum

Specifies the Minimum parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 284
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinimumMajorStep

Specifies the MinimumMajorStep parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 285
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinimumMinorStep

Specifies the MinimumMinorStep parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 286
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinimumPadding

Specifies the MinimumPadding parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 287
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinimumRange

Specifies the MinimumRange parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 288
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorGridlineColor

Specifies the MinorGridlineColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 289
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorGridlineStyle

Specifies the MinorGridlineStyle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 290
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorGridlineThickness

Specifies the MinorGridlineThickness parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 291
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorIntervalType

Specifies the MinorIntervalType parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.Axes.DateTimeIntervalType
Parameter Sets: (All)
Aliases:
Accepted values: Auto, Manual, Milliseconds, Seconds, Minutes, Hours, Days, Weeks, Months, Years

Required: False
Position: 329
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorStep

Specifies the MinorStep parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 292
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorTickSize

Specifies the MinorTickSize parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 294
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzMinorTicklineColor

Specifies the MinorTicklineColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 293
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzPalette

Specifies the Palette parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyPaletteItem[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 325
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzPosition

Specifies the Position parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.Axes.AxisPosition
Parameter Sets: (All)
Aliases:
Accepted values: None, Left, Right, Top, Bottom

Required: False
Position: 295
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzPositionAtZeroCrossing

Specifies the PositionAtZeroCrossing parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 296
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzPositionTier

Specifies the PositionTier parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 297
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzPowerPadding

Specifies the PowerPadding parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 336
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzRenderAsImage

Specifies the RenderAsImage parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 334
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzSelectable

Specifies the Selectable parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 318
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzSelectionMode

Specifies the SelectionMode parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.SelectionMode
Parameter Sets: (All)
Aliases:
Accepted values: All, Single, Multiple

Required: False
Position: 319
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzStartAngle

Specifies the StartAngle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 245
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzStartPosition

Specifies the StartPosition parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 298
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzStringFormat

Specifies the StringFormat parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 299
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTag

Specifies the Tag parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 315
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTextColor

Specifies the TextColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 316
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTickStyle

Specifies the TickStyle parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: OxyPlot.Axes.TickStyle
Parameter Sets: (All)
Aliases:
Accepted values: Crossing, Inside, Outside, None

Required: False
Position: 300
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTicklineColor

Specifies the TicklineColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 301
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTimeZone

Specifies the TimeZone parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.TimeZoneInfo
Parameter Sets: (All)
Aliases:

Required: False
Position: 330
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitle

Specifies the Title parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 302
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitleClippingLength

Specifies the TitleClippingLength parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 303
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitleColor

Specifies the TitleColor parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 304
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitleFont

Specifies the TitleFont parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 305
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitleFontSize

Specifies the TitleFontSize parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 306
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitleFontWeight

Specifies the TitleFontWeight parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 307
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitleFormatString

Specifies the TitleFormatString parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 308
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzTitlePosition

Specifies the TitlePosition parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 309
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzToolTip

Specifies the ToolTip parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 317
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzType

Specifies the (partial) type name of the series-specific additional axis.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 244
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzUnit

Specifies the Unit parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 310
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzUseSuperExponentialFormat

Specifies the UseSuperExponentialFormat parameter of the series-specific additional axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 311
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Background

Sets the background color of the series. The default is OxyColors.Undefined.
 
This property defines the background color in the area defined by the x and y axes used by this series.


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 44
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BarAxisKey

Sets the bar axis key (defaults to null, as is the primary axis).
 


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 29
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BuyVolume

Specifies the sequence of the element BuyVolume of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 14
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BuyVolumeName

Specifies the property name of the input object to be processed as the element BuyVolume of the data point.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CandleWidth

Sets the bar width in data units (for example if the X axis is date-time based, then should
 use the difference of DateTimeAxis.ToDouble(date) to indicate the width). By default candlestick
 series will use 0.80 x the minimum difference in data points.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 40
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Close

Specifies the sequence of the element Close of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 13
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CloseName

Specifies the property name of the input object to be processed as the element Close of the data point.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Font

Sets the font. The default is null (use OxyPlot.PlotModel.DefaultFont.
 
If the value is null, the DefaultFont of the parent PlotModel will be used.


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 50
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FontSize

Sets the size of the font. The default is double.NaN (use OxyPlot.PlotModel.DefaultFontSize).
 
If the value is NaN, the DefaultFontSize of the parent PlotModel will be used.


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 51
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FontWeight

Sets the font weight. The default is FontWeights.Normal.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double
Parameter Sets: (All)
Aliases:

Required: False
Position: 52
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Group

Specifies groups to which each data point belongs. If this parameter is specified, the data points will be grouped by these values, and multiple series will be produced for each group.

```yaml
Type: System.Object[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 16
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupName

Specifies the property name of the input object to be treated as groups.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -High

Specifies the sequence of the element High of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HighName

Specifies the property name of the input object to be processed as the element High of the data point.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject

Specifies a dataset that represents the data points of the series.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsVisible

Sets a value indicating whether this series is visible. The default is true.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 45
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Items

Sets the items of the series.
 


```yaml
Type: System.Collections.Generic.List`1[OxyPlot.Series.OhlcvItem]
Parameter Sets: (All)
Aliases:

Required: False
Position: 27
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ItemsSource

Sets the items source. The default is null.
 


```yaml
Type: System.Collections.IEnumerable
Parameter Sets: (All)
Aliases:

Required: False
Position: 43
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Low

Specifies the sequence of the element Low of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 12
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LowName

Specifies the property name of the input object to be processed as the element Low of the data point.

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

### -NegativeColor

Sets the fill color used when the closing value is less than opening value or
 for selling volume
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 36
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NegativeHollow

Sets a value indicating whether negative bars are shown as filled (false) or hollow (true) candlesticks
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 39
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Open

Specifies the sequence of the element Open of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OpenName

Specifies the property name of the input object to be processed as the element Open of the data point.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
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
Position: 18
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
Position: 20
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
Position: 19
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
Position: 22
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PositiveColor

Sets the color used when the closing value is greater than opening value or
 for buying volume.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 35
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PositiveHollow

Sets a value indicating whether positive bars are shown as filled (false) or hollow (true) candlesticks
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 38
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RenderInLegend

Sets a value indicating whether the series should be rendered in the legend. The default is true.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 47
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
Position: 26
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Selectable

Sets a value indicating whether this element can be selected. The default is true.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Bool
Parameter Sets: (All)
Aliases:

Required: False
Position: 56
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelectionMode

Sets the selection mode of items in this element. The default is SelectionMode.All.
 
This is only used by the select/unselect functionality, not by the rendering.


```yaml
Type: OxyPlot.SelectionMode
Parameter Sets: (All)
Aliases:
Accepted values: All, Single, Multiple

Required: False
Position: 57
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SellVolume

Specifies the sequence of the element SellVolume of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 15
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SellVolumeName

Specifies the property name of the input object to be processed as the element SellVolume of the data point.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SeparatorColor

Sets the color of the separator line
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 37
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SeparatorLineStyle

Sets the line style for the volume / bar separator
 


```yaml
Type: OxyPlot.LineStyle
Parameter Sets: (All)
Aliases:
Accepted values: Solid, Dash, Dot, DashDot, DashDashDot, DashDotDot, DashDashDotDot, LongDash, LongDashDot, LongDashDotDot, None, Automatic

Required: False
Position: 34
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SeparatorStrokeThickness

Sets the thickness of the volume / bar separator
 


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

### -Show

Shows the chart in the GUI window.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 25
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -StrokeIntensity

Sets the stroke intensity scale (used to generate stroke color from positive or negative color).
 For example, 1.0 = same color and 0.5 is 1/2 of the intensity of the source fill color.
 


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

### -StrokeThickness

Sets the thickness of the bar lines
 


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

### -Style

Specifies the style.

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

### -SvgIsDocument

Indicates that a SVG file should be generated as a complete document. Use with the -OutFile parameter.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 21
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag

Sets an arbitrary object value that can be used to store custom information about this plot element. The default is null.
 
This property is analogous to Tag properties in other Microsoft programming models. Tag is intended to provide a pre-existing property location where you can store some basic custom information about any PlotElement without requiring you to subclass an element.


```yaml
Type: System.Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 53
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextColor

Sets the color of the text. The default is OxyColors.Automatic (use OxyPlot.PlotModel.TextColor).
 
If the value is OxyColors.Automatic, the TextColor of the parent PlotModel will be used.


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor
Parameter Sets: (All)
Aliases:

Required: False
Position: 54
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title

Sets the title of the series. The default is null.
 


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 46
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToolTip

Sets the tool tip. The default is null.
 


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

### -TrackerFormatString

Sets a format string used for the tracker. The default depends on the series.
 
The arguments for the format string may be different for each type of series. See the documentation.
 


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 48
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TrackerKey

Sets the key for the tracker to use on this series. The default is null.
 
This key may be used by the plot view to show a custom tracker for the series.
 


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 49
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VolumeAxisKey

Sets the volume axis key (defaults to "Volume")
 


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 28
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VolumeStyle

Sets the style of volume rendering (defaults to Combined)
 


```yaml
Type: OxyPlot.Series.VolumeStyle
Parameter Sets: (All)
Aliases:
Accepted values: None, Combined, Stacked, PositiveNegative

Required: False
Position: 30
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -X

Specifies the sequence of the element X of the data point.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -XAxisKey

Sets the x-axis key. The default is null.
 


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

### -XName

Specifies the property name of the input object to be processed as the element X of the data point.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YAxisKey

Sets the y-axis key. The default is null.
 


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 42
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
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Management.Automation.PSObject
## OUTPUTS

### Horker.OxyPlotCli.SeriesInfo`1[[OxyPlot.Series.CandleStickAndVolumeSeries, OxyPlot, Version=2.0.0.0, Culture=neutral, PublicKeyToken=638079a8f0bd61e9]]
## NOTES

## RELATED LINKS

[http://www.mathworks.com/help/toolbox/finance/highlowfts.html](http://www.mathworks.com/help/toolbox/finance/highlowfts.html)

