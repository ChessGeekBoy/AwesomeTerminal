using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSReadLineCustomizations
{
    public class SimpleKeyBinding : IKeyBinding
    {
        public string Key { get; set; }
        public Description Description { get; set; }
        public string ScriptBlock { get; set; }

        public SimpleKeyBinding(string command)
        {
            this.ScriptBlock = $"[Microsoft.PowerShell.PSReadLine]::RevertLine()\n[Microsoft.PowerShell.PSReadLine]::Insert({command})\n[Microsoft.PowerShell.PSReadLine]::AcceptLine()";
        }
    }
}
