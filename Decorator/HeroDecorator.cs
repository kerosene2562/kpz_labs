using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Decorator
{
    abstract class HeroDecorator : IHero
    {
        protected IHero hero;

        public HeroDecorator(IHero hero)
        {
            this.hero = hero;
        }

        public virtual string GetDescription() => hero.GetDescription();
        public virtual int GetPower() => hero.GetPower();
    }

}
