using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Classes
{
    public class Aircraft : MainClass
    {
        public string Name { get; }
        public bool IsFree { get; private set; }

        public Aircraft(string name)
        {
            Name = name;
        }

        public void RequestLanding()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Aircraft {Name} goes to landing");
            _mediator?.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Aircraft {Name} take off");
            IsFree = true;
            _mediator?.NotifyTakeOff(this);
            IsFree = false;
        }
    }
}
