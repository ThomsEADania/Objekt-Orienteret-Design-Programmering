using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            
            while (running)
            {
                Console.Clear();
                
                HighscoreList.PrintToScreen();

                Console.WriteLine("Input your name:");

                string inputName = Console.ReadLine();

                Console.WriteLine("Input your score:");

                int inputScore = int.Parse(Console.ReadLine());

                HighscoreList.AddScore(new Score(inputName, inputScore));
            }
            


            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
