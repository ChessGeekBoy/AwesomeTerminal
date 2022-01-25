using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSReadLineCustomizations
{
    public interface IKeyBinding
    {
        string Key { get; }
        string ScriptBlock { get; }
        Description Description { get; }
    }
}
