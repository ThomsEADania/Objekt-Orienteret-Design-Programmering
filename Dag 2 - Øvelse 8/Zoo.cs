using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_2___Øvelse_8
{
    internal class Zoo
    {
        private Animal[] parrotCage = new Animal[1];
        private Animal[] tigerCage = new Animal[1];

        public void AddAnimal(Animal animal)
        {
            if (animal is Parrot)
            {
                for (int i = 0; i < parrotCage.Length; i++)
                {
                    if (parrotCage[i] == null)
                    {
                        parrotCage[i] = animal;
                        break;
                    }
                }
            }
            if (animal is Tiger)
            {
                for (int i = 0; i < tigerCage.Length; i++)
                {
                    if (tigerCage[i] == null)
                    {
                        tigerCage[i] = animal;
                        break;
                    }
                }
            }
        }
        public void Feed()
        {
            foreach (Animal animal in parrotCage)
            {
                animal.Eat();
            }
            foreach (Animal animal in tigerCage)
            {
                animal.Eat();
            }
        }
    }
}
