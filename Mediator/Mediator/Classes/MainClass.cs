using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Interfaces;

namespace Mediator.Classes
{
    public class MainClass
    {
        protected IAirTrafficMediator? _mediator;

        public void SetMediator(IAirTrafficMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
