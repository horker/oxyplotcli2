﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Horker.PSOxyPlot.Styles;

namespace Horker.PSOxyPlot.Cmdlets
{
    [Cmdlet("Get", "OxyStyle")]
    public class GetOxyStyle : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false)]
        public string Name;

        protected override void BeginProcessing()
        {
            if (string.IsNullOrEmpty(Name))
            {
                foreach (var s in StyleRegistry.Styles)
                    WriteObject(s);
            }
            else
            {
                var style = StyleRegistry.Get(Name);
                WriteObject(style);
            }
        }
    }
}