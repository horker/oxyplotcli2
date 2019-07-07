---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: http://www.mathworks.com/help/toolbox/finance/highlowfts.html
schema: 2.0.0
---

# New-OxyLinearAxis

## SYNOPSIS
Returns an object that   Represents an axis with linear scale.

## SYNTAX

```
New-OxyLinearAxis [-FormatAsFractions <Bool>] [-FractionUnit <Double>] [-FractionUnitSymbol <String>]
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
Returns an OxyPlot.Axes.LinearAxis object that   Represents an axis with linear scale.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -AbsoluteMaximum
Sets the absolute maximum.
This is only used for the UI control.
It will not be possible to zoom/pan beyond this limit.
The default value is double.MaxValue.

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
Sets the absolute minimum.
This is only used for the UI control.
It will not be possible to zoom/pan beyond this limit.
The default value is double.MinValue.

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
Specifies the PlotModel to which the object is added.

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
Sets the orientation angle (degrees) for the axis labels.
The default value is 0.

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
Sets the distance between the plot area and the axis.
The default value is 0.

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
Sets the distance from the end of the tick lines to the labels.
The default value is 4.

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
Sets the minimum distance from the axis labels to the axis title.
The default value is 4.

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
Sets the color of the axis line.
The default value is OxyPlot.OxyColors.Black.

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
Sets the line style of the axis line.
The default value is OxyPlot.LineStyle.None.

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
Sets the thickness of the axis line.
The default value is 1.

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

### -ClipTitle
Sets a value indicating whether to clip the axis title.
The default value is true.

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
Sets a value indicating whether to crop gridlines with perpendicular axes Start/EndPositions.
The default value is false.

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
Sets the end position of the axis on the plot area.
The default value is 1.

The position is defined by a fraction in the range from 0 to 1, where 0 is at the bottom/left  and 1 is at the top/right.

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
Sets the color of the extra gridlines.
The default value is OxyPlot.OxyColors.Black.

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
Sets the line style of the extra gridlines.
The default value is OxyPlot.LineStyle.Solid.

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
Sets the thickness of the extra gridlines.
The default value is 1.

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
Sets the values for the extra gridlines.
The default value is null.

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
Sets the filter function.
The default value is null.

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
Sets the maximum value that can be shown using this axis.
Values greater or equal to this value will not be shown.
The default value is double.MaxValue.

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
Sets the minimum value that can be shown using this axis.
Values smaller or equal to this value will not be shown.
The default value is double.MinValue.

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

### -Font
Sets the font.
The default is null (use OxyPlot.PlotModel.DefaultFont.

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
Sets the size of the font.
The default is double.NaN (use OxyPlot.PlotModel.DefaultFontSize).

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
Sets the font weight.
The default is FontWeights.Normal.

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
Sets a value indicating whether to format numbers as fractions.

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
Sets the fraction unit.
Remember to set FormatAsFractions to true.

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
Sets the fraction unit symbol.
Use FractionUnit = Math.PI and FractionUnitSymbol = "ﾏ" if you want the axis to show "ﾏ/2,ﾏ,3ﾏ/2,2ﾏ" etc.
Use FractionUnit = 1 and FractionUnitSymbol = "L" if you want the axis to show "0,L/2,L" etc.
Remember to set FormatAsFractions to true.

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
Sets the maximum length (screen space) of the intervals.
The available length of the axis will be divided by this length to get the approximate number of major intervals on the axis.
The default value is 60.

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

### -IsAxisVisible
Sets a value indicating whether this axis is visible.
The default value is true.

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
Sets a value indicating whether panning is enabled.
The default value is true.

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
Sets a value indicating whether zooming is enabled.
The default value is true.

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
Sets the key of the axis.
This can be used to specify an axis if you have defined multiple axes in a plot.
The default value is null.

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
Sets the formatting function for the labels.
The default value is null.

This function can be used instead of overriding the OxyPlot.Axes.Axis.FormatValue(System.Double) method.

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
Sets the layer of the axis.
The default value is OxyPlot.Axes.AxisLayer.BelowSeries.

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
Sets the color of the major gridlines.
The default value is #40000000.

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
Sets the line style of the major gridlines.
The default value is OxyPlot.LineStyle.None.

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
Sets the thickness of the major gridlines.
The default value is 1.

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
Sets the interval between major ticks.
The default value is double.NaN.

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
Sets the size of the major ticks.
The default value is 7.

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
Sets the maximum value of the axis.
The default value is double.NaN.

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
Sets the 'padding' fraction of the maximum value.
The default value is 0.01.

A value of 0.01 gives 1% more space on the maximum end of the axis.
This property is not used if the OxyPlot.Axes.Axis.Maximum property is set.

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
Sets the maximum range of the axis.
Setting this property ensures that ActualMaximum-ActualMinimum \< MaximumRange.
The default value is double.PositiveInfinity.

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
Sets the minimum value of the axis.
The default value is double.NaN.

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
Sets the minimum value for the interval between major ticks.
The default value is 0.

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
Sets the minimum value for the interval between minor ticks.
The default value is 0.

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
Sets the 'padding' fraction of the minimum value.
The default value is 0.01.

A value of 0.01 gives 1% more space on the minimum end of the axis.
This property is not used if the OxyPlot.Axes.Axis.Minimum property is set.

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
Sets the minimum range of the axis.
Setting this property ensures that ActualMaximum-ActualMinimum \> MinimumRange.
The default value is 0.

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
Sets the color of the minor gridlines.
The default value is #20000000.

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
Sets the line style of the minor gridlines.
The default value is OxyPlot.LineStyle.None.

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
Sets the thickness of the minor gridlines.
The default value is 1.

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

### -MinorStep
Sets the interval between minor ticks.
The default value is double.NaN.

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
Sets the size of the minor ticks.
The default value is 4.

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
Sets the color of the minor ticks.
The default value is OxyPlot.OxyColors.Automatic.

If the value is OxyPlot.OxyColors.Automatic, the value of  OxyPlot.Axes.Axis.TicklineColor will be used.

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
Returns an output object even when the -AddTo parameter is specified.

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

### -Position
Sets the position of the axis.
The default value is OxyPlot.Axes.AxisPosition.Left.

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
Sets a value indicating whether the axis should be positioned at the zero-crossing of the related axis.
The default value is false.

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
Sets the position tier which defines in which tier the axis is displayed.
The default value is 0.

The bigger the value the further afar is the axis from the graph.

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
Sets a value indicating whether this element can be selected.
The default is true.

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
Sets the selection mode of items in this element.
The default is SelectionMode.All.

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

### -StartPosition
Sets the start position of the axis on the plot area.
The default value is 0.

The position is defined by a fraction in the range from 0 to 1, where 0 is at the bottom/left  and 1 is at the top/right.

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
Sets the string format used for formatting the axis values.
The default value is null.

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
Sets an arbitrary object value that can be used to store custom information about this plot element.
The default is null.

This property is analogous to Tag properties in other Microsoft programming models.
Tag is intended to provide a pre-existing property location where you can store some basic custom information about any PlotElement without requiring you to subclass an element.

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
Sets the color of the text.
The default is OxyColors.Automatic (use OxyPlot.PlotModel.TextColor).

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

### -TickStyle
Sets the tick style for major and minor ticks.
The default value is OxyPlot.Axes.TickStyle.Outside.

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
Sets the color of the major and minor ticks.
The default value is OxyPlot.OxyColors.Black.

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
Sets the title of the axis.
The default value is null.

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
Sets the length of the title clipping rectangle (fraction of the available length of the axis).
The default value is 0.9.

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
Sets the color of the title.
The default value is OxyPlot.OxyColors.Automatic.

If the value is null, the OxyPlot.PlotModel.TextColor will be used.

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
Sets the title font.
The default value is null.

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
Sets the size of the title font.
The default value is double.NaN.

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
Sets the weight of the title font.
The default value is OxyPlot.FontWeights.Normal.

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
Sets the format string used for formatting the title and unit when OxyPlot.Axes.Axis.Unit is defined. 
The default value is "{0} \[{1}\]", where {0} refers to the OxyPlot.Axes.Axis.Title and {1} refers to the OxyPlot.Axes.Axis.Unit.

If OxyPlot.Axes.Axis.Unit is null, the actual title is defined by OxyPlot.Axes.Axis.Title only.

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
Sets the position of the title.
The default value is 0.5.

The position is defined by a fraction in the range 0 to 1.

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
Sets the tool tip.
The default is null.

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
Sets the unit of the axis.
The default value is null.

The OxyPlot.Axes.Axis.TitleFormatString is used to format the title including this unit.

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
Sets a value indicating whether to use superscript exponential format.
The default value is false.

This format will convert 1.5E+03 to 1.5ﾂｷ10^{3} and render the superscript properly. 
If OxyPlot.Axes.Axis.StringFormat is null, 1.0E+03 will be converted to 10^{3}, otherwise it will use the format string for the mantissa.

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

### OxyPlot.Axes.LinearAxis
## NOTES

## RELATED LINKS
