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
        }

        private void LoadKeyBindings()
        {
            JsonNode node = JsonNode.Parse(this.JsonStream);
            foreach (JsonNode keyBinding in node["simple"].AsArray())
            {

            }
        }

        ~PSReadLineKeyBindingManager()
        {
            this.JsonStream.Dispose();
        }
    }
}