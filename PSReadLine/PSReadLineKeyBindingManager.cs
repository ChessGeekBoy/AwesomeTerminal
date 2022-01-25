using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Management.Automation;
using Microsoft.PowerShell;

namespace PSReadLineCustomizations
{
    public class PSReadLineKeyBindingManager : IKeyBindingManager
    {
        public FileStream JsonStream { get; set; }

        public PSReadLineKeyBindingManager(string jsonFilePath)
        {
            this.JsonStream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.ReadWrite);
            LoadKeyBindings();
        }

        private void LoadKeyBindings()
        {
            JsonNode node = JsonNode.Parse(this.JsonStream);
            foreach (JsonNode keyBinding in node["simple"].AsArray())
            {
                SetPSReadLineKeyHandlerCommand setPSReadLineKeyHandler = new SetPSReadLineKeyHandlerCommand();
                setPSReadLineKeyHandler.BriefDescription = keyBinding["description"]["brief"].ToString();
                setPSReadLineKeyHandler.Description = keyBinding["description"]["long"].ToString();
                setPSReadLineKeyHandler.ScriptBlock = ScriptBlock.Create($"[Microsoft.PowerShell.PSReadLine]::RevertLine()\n" +
                    $"[Microsoft.PowerShell.PSReadLine]::Insert(\"{keyBinding["cmd"].ToString()}\")" +
                    $"[Microsoft.PowerShell.PSReadLine]::AcceptLine()");
                setPSReadLineKeyHandler.Invoke();
            }
        }

        ~PSReadLineKeyBindingManager()
        {
            this.JsonStream.Dispose();
        }
    }
}