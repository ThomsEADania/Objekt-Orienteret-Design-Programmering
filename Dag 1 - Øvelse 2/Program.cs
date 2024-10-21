﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier(); //Instanciates new Soldier object

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.Clear();

                Console.WriteLine("The soldier's health is: " + soldier1.health); //Display soldier1's health

                Console.WriteLine(soldier1.position); //Displays soldier1's position (vector2)

                soldier1.position.X++; //Increments soldier1's x position
                soldier1.position.Y++; //Increments soldier1's y position

                Console.WriteLine("Do you want to continue? (Y/N)");

                string answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    keepPlaying = false;
                }
            }

            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
