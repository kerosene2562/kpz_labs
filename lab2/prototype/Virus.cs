using System;
using System.Collections.Generic;

namespace lab2.prototype
{
    class Virus : ICloneable
    {
        public int age;
        public double weight;
        public string name;
        public string specie;
        public List<Virus> childs;

        public Virus(int age, double weight, string name, string specie)
        {
            this.age = age;
            this.weight = weight;
            this.name = name;
            this.specie = specie;
            this.childs = new List<Virus>();
        }

        public Virus(Virus prototype)
        {
            this.age = prototype.age;
            this.weight = prototype.weight;
            this.name = prototype.name;
            this.specie = prototype.specie;
            this.childs = new List<Virus>();

            foreach (var child in prototype.childs)
            {
                this.childs.Add(new Virus(child));
            }
        }

        public void AddChild(Virus child)
        {
            childs.Add(child);
        }

        public object Clone()
        {
            return new Virus(this);
        }

        public void printInfo()
        {
            Console.WriteLine($"Age: {this.age}");
            Console.WriteLine($"Weight: {this.weight}");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Specie: {this.specie}");
            Console.WriteLine("Children:");
            foreach (var child in this.childs)
            {
                Console.WriteLine($" - {child.name}");
            }
        }
    }
}