using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_6
{
    internal class Parrot : Animal
    {
        private int agility;
        private bool canFly;

        public Parrot(string name, int health, int legs, int age, int agility, bool canFly) : base(name, health, legs, age)
        {
            Console.WriteLine("Running parrot constructor...");
        }
        public void Fly()
        {

        }
        public void Talk()
        {
            Console.WriteLine($"I'm a parrot, SQUAWK!");
        }
    }
}
