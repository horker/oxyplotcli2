---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: http://en.wikipedia.org/wiki/Contour_line
schema: 2.0.0
---

# New-OxyGridView

## SYNOPSIS
Returns a GridView object.

## SYNTAX

```
New-OxyGridView [[-Models] <Object[]>] [[-Widths] <Double[]>] [[-Heights] <Double[]>] [[-ColumnCount] <Int32>]
 [[-RowCount] <Int32>] [[-OutFile] <String>] [[-OutWidth] <Int32>] [[-OutHeight] <Int32>] [-SvgIsDocument]
 [-PassThru] [[-Style] <String>] [-Show] [-ReuseWindow] [<CommonParameters>]
```

## DESCRIPTION
Returns a GridView object.

The GridView object is a grid style container of multiple OxyPlot models.

## PARAMETERS

### -ColumnCount
The number of columns of the grid.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Heights
The relative height of each row of the grid.

```yaml
Type: System.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Models
Specifies PlotModel objects contained in the grid.

```yaml
Type: System.Object[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutFile
Specifies the output file name. The output format is determined based on the file extension, which should be either `".png`" or `".svg`".

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

### -OutHeight
Specifies the height of the output image. Use with the -OutFile parameter.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
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
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns an output object even when the -OutFile parameter is specified.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 9
Default value: False
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

### -RowCount
Specifies the number of the rows of the grid.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
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
Position: 10
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
Position: 8
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Widths
The relative width of each row of the grid.

```yaml
Type: System.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### Horker.OxyPlotCli.GridView
## NOTES

## RELATED LINKS
