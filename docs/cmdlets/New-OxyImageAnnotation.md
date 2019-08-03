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

Returns an object that represents an annotation that shows an image.
 


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

### -Height



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

### -VerticalAlignment



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


