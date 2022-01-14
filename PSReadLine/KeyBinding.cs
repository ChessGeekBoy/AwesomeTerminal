using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSReadLineCustomizations
{
    public class KeyBinding : IKeyBinding
    {
        public string Key { get; set; }
        public Description Description { get; set; }
        public string ScriptBlockPath { get; set; }
    }
}
