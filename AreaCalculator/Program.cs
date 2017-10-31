using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice = "";
            while (Choice != "4")
            {
                // Menu
                Console.Clear();
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1. Area of rectangle");
                Console.WriteLine("2.Area of triangle");
                Console.WriteLine("3. Area of circle");
                Console.WriteLine("4.Exit");
                Choice = Console.ReadLine();

                if (Choice == "1")
                {
                    // rectangle
                    Console.WriteLine();
                    Console.Write("width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine("area: " + (width * length));

                }
                else if (Choice == "2")
                {
                    // triangle
                }
                else if (Choice == "3")
                {
                    // circle
                }
                // wait
                Console.WriteLine();
                Console.WriteLine("press any key to coninue...");
                Console.ReadKey();
            }
            
        }
    }
}
