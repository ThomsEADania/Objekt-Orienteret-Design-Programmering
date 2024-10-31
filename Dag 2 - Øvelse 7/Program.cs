using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Felix",100,4,6,50);

            Parrot parrot = new Parrot("Peter",50,2,4,50,true);

            parrot.Sleep();

            tiger.Sleep();

            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey();
        }
    }
}
