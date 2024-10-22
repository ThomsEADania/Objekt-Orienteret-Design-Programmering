using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighscoreList.AddScore(new Score("Thoms", 100));

            HighscoreList.PrintToScreen();



            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
