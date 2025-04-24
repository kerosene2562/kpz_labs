using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    class Logging : IEventListener
    {
        private string name;

        public Logging(string name)
        {
            this.name = name;
        }

        public void HandleEvent(string eventType, LightElementNode sender)
        {
            Console.WriteLine($"{name} перехопив '{eventType}' від елементу {sender.TagName}");
        }
    }
}
