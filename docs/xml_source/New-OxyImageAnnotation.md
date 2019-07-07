---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: http://www.mathworks.com/help/toolbox/finance/highlowfts.html
schema: 2.0.0
---

# New-OxyImageAnnotation

## SYNOPSIS

Returns an object that represents an annotation that shows an image.
 


## SYNTAX

```
New-OxyImageAnnotation [-ImageSource <OxyImage>] [-HorizontalAlignment <HorizontalAlignment>] [-X <PlotLength>]
 [-Y <PlotLength>] [-OffsetX <PlotLength>] [-OffsetY <PlotLength>] [-Width <PlotLength>] [-Height <PlotLength>]
 [-Opacity <Double>] [-Interpolate <Bool>] [-VerticalAlignment <VerticalAlignment>] [-Layer <AnnotationLayer>]
 [-XAxisKey <String>] [-YAxisKey <String>] [-Font <String>] [-FontSize <Double>] [-FontWeight <Double>]
 [-Tag <Object>] [-TextColor <OxyColor>] [-ToolTip <String>] [-Selectable <Bool>]
 [-SelectionMode <SelectionMode>] [-AddTo <PlotModel>] [-PassThru] [-Style <String>] [<CommonParameters>]
```

## DESCRIPTION

Returns an OxyPlot.Annotations.ImageAnnotation object that represents an annotation that shows an image.
 


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

### -Height

Sets the height.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.PlotLength
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HorizontalAlignment

Sets the horizontal alignment.
 


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

### -ImageSource

Sets the image source.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyImage
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Interpolate

Sets a value indicating whether to apply smooth interpolation to the image.
 


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

### -Layer

Sets the rendering layer of the annotation. The default value is OxyPlot.Annotations.AnnotationLayer.AboveSeries.
 


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

### -OffsetX

Sets the X offset.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.PlotLength
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OffsetY

Sets the Y offset.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.PlotLength
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Opacity

Sets the opacity (0-1).
 


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

### -VerticalAlignment

Sets the vertical alignment.
 


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

### -Width

Sets the width.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.PlotLength
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -X

Sets the X position of the image.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.PlotLength
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

### -Y

Sets the Y position of the image.
 


```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.PlotLength
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

### OxyPlot.Annotations.ImageAnnotation
## NOTES

## RELATED LINKS


