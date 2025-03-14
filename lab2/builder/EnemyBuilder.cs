using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy;

        public EnemyBuilder(string name)
        {
            _enemy = new Character(name);
        }

        public ICharacterBuilder SetHeight(int height)
        {
            _enemy.SetHeight(height);
            return this;
        }

        public ICharacterBuilder SetPhysique(string physique)
        {
            _enemy.SetPhysique(physique);
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _enemy.SetHairColor(hairColor);
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _enemy.SetEyeColor(eyeColor);
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _enemy.SetClothing(clothing);
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            _enemy.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string deed)
        {
            throw new InvalidOperationException("enemies always bad");
        }

        public ICharacterBuilder AddEvilDeed(string deed)
        {
            _enemy.EvilDeeds.Add(deed);
            return this;
        }

        public ICharacterBuilder Reset()
        {
            _enemy = new Character(_enemy.Name);
            return this;
        }

        public Character Build() => _enemy;
    }

}
