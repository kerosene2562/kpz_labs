using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _hero;

        public HeroBuilder(string name)
        {
            _hero = new Character(name);
        }

        public ICharacterBuilder SetHeight(int height)
        {
            _hero.SetHeight(height);
            return this;
        }

        public ICharacterBuilder SetPhysique(string physique)
        {
            _hero.SetPhysique(physique);
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _hero.SetHairColor(hairColor);
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _hero.SetEyeColor(eyeColor);
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _hero.SetClothing(clothing);
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            _hero.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string deed)
        {
            _hero.GoodDeeds.Add(deed);
            return this;
        }

        public ICharacterBuilder AddEvilDeed(string deed)
        {
            throw new InvalidOperationException("heroes are good");
        }

        public ICharacterBuilder Reset()
        {
            _hero = new Character(_hero.Name);
            return this;
        }

        public Character Build() => _hero;
    }

}
