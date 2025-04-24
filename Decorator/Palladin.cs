using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator
{
    class Palladin : IHero
    {
        public string GetDescription() => "Palladin";
        public int GetPower() => 9;
    }
}
