﻿---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/New-OxyScatterErrorSeries.md
schema: 2.0.0
---

# New-OxyScatterErrorSeries

## SYNOPSIS

Returns an object that represents a series for scatter plots with the possibility to display error bars.
 


## SYNTAX

```
New-OxyScatterErrorSeries [-InputObject <PSObject>] [-XName <String>] [-YName <String>] [-ErrorXName <String>]
 [-ErrorYName <String>] [-SizeName <String>] [-ValueName <String>] [-GroupName <String>] [-X <Double[]>]
 [-Y <Double[]>] [-ErrorX <Double[]>] [-ErrorY <Double[]>] [-Size <Double[]>] [-Value <Double[]>]
 [-Group <Object[]>] [-AddTo <PlotModel>] [-OutFile <String>] [-OutWidth <Int32>] [-OutHeight <Int32>]
 [-SvgIsDocument] [-PassThru] [-Style <String>] [-AsPlotView] [-Show] [-ReuseWindow]
 [-DataFieldErrorX <String>] [-DataFieldErrorY <String>] [-ErrorBarColor <OxyColor>]
 [-ErrorBarStopWidth <Double>] [-ErrorBarStrokeThickness <Double>] [-MinimumErrorSize <Double>]
 [-LabelFormatString <String>] [-LabelMargin <Double>]
 [-Mapping <System.Func`2[System.Object,OxyPlot.Series.ScatterErrorPoint]>] [-BinSize <Int32>]
 [-ColorAxisKey <String>] [-DataFieldX <String>] [-DataFieldY <String>] [-DataFieldSize <String>]
 [-DataFieldTag <String>] [-DataFieldValue <String>] [-MarkerFill <OxyColor>] [-MarkerOutline <Double[]>]
 [-MarkerSize <Double>] [-MarkerStroke <OxyColor>] [-MarkerStrokeThickness <Double>] [-MarkerType <MarkerType>]
 [-XAxisKey <String>] [-YAxisKey <String>] [-ItemsSource <IEnumerable>] [-Background <OxyColor>]
 [-IsVisible <Bool>] [-Title <String>] [-RenderInLegend <Bool>] [-TrackerFormatString <String>]
 [-TrackerKey <String>] [-Font <String>] [-FontSize <Double>] [-FontWeight <Double>] [-Tag <Object>]
 [-TextColor <OxyColor>] [-ToolTip <String>] [-Selectable <Bool>] [-SelectionMode <SelectionMode>]
 [-AxType <String>] [-AxStartAngle <Double>] [-AxEndAngle <Double>] [-AxFormatAsFractions <Bool>]
 [-AxFractionUnit <Double>] [-AxFractionUnitSymbol <String>] [-AxAbsoluteMaximum <Double>]
 [-AxAbsoluteMinimum <Double>] [-AxAngle <Double>] [-AxAxisTickToLabelDistance <Double>]
 [-AxAxisTitleDistance <Double>] [-AxAxisDistance <Double>] [-AxAxislineColor <OxyColor>]
 [-AxAxislineStyle <LineStyle>] [-AxAxislineThickness <Double>] [-AxClipTitle <Bool>] [-AxCropGridlines <Bool>]
 [-AxEndPosition <Double>] [-AxExtraGridlineColor <OxyColor>] [-AxExtraGridlineStyle <LineStyle>]
 [-AxExtraGridlineThickness <Double>] [-AxExtraGridlines <Double[]>]
 [-AxFilterFunction <System.Func`2[System.Double,System.Boolean]>] [-AxFilterMaxValue <Double>]
 [-AxFilterMinValue <Double>] [-AxIntervalLength <Double>] [-AxIsAxisVisible <Bool>] [-AxIsPanEnabled <Bool>]
 [-AxIsZoomEnabled <Bool>] [-AxKey <String>] [-AxLabelFormatter <System.Func`2[System.Double,System.String]>]
 [-AxLayer <AxisLayer>] [-AxMajorGridlineColor <OxyColor>] [-AxMajorGridlineStyle <LineStyle>]
 [-AxMajorGridlineThickness <Double>] [-AxMajorStep <Double>] [-AxMajorTickSize <Double>] [-AxMaximum <Double>]
 [-AxMaximumPadding <Double>] [-AxMaximumRange <Double>] [-AxMinimum <Double>] [-AxMinimumMajorStep <Double>]
 [-AxMinimumMinorStep <Double>] [-AxMinimumPadding <Double>] [-AxMinimumRange <Double>]
 [-AxMinorGridlineColor <OxyColor>] [-AxMinorGridlineStyle <LineStyle>] [-AxMinorGridlineThickness <Double>]
 [-AxMinorStep <Double>] [-AxMinorTicklineColor <OxyColor>] [-AxMinorTickSize <Double>]
 [-AxPosition <AxisPosition>] [-AxPositionAtZeroCrossing <Bool>] [-AxPositionTier <Int32>]
 [-AxStartPosition <Double>] [-AxStringFormat <String>] [-AxTickStyle <TickStyle>]
 [-AxTicklineColor <OxyColor>] [-AxTitle <String>] [-AxTitleClippingLength <Double>] [-AxTitleColor <OxyColor>]
 [-AxTitleFont <String>] [-AxTitleFontSize <Double>] [-AxTitleFontWeight <Double>]
 [-AxTitleFormatString <String>] [-AxTitlePosition <Double>] [-AxUnit <String>]
 [-AxUseSuperExponentialFormat <Bool>] [-AxFont <String>] [-AxFontSize <Double>] [-AxFontWeight <Double>]
 [-AxTag <Object>] [-AxTextColor <OxyColor>] [-AxToolTip <String>] [-AxSelectable <Bool>]
 [-AxSelectionMode <SelectionMode>] [-AxGapWidth <Double>] [-AxIsTickCentered <Bool>]
 [-AxItemsSource <IEnumerable>] [-AxLabelField <String>] [-AxInvalidCategoryColor <OxyColor>]
 [-AxPalette <OxyPaletteItem[]>] [-AxCalendarWeekRule <CalendarWeekRule>] [-AxFirstDayOfWeek <DayOfWeek>]
 [-AxIntervalType <DateTimeIntervalType>] [-AxMinorIntervalType <DateTimeIntervalType>]
 [-AxTimeZone <TimeZoneInfo>] [-AxInvalidNumberColor <OxyColor>] [-AxHighColor <OxyColor>]
 [-AxLowColor <OxyColor>] [-AxRenderAsImage <Bool>] [-AxBase <Double>] [-AxPowerPadding <Bool>]
 [-AyType <String>] [-AyStartAngle <Double>] [-AyEndAngle <Double>] [-AyFormatAsFractions <Bool>]
 [-AyFractionUnit <Double>] [-AyFractionUnitSymbol <String>] [-AyAbsoluteMaximum <Double>]
 [-AyAbsoluteMinimum <Double>] [-AyAngle <Double>] [-AyAxisTickToLabelDistance <Double>]
 [-AyAxisTitleDistance <Double>] [-AyAxisDistance <Double>] [-AyAxislineColor <OxyColor>]
 [-AyAxislineStyle <LineStyle>] [-AyAxislineThickness <Double>] [-AyClipTitle <Bool>] [-AyCropGridlines <Bool>]
 [-AyEndPosition <Double>] [-AyExtraGridlineColor <OxyColor>] [-AyExtraGridlineStyle <LineStyle>]
 [-AyExtraGridlineThickness <Double>] [-AyExtraGridlines <Double[]>]
 [-AyFilterFunction <System.Func`2[System.Double,System.Boolean]>] [-AyFilterMaxValue <Double>]
 [-AyFilterMinValue <Double>] [-AyIntervalLength <Double>] [-AyIsAxisVisible <Bool>] [-AyIsPanEnabled <Bool>]
 [-AyIsZoomEnabled <Bool>] [-AyKey <String>] [-AyLabelFormatter <System.Func`2[System.Double,System.String]>]
 [-AyLayer <AxisLayer>] [-AyMajorGridlineColor <OxyColor>] [-AyMajorGridlineStyle <LineStyle>]
 [-AyMajorGridlineThickness <Double>] [-AyMajorStep <Double>] [-AyMajorTickSize <Double>] [-AyMaximum <Double>]
 [-AyMaximumPadding <Double>] [-AyMaximumRange <Double>] [-AyMinimum <Double>] [-AyMinimumMajorStep <Double>]
 [-AyMinimumMinorStep <Double>] [-AyMinimumPadding <Double>] [-AyMinimumRange <Double>]
 [-AyMinorGridlineColor <OxyColor>] [-AyMinorGridlineStyle <LineStyle>] [-AyMinorGridlineThickness <Double>]
 [-AyMinorStep <Double>] [-AyMinorTicklineColor <OxyColor>] [-AyMinorTickSize <Double>]
 [-AyPosition <AxisPosition>] [-AyPositionAtZeroCrossing <Bool>] [-AyPositionTier <Int32>]
 [-AyStartPosition <Double>] [-AyStringFormat <String>] [-AyTickStyle <TickStyle>]
 [-AyTicklineColor <OxyColor>] [-AyTitle <String>] [-AyTitleClippingLength <Double>] [-AyTitleColor <OxyColor>]
 [-AyTitleFont <String>] [-AyTitleFontSize <Double>] [-AyTitleFontWeight <Double>]
 [-AyTitleFormatString <String>] [-AyTitlePosition <Double>] [-AyUnit <String>]
 [-AyUseSuperExponentialFormat <Bool>] [-AyFont <String>] [-AyFontSize <Double>] [-AyFontWeight <Double>]
 [-AyTag <Object>] [-AyTextColor <OxyColor>] [-AyToolTip <String>] [-AySelectable <Bool>]
 [-AySelectionMode <SelectionMode>] [-AyGapWidth <Double>] [-AyIsTickCentered <Bool>]
 [-AyItemsSource <IEnumerable>] [-AyLabelField <String>] [-AyInvalidCategoryColor <OxyColor>]
 [-AyPalette <OxyPaletteItem[]>] [-AyCalendarWeekRule <CalendarWeekRule>] [-AyFirstDayOfWeek <DayOfWeek>]
 [-AyIntervalType <DateTimeIntervalType>] [-AyMinorIntervalType <DateTimeIntervalType>]
 [-AyTimeZone <TimeZoneInfo>] [-AyInvalidNumberColor <OxyColor>] [-AyHighColor <OxyColor>]
 [-AyLowColor <OxyColor>] [-AyRenderAsImage <Bool>] [-AyBase <Double>] [-AyPowerPadding <Bool>]
 [<CommonParameters>]
```

## DESCRIPTION

Returns an object that represents a series for scatter plots with the possibility to display error bars.
 


## PARAMETERS

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

### -AxAbsoluteMaximum

Specifies the AbsoluteMaximum parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAbsoluteMinimum

Specifies the AbsoluteMinimum parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAngle

Specifies the Angle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAxisDistance

Specifies the AxisDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAxisTickToLabelDistance

Specifies the AxisTickToLabelDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAxisTitleDistance

Specifies the AxisTitleDistance parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAxislineColor

Specifies the AxislineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAxislineStyle

Specifies the AxislineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxAxislineThickness

Specifies the AxislineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxBase

Specifies the Base parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxCalendarWeekRule

Specifies the CalendarWeekRule parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxClipTitle

Specifies the ClipTitle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxCropGridlines

Specifies the CropGridlines parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxEndAngle

Specifies the EndAngle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxEndPosition

Specifies the EndPosition parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxExtraGridlineColor

Specifies the ExtraGridlineColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxExtraGridlineStyle

Specifies the ExtraGridlineStyle parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxExtraGridlineThickness

Specifies the ExtraGridlineThickness parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxExtraGridlines

Specifies the ExtraGridlines parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFilterFunction

Specifies the FilterFunction parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFilterMaxValue

Specifies the FilterMaxValue parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFilterMinValue

Specifies the FilterMinValue parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFirstDayOfWeek

Specifies the FirstDayOfWeek parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFont

Specifies the Font parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFontSize

Specifies the FontSize parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFontWeight

Specifies the FontWeight parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFormatAsFractions

Specifies the FormatAsFractions parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFractionUnit

Specifies the FractionUnit parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxFractionUnitSymbol

Specifies the FractionUnitSymbol parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxGapWidth

Specifies the GapWidth parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxHighColor

Specifies the HighColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxIntervalLength

Specifies the IntervalLength parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxIntervalType

Specifies the IntervalType parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxInvalidCategoryColor

Specifies the InvalidCategoryColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxInvalidNumberColor

Specifies the InvalidNumberColor parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxIsAxisVisible

Specifies the IsAxisVisible parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxIsPanEnabled

Specifies the IsPanEnabled parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxIsTickCentered

Specifies the IsTickCentered parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxIsZoomEnabled

Specifies the IsZoomEnabled parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

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

### -AxItemsSource

Specifies the ItemsSource parameter of the x-axis. For more details, refer to the help topic of the axis of interest.

```yaml
Type: System.Collections.IEnumerable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BinSize



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

### -ColorAxisKey



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

### -DataFieldErrorX

Sets the data field for the X error property.
 


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

### -DataFieldErrorY

Sets the data field for the Y error property.
 


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

### -DataFieldSize



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

### -DataFieldTag



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

### -DataFieldValue



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

### -DataFieldX



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

### -DataFieldY



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

### -ErrorBarColor

Sets the color of the error bar.
 


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

### -ErrorBarStopWidth

Sets the width of the error bar stop.
 


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

### -ErrorBarStrokeThickness

Sets the error bar stroke thickness.
 


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

### -ErrorX

Specifies the sequence of the element ErrorX of the data point.

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

### -ErrorXName

Specifies the property name of the input object to be processed as the element ErrorX of the data point.

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

### -ErrorY

Specifies the sequence of the element ErrorY of the data point.

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

### -ErrorYName

Specifies the property name of the input object to be processed as the element ErrorY of the data point.

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

### -Font

Sets the font. The default is null (use OxyPlot.PlotModel.DefaultFont.
 
If the value is null, the DefaultFont of the parent PlotModel will be used.


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

Sets the size of the font. The default is double.NaN (use OxyPlot.PlotModel.DefaultFontSize).
 
If the value is NaN, the DefaultFontSize of the parent PlotModel will be used.


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

Sets the font weight. The default is FontWeights.Normal.
 


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

### -Group

Specifies groups to which each data point belongs. If this parameter is specified, the data points will be grouped by these values, and multiple series will be produced for each group.

```yaml
Type: System.Object[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
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
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelFormatString



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

### -LabelMargin



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

### -Mapping



```yaml
Type: System.Func`2[System.Object,OxyPlot.Series.ScatterErrorPoint]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MarkerFill



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

### -MarkerOutline



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

### -MarkerSize



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

### -MarkerStroke



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

### -MarkerStrokeThickness



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

### -MarkerType



```yaml
Type: OxyPlot.MarkerType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumErrorSize

Sets the minimum size (relative to OxyPlot.Series.ScatterSeries`1.MarkerSize) of the error bars to be shown.
 


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

### -OutFile

Specifies the output file name. The output format is determined based on the file extension, which should be either ".png" or ".svg".

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

### -OutHeight

Specifies the height of the output image. Use with the -OutFile parameter.

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

### -OutWidth

Specifies the width of the output image. Use with the -OutFile parameter.

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

### -RenderInLegend

Sets a value indicating whether the series should be rendered in the legend. The default is true.
 


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

### -ReuseWindow

Indicates to reuse the most recently used window to show the chart instead of creating a new one. Use with the -Show parameter.

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

### -Selectable

Sets a value indicating whether this element can be selected. The default is true.
 


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

Sets the selection mode of items in this element. The default is SelectionMode.All.
 
This is only used by the select/unselect functionality, not by the rendering.


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

### -Show

Shows the chart in the GUI window.

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

### -Size

Specifies the sequence of the element Size of the data point.

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

### -SizeName

Specifies the property name of the input object to be processed as the element Size of the data point.

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

### -SvgIsDocument

Indicates that a SVG file should be generated as a complete document. Use with the -OutFile parameter.

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

### -Tag

Sets an arbitrary object value that can be used to store custom information about this plot element. The default is null.
 
This property is analogous to Tag properties in other Microsoft programming models. Tag is intended to provide a pre-existing property location where you can store some basic custom information about any PlotElement without requiring you to subclass an element.


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

Sets the color of the text. The default is OxyColors.Automatic (use OxyPlot.PlotModel.TextColor).
 
If the value is OxyColors.Automatic, the TextColor of the parent PlotModel will be used.


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

### -Title

Sets the title of the series. The default is null.
 


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

### -ToolTip

Sets the tool tip. The default is null.
 


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

### -TrackerFormatString

Sets a format string used for the tracker. The default depends on the series.
 
The arguments for the format string may be different for each type of series. See the documentation.
 


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

### -TrackerKey

Sets the key for the tracker to use on this series. The default is null.
 
This key may be used by the plot view to show a custom tracker for the series.
 


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

### -Value

Specifies the sequence of the element Value of the data point.

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

### -ValueName

Specifies the property name of the input object to be processed as the element Value of the data point.

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

### -X

Specifies the sequence of the element X of the data point.

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

### -XAxisKey

Sets the x-axis key. The default is null.
 


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

### -XName

Specifies the property name of the input object to be processed as the element X of the data point.

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

### -Y

Specifies the sequence of the element Y of the data point.

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

### -YAxisKey

Sets the y-axis key. The default is null.
 


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

### -YName

Specifies the property name of the input object to be processed as the element Y of the data point.

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

### Horker.OxyPlotCli.SeriesInfo`1[[OxyPlot.Series.ScatterErrorSeries, OxyPlot, Version=2.0.0.0, Culture=neutral, PublicKeyToken=638079a8f0bd61e9]]
## NOTES

## RELATED LINKS


