---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version: https://github.com/horker/oxyplotcli2/blob/master/docs/cmdlets/New-WpfWindow.md
schema: 2.0.0
---

# New-WpfWindow

## SYNOPSIS
Creates a new GUI window.

## SYNTAX

```
New-WpfWindow [[-XamlString] <String>] [[-Content] <UIElement>] [[-Options] <Hashtable>] [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
Creates a new GUI window. The newly created window will be visible immediately.

The content of the window can be specified as the XAML string by the `-XamlString` parameter or a `UIElement` object by the `-Content` parameter.

The windows this cmdlet creates run in a different thread from that of the current PowerShell session. Thus, Their properties should be accessed through the `Invoke-WpfWindowAction` cmdlet.

## EXAMPLES

## PARAMETERS

### -Content
The content of the window.

This content should be bound to the same thread as the window.

```yaml
Type: System.Windows.UIElement
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Options
Specifies the set of the pairs of the property name and the value.

These properties are assigned to the window object.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Indicates to return a created window object.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -XamlString
Specifies the XAML string that compiled to the content of the window.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
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
