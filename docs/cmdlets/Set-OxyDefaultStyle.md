---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Set-OxyDefaultStyle.md https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Set-OxyDefaultStyle.md https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Set-OxyDefaultStyle.md
schema: 2.0.0
---

# Set-OxyDefaultStyle

## SYNOPSIS
Sets the default style.

## SYNTAX

```
Set-OxyDefaultStyle [-Style] <Style> [[-ColorScheme] <String>] [[-DefaultFont] <String>] [<CommonParameters>]
```

## DESCRIPTION
Sets the default style.

## EXAMPLES

## PARAMETERS

### -ColorScheme
Specifies the color scheme to overwrite the preset definition of the style.

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

### -DefaultFont
Specifies the default font to overwrite the preset definition of the style.

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

### -Style
Specifies the style name or the style object.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.Style
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
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
