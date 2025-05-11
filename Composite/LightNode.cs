using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public abstract class LightNode
    {
        public abstract void Insert();
        public abstract void Remove();
        public abstract string OuterHTML();
        public abstract string InnerHTML();
        public abstract void Accept(IVisitor visitor);
    }
}
