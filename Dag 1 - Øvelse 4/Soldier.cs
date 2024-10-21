using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Dag_1___Øvelse_4
{
    internal class Soldier
    {
        #region Fields
        /// <summary>
        /// Soldier's health
        /// </summary>
        private int health;

        /// <summary>
        /// Soldier's armor
        /// </summary>
        private int armor;

        /// <summary>
        /// Soldier's energy
        /// </summary>
        private int energy;

        /// <summary>
        /// Soldier's speed
        /// </summary>
        private float speed;

        /// <summary>
        /// Soldier's name
        /// </summary>
        private string name;

        /// <summary>
        /// Soldier's weapon
        /// </summary>
        private Weapon weapon;

        /// <summary>
        /// Soldier's position
        /// </summary>
        public Vector2 position;
        #endregion

        #region Properties
        /// <summary>
        /// Property for getting and setting soldier's health (Must be >0)
        /// </summary>
        public int Health
        {
            get { return health;}
            set
            {
                if (value > 0)
                {
                    health = value;
                }
            }
        }

        /// <summary>
        /// Property for getting and setting solider's armor (Must be >0 & <=100)
        /// </summary>
        public int Armor
        {
            get { return armor; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    armor = value;
                }
            }
        }

        /// <summary>
        /// Property for getting and setting solider's energy (Must be >0)
        /// </summary>
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value > 0)
                {
                    energy = value;
                }
            }
        }

        /// <summary>
        /// Property for getting and setting solider's speed (Must be >0)
        /// </summary>
        public float Speed
        {
            get { return speed; }
            set 
            { 
                if (value > 0)
                {
                    speed = value;
                }
            }
        }

        /// <summary>
        /// Property for getting and setting solider's name
        /// </summary>
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        /// <summary>
        /// Property for checking if soldier is alive
        /// </summary>
        public bool IsAlive
        {
            get
            {
                if (health > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

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
