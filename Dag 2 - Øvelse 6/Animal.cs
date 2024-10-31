using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_6
{
    internal class Animal
    {
        protected string name;
        protected int health;
        protected int legs;
        protected int age;

        public Animal(string name, int health, int legs, int age)
        {

        }
        public virtual void Eat()
        {

        }
    }
}
