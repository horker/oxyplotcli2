---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Add-OxyAxisShare.md https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Add-OxyAxisShare.md https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Add-OxyAxisShare.md
schema: 2.0.0
---

# Add-OxyAxisShare

## SYNOPSIS

Binds two axes to share a common visible range.

## SYNTAX

```
Add-OxyAxisShare [-Axis] <Axis[]> [[-Multiplier] <Double[]>] [[-Offset] <Double[]>] [<CommonParameters>]
```

## DESCRIPTION

Binds two axes to share a common visible range.

Once axes are bound by this cmdlet, when the user scrolls one of such axes, the other one automatically moves in a synchronized manner.

This cmdlet makes sense when the chart is displayed in the GUI window.

## EXAMPLES

## PARAMETERS

### -Axis
Specifies the axes to be bound.

```yaml
Type: OxyPlot.Axes.Axis[]
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Multiplier
Specifies the relative amounts of movement per axis.

This parameter should be a numeric array and have the same length as the -Axis parameter.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Offset
Specifies the offsets of each axis.

This parameter should be a numeric array and have the same length as the -Axis parameter.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Double[]
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS
