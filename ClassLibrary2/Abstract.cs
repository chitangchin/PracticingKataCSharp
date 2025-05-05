using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public abstract class Shape
    {
        //Abstract vs virtual: Abstract is an overridable method with no implementation, Virtual is an overridable method with an implementation.
        public abstract int GetArea();
    }
}
