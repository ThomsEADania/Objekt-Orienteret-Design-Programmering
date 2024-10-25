using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_6d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon m4 = new Weapon("M4");
            Weapon ak = new Weapon("AK");
            Weapon pistol = new Weapon("Pistol");
            Weapon lmg = new Weapon("LMG");

            Soldier soldier = new Soldier(pistol);

            soldier.Pickup(m4);
            soldier.Pickup(ak);
            soldier.Pickup(lmg);



            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
