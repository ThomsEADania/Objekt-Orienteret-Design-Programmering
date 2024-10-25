using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_1___Øvelse_6d
{
    internal class Weapon
    {
        private int ammo;

        private string name;

        public int Ammo
        {
            get { return ammo; }
            set { ammo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Weapon(string name)
        {
            this.name = name;
        }
    }
}
