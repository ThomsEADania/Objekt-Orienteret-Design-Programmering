using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vS1 = new Vector(10, 12);
            Vector vS2 = vS1; //vS1 is copied to vS2 which is it's own object
            vS2.X = 100; //Only vS2.X is changed

            Console.WriteLine("Structs {0} : {1}", vS1, vS2);
            
            VectorC vC1 = new VectorC(10, 12);
            VectorC vC2 = vC1; //vC2 is created with vC1 as a reference, meaning they share X and Y values
            vC2.X = 100; //vC1.X is changed since vC2 references vC1's values

            Console.WriteLine("Structs {0} : {1}", vC1, vC2);

            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey();
        }
    }
    public struct Vector
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Vector (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("({0},{1})", X, Y);
        }
    }
    public class VectorC
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public VectorC (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("({0},{1})", X, Y);
        }
    }
}
