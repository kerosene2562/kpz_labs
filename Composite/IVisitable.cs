using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3.classes;

namespace lab3.Composite
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
