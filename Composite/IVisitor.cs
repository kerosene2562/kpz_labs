using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab3.Composite
{
    public interface IVisitor
    {
        void Visit(LightElementNode elementNode);
        void Visit(LightTextNode textNode);
    }
}
