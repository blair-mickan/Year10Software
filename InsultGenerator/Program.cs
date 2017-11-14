using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // ask for your name
            string name = GetName();

            // generate a random insult
            GenerateInsult(name, rnd);
        }
        private static string GetName()
        {
            Console.WriteLine("Welcome to the Insult Generator, What is your name?");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine(name + ", you are " + GetAdjective(rnd) + " " + GetCompundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }
        private static void Menu(string name, Random rnd)
        {
            Console.Write("Would you like another insult? Y/N ");
            if (Console.ReadLine() == "y")

                GenerateInsult(name, rnd);
        }
        private static string GetAdjective(Random rnd)
        {
            string[] Adjectives = {"A hairy", "A homosexual", "A fat", "A lame", "A little",
                                   "A black","A skinny","A crackhead", "A big fat" };
            return Adjectives[rnd.Next(9)];
        }
        private static string GetCompundAdjective(Random rnd)
        {
            string[] compoundadjectives = {"no good", "Foul Mouthed", "Cold Hearted", "WaterMelon faced", "Super Faggy"};

            return compoundadjectives[rnd.Next(5)];
        }
        private static string GetObject(Random rnd)
        {
            string[] objects = {"Whale", "FatAss", "PooHole", "Pussy", "Wimp", "Turtle","Lunatic",
                                "WaterMelon", "DumbAss", "Dwarf", "Downie"};
            return[rnd.Next(11)];

        }
    }
}
