using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator
{
    class Weapon : HeroDecorator
    {
        public Weapon(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + ", Weapon";
        public override int GetPower() => hero.GetPower() + 5;
    }
}
