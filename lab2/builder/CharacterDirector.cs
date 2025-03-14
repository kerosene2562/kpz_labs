using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.builder
{
    public class CharacterDirector
    {
        public Character BuildHero(HeroBuilder builder)
        {
            return builder
                .SetHeight(182)
                .SetPhysique("strong")
                .SetHairColor("black")
                .SetEyeColor("green")
                .SetClothing("dress")
                .AddToInventory("stick")
                .AddToInventory("lenovo ideapad 5 pro 16ach6")
                .AddGoodDeed("saved a bee")
                .Build();
        }

        public Character BuildEnemy(EnemyBuilder builder)
        {
            return builder
                .SetHeight(100)
                .SetPhysique("weak")
                .SetHairColor("black")
                .SetEyeColor("dark blue")
                .SetClothing("naked")
                .AddToInventory("staff of universe destruction")
                .AddEvilDeed("tryed to kill a bee")
                .Build();
        }
    }

}
