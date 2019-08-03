---
external help file: Horker.OxyPlotCli.dll-Help.xml
Module Name: oxyplotcli
online version:
schema: 2.0.0
---

# Invoke-WpfWindowAction

## SYNOPSIS
Invokes a script block in the context of the GUI thread of the OxyPlot CLI windows.

## SYNTAX

```
Invoke-WpfWindowAction [-Action] <ScriptBlock> [<CommonParameters>]
```

## DESCRIPTION
Invokes a script block in the context of the GUI thread of the OxyPlot CLI windows.

The OxyPlot CLI library creates GUI window objects in the different thread from that of the PowerShell session.
The user should use this cmdlet to access the properties of such objects.

## EXAMPLES

## PARAMETERS

### -Action
The script block to be invoked.

```yaml
Type: System.Management.Automation.ScriptBlock
Parameter Sets: (All)
Aliases:

Required: True
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

### System.Object
## NOTES

## RELATED LINKS
