using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("welcome to my program"+ name);



            // wait at the end
            Console.ReadKey();
        }
    }
}
