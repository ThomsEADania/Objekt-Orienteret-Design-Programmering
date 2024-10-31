﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_8
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
            Console.WriteLine($"{name} the parrot says \"Hello, my name is {name}\"");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} the parrot is pecking at seeds");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} the parrot is sleeping");
        }
    }
}
