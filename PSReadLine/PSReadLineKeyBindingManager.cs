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

        public async void SetKeyBinding(IKeyBinding keyBinding)
        {
            List<IKeyBinding> keyBindings = await JsonSerializer.DeserializeAsync<List<IKeyBinding>>
                (JsonStream);
            keyBindings.Add(keyBinding);
            await JsonSerializer.SerializeAsync<List<IKeyBinding>>(this.JsonStream, keyBindings);
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
