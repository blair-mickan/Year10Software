using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;
            PlayGame(ref money);
        }

        private static void PlayGame(ref float money)
        {
            Console.Clear();
            float betAmount = MakeBet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "you");
            int dealerTotal = DealCards(rnd, "The dealer");
            bool playerWins = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWins, betAmount, ref money);
            Menu(ref money);
        }

        private static float MakeBet(ref float money)

        private static int DealCards(Random rnd, string player)

        private static bool determineWinner(int player, int dealer)


        private static void Menu(ref float money)
        {
            Console.Write("would you like another game? y/n ");
            if (Console.ReadLine() == "y")
            {
                PlayGame(ref money);
            }
        }
    }

}
