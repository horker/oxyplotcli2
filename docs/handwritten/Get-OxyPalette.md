---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version:
schema: 2.0.0
---

# Get-OxyPalette

## SYNOPSIS
{{Fill in the Synopsis}}

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
{{Fill in the Description}}

## EXAMPLES

### Example 1
```
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -Colors
{{Fill Colors Description}}

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
{{Fill PaletteSize Description}}

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
{{Fill Preset Description}}

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
