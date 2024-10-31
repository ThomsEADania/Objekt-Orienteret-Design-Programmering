using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_8
{
    internal abstract class Animal
    {
        protected string name;
        protected int health;
        protected int legs;
        protected int age;

        public Animal(string Name, int Health, int Legs, int Age)
        {
            name = Name;
            health = Health;
            legs = Legs;
            age = Age;
        }
        public abstract void Eat();
        public abstract void Sleep();
    }
}
