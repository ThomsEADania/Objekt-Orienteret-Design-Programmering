using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Dag_1___Øvelse_3
{
    internal class Soldier
    {
        public int health = 100;

        private int armor;

        private int energy;

        private float speed;

        private string name;

        private Weapon weapon;

        public Vector2 position;

        /// <summary>
        /// Increments soldier's x position
        /// </summary>
        public void Move()
        {
            position.X++;
        }
        /// <summary>
        /// Writes "I'm jumping!" to the console and increments soldier's y position
        /// </summary>
        public void Jump()
        {
            Console.WriteLine("I'm jumping!");
            
            position.Y++;
        }
        /// <summary>
        /// Writes "BANG!" to the console
        /// </summary>
        public void Shoot()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            Console.WriteLine("BANG!");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
