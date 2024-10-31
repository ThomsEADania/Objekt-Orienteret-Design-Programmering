using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_8
{
    internal class Tiger : Animal
    {
        private int strength;
        public Tiger(string name, int health, int legs, int age, int strength) : base(name, health, legs, age)
        {
            Console.WriteLine("Running tiger constructor...");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} the tiger is eating some meat");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} the tiger is sleeping");
        }
    }
}
