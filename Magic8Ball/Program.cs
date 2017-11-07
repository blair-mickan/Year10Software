using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            //define array of answers
            string[] answers = { "No", "Yes", "yeet", "maybe dawg", "you'll never know"
                               , "theres a high chance", "certain", "i guess so"
                               , "do the rawr", "could say im a nigger" };
            Console.Write("ask me a question (or type 'exit'): ");
            string choice = Console.ReadLine();
            Random rnd = new Random();
            Console.WriteLine(answers[rnd.Next(0, 4)]);
            Console.ReadKey();
            playGame();
        }
    }
}
