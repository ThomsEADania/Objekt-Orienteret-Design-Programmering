using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            bool showPrompt = true;

            while (running)
            {
                Console.Clear();

                showPrompt = !HighscoreList.PrintToScreen();

                string inputName;
                int inputScore;

                if (showPrompt)
                {
                    Console.WriteLine("Input your name:");

                    inputName = Console.ReadLine();

                    Console.WriteLine("Input your score:");

                    inputScore = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }

                HighscoreList.AddScore(new Score(inputName, inputScore));
            }

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }
    }
}
