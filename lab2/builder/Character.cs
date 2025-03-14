
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.builder
{
    public class Character
    {
        public string Name { get; }
        public int Height { get; private set; }
        public string Physique { get; private set; }
        public string HairColor { get; private set; }
        public string EyeColor { get; private set; }
        public string Clothing { get; private set; }
        public List<string> Inventory { get; } = new List<string>();
        public List<string> GoodDeeds { get; } = new List<string>();
        public List<string> EvilDeeds { get; } = new List<string>();

        public Character(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nCharacter: {Name}" +
                $"\nHeight: {Height}\nPhysique: {Physique}" +
                $"\nHair: {HairColor}\nEyes: {EyeColor}" +
                $"\nClothing: {Clothing}\nInventory: {string.Join(", ", Inventory)}" +
                $"\nGood Deeds: {string.Join(", ", GoodDeeds)}" +
                $"\nEvil Deeds: {string.Join(", ", EvilDeeds)}");
        }

        public void SetHeight(int height) => Height = height;
        public void SetPhysique(string physique) => Physique = physique;
        public void SetHairColor(string hairColor) => HairColor = hairColor;
        public void SetEyeColor(string eyeColor) => EyeColor = eyeColor;
        public void SetClothing(string clothing) => Clothing = clothing;
    }
}
