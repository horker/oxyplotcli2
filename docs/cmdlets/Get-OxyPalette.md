---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/Get-OxyPalette.md
schema: 2.0.0
---

# Get-OxyPalette

## SYNOPSIS
Gets a color palette object.

## SYNTAX

### Preset
```
Get-OxyPalette [-Preset] <String> [[-PaletteSize] <Int32>] [<CommonParameters>]
```

### Colors
```
Get-OxyPalette [-Colors] <OxyColor[]> [[-PaletteSize] <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Gets a color palette object.

When the `-Preset` parameter is specified, this cmdlet returns a preset palette by its value.
Otherwise, this cmdlet generates a new palette based on the sequence of colors given by the `-Colors` parameter.

## EXAMPLES

## PARAMETERS

### -Colors
The sequence of colors to construct a hue of the color palette.

```yaml
Type: Horker.OxyPlotCli.TypeAdaptors.OxyColor[]
Parameter Sets: Colors
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaletteSize
Specifies the number of colors contained in the palette. This parameter determines the smoothness of the color palette.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases: NumberOfColors

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Preset
Specifies the name of the preset palettes.

```yaml
Type: System.String
Parameter Sets: Preset
Aliases: Type
Accepted values: BlueWhiteRed31, Hot64, Hue64, BlackWhiteRed, BlueWhiteRed, Cool, Gray, Hot, Hue, HueDistinct, Jet, Rainbow, RHue

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
