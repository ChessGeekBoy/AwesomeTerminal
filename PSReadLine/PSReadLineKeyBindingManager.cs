using System;
using System.IO;

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

        }

        public void DeleteKeyBinding(IKeyBinding keyBinding)
        {

        }

        ~PSReadLineKeyBindingManager()
        {
            this.JsonStream.Dispose();
        }
    }
}
