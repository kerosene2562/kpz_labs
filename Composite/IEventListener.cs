using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    internal interface IEventListener
    {
        void HandleEvent(string eventType, LightElementNode sender);
    }
}
