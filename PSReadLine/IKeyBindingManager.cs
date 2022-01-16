using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSReadLineCustomizations
{
    public interface IKeyBindingManager
    {
        void DeleteKeyBinding(SimpleKeyBinding keyBinding);
        void DeleteKeyBinding(ComplexKeyBinding keyBinding);
        void SetKeyBinding(SimpleKeyBinding keyBinding);
        void SetKeyBinding(ComplexKeyBinding keyBinding);
    }
}
