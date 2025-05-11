using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using lab3.classes;

namespace lab3.Composite
{
    public class NodeCounterVisitor : IVisitor
    {
        public int ElementCount { get; private set; } = 0;
        public int TextCount { get; private set; } = 0;

        public void Visit(LightElementNode elementNode)
        {
            ElementCount++;
        }

        public void Visit(LightTextNode textNode)
        {
            TextCount++;
        }
    }

}
