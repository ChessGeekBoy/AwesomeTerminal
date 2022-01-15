using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PSReadLineCustomizations
{
    public class PSReadLineKeyBindingManager : IKeyBindingManager
    {
        public FileStream JsonStream { get; set; }

        public PSReadLineKeyBindingManager(string jsonFilePath)
        {
            this.JsonStream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.ReadWrite);
        }

        public void SetKeyBinding(IKeyBinding keyBinding)
        {
            JsonNode jsonDocument;
            jsonDocument = JsonNode.Parse(this.JsonStream);
            foreach (JsonNode node in jsonDocument["simple"].AsArray())
            {
                
            }
        }

        public async void DeleteKeyBinding(IKeyBinding keyBinding)
        {

        }

        ~PSReadLineKeyBindingManager()
        {
            this.JsonStream.Dispose();
        }
    }
}
