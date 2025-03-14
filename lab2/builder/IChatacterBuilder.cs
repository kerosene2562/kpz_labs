using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetPhysique(string physique);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddToInventory(string item);
        ICharacterBuilder AddGoodDeed(string deed);
        ICharacterBuilder AddEvilDeed(string deed);
        ICharacterBuilder Reset();
        Character Build();
    }

}
