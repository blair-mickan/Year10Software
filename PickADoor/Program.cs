using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a door");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("behind door 1 is Armish Doink");
            }
            else if (choice == "2")
            {
                Console.WriteLine("behind door 2 is John Scarce");
            }
            else if (choice == "3")
            {
                Console.WriteLine("beind door 3 is Doinkinater 2000");
            }
            else
            {
                Console.WriteLine("smokin on these big doinks");
            }

            Console.ReadKey();

        }
    }
}
