using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSReadLineCustomizations
{
    public class ComplexKeyBinding : IKeyBinding
    {
        public string Key { get; set; }
        public Description Description { get; set; }
        public string ScriptBlock { get; set; }

        public ComplexKeyBinding(string key, string scriptBlock, Description description)
        {
            this.Key = key;
            this.ScriptBlock = scriptBlock;
            this.Description = description;
        }
    }
}
