using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hedder øvelse 8 i slideshowet

namespace Dag_2___Øvelse_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----STRUCT OPERATIONS-----");
            VaultStruct vaultStruct = new VaultStruct(100);
            Console.WriteLine(vaultStruct);
            AddGoldStruct(vaultStruct); //Needs to use ref keyword explanation in method
            Console.WriteLine(vaultStruct);

            Console.WriteLine();

            Console.WriteLine("-----CLASS OPERATIONS-----");
            VaultClass vaultClass = new VaultClass(100);
            Console.WriteLine(vaultClass);
            AddGoldClass(vaultClass);
            Console.WriteLine(vaultClass);

            Console.WriteLine("\nPress any key to exit program...");
            Console.ReadKey();
        }

        public static void AddGoldStruct(VaultStruct vault) //From chatGPT "When you pass an instance of a struct to a method, C# creates a copy of that instance.
                                                            //Use the ref keyword to pass the struct by reference so that changes are made to the original instance."
        {
            Console.WriteLine("Added 10 gold to the vault parameter");
            vault.Gold += 10;
        }

        public static void AddGoldClass(VaultClass vault)
        {
            Console.WriteLine("Added 10 gold to the vault parameter");
            vault.Gold += 10;
        }
    }

    public class VaultClass
    {
        public int Gold { get; set; }

        public VaultClass(int gold)
        {
            Gold = gold;
            Console.WriteLine($"Created a class vault with {gold} gold");
        }

        public override string ToString()
        {
            return $"This vault class contains {Gold} gold!";
        }
    }

    public struct VaultStruct
    {
        public int Gold { get; set; }

        public VaultStruct(int gold)
        {
            Gold = gold;
            Console.WriteLine($"Created a vault struct with {gold} gold");
        }

        public override string ToString()
        {
            return $"This vault struct contains {Gold} gold!";
        }
    }
}
