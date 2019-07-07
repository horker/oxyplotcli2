---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: http://en.wikipedia.org/wiki/Pie_chart
schema: 2.0.0
---

# New-OxyPolygonAnnotation

## SYNOPSIS
Returns an object that   Represents an annotation that shows a polygon.

## SYNTAX

```
New-OxyPolygonAnnotation [-LineJoin <LineJoin>] [-LineStyle <LineStyle>] [-Fill <OxyColor>]
 [-Stroke <OxyColor>] [-StrokeThickness <Double>] [-Text <String>] [-TextPosition <Double[]>]
 [-TextHorizontalAlignment <HorizontalAlignment>] [-TextVerticalAlignment <VerticalAlignment>]
 [-TextRotation <Double>] [-Layer <AnnotationLayer>] [-XAxisKey <String>] [-YAxisKey <String>] [-Font <String>]
 [-FontSize <Double>] [-FontWeight <Double>] [-Tag <Object>] [-TextColor <OxyColor>] [-ToolTip <String>]
 [-Selectable <Bool>] [-SelectionMode <SelectionMode>] [-AddTo <PlotModel>] [-PassThru] [-Style <String>]
 [<CommonParameters>]
```

## DESCRIPTION
Returns an OxyPlot.Annotations.PolygonAnnotation object that   Represents an annotation that shows a polygon.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

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

### -Fill
Sets the fill color.

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

### -Layer
Sets the rendering layer of the annotation.
The default value is OxyPlot.Annotations.AnnotationLayer.AboveSeries.

```yaml
Type: OxyPlot.Annotations.AnnotationLayer
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LineJoin
Sets the line join.

```yaml
Type: OxyPlot.LineJoin
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LineStyle
Sets the line style.

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

### -Stroke
Sets the stroke color.

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

### -StrokeThickness
Sets the stroke thickness.

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

### -Text
Sets the annotation text.

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

### -TextHorizontalAlignment
Sets the horizontal alignment of the text.

```yaml
Type: OxyPlot.HorizontalAlignment
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextPosition
Sets the position of the text.

If the value is DataPoint.Undefined, the default position of the text will be used.

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

### -TextRotation
Sets the rotation of the text.

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

### -TextVerticalAlignment
Sets the vertical alignment of the text.

```yaml
Type: OxyPlot.VerticalAlignment
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

### -XAxisKey
Sets the X axis key.

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

### -YAxisKey
Sets the Y axis key.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### OxyPlot.Annotations.PolygonAnnotation
## NOTES

## RELATED LINKS
