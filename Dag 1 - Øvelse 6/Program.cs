using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_6a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon wpn = new Weapon();

            Soldier soldier = new Soldier(wpn);

            Soldier soldier1 = new Soldier(); //Instanciates new Soldier object
            Soldier soldier2 = new Soldier(150); //Instanciates new Soldier object with 150 health

            //bool keepPlaying = true;

            //while (keepPlaying)
            //{
            //    Console.Clear();

            //    Console.WriteLine("The soldier's health is: " + soldier1.Health); //Display soldier1's health

            //    Console.WriteLine(soldier1.position); //Displays soldier1's position (vector2)

            //    soldier1.Move();

            //    soldier1.Jump();

            //    soldier1.Shoot();

            //    Console.WriteLine("Do you want to continue? (Y/N)");

            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "n")
            //    {
            //        keepPlaying = false;
            //    }
            //}

            //Console.Clear();
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
