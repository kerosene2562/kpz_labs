using Mediator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interfaces
{
    public interface IAirTrafficMediator
    {
            void RequestLanding(Aircraft aircraft);
            void NotifyTakeOff(Aircraft aircraft);
    }
}
