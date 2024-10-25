using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_6b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon wpn = new Weapon();

            Soldier soldier = new Soldier(wpn);

            Jeep jeep = new Jeep();

            soldier.Drive(jeep);
            
            Console.WriteLine();

            Soldier soldier1 = new Soldier(); //Instanciates new Soldier object
            Soldier soldier2 = new Soldier(150); //Instanciates new Soldier object with 150 health

            

            //Console.Clear();
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
