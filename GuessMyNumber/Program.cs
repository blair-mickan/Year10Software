using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 101);
            int count = 0;
            int guess = -1;

            while (guess != rand)
            {
                count++;
                Console.Write("guess: ");
                guess = int.Parse(Console.ReadLine());
                if(guess < rand)
                {
                    Console.WriteLine("Too FRICKEN Low!");
                }
                else if (guess > rand)
                {
                    Console.WriteLine("Too GODAMN High!");
                }
                else
                {
                    Console.WriteLine($"you got it pussy! It took {count} tries!");
                    Console.ReadKey();
                }
            }
        }
    }
}
