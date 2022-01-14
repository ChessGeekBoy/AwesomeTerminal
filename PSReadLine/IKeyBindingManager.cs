using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSReadLineCustomizations
{
    public interface IKeyBindingManager
    {
        void DeleteKeyBinding(IKeyBinding binding);
        void SetKeyBinding(IKeyBinding binding);
    }
}
