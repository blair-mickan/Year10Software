using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserScore = 0;
            int computerscore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                printscore(ref UserScore, ref computerscore);              // Print scores
                string UserChoice = UserTurn();                            // Users turn
                string ComputerChoice = ComputerTurn();                    // Computers turn
                result = DetermineWinnner(UserChoice, ComputerChoice);     // Determine the winner
                GiveFeedback(result, UserChoice, ComputerChoice);          //Provide feedback
                UpdateScores(result, ref UserScore, ref computerscore);    //Update the score
                repeat = PlayAgain();                                      //Ask to play again

            }
        }

        private static void Printscore(ref int UserScore, ref int computerscore)
        {
            Console.Clear();
            Console.Write("User: " + UserScore + "  computer: " + computerscore);
        }
        private static string UserTurn()
        {
            string choice = "";
            while(choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.Write("your choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }
            else if (choice == "2")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.next(1, 4);

            if (choice == "1")
            {
                return "Rock";
            }
            if else (choice == "2")
            {
                return "Paper";
            }
            else (choice == "3")
            {
                return "Scissors";
            }
            
        }
        private static string DetermineWinner(string User, string Computer)
        {
            if (User == "Rock")
            {
                if (computer == "Rock")
                {
                    return "Draw"
                }
                else if (Computer == "Paper")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }
            }
            else if (user == "Paper")
            {
                if (computer == "Rock")
                {
                    return "Win";
                }
                else if (computer == "Paper")
                {
                    return "Draw";
                }
                else
                {
                    return "Lose";
                }
            }
            else
            {
                if (Computer == "Rock")
                {
                    return "Lose";
                }
                else if (Computer == "Paper")
                {
                    return "Win";
                }
                else
                {
                    return "Draw";
                }
            }
           
         
        private static void GiveFeedback(string result, string UserChoice, string ComputerChoice)
        {
                Console.WriteLine(result + "! the computer chose" + ComputerChoice + "and you chose" + UserChoice)
        }
        private static bool PlayAgain()
        {
            return true;
        }
        private static void UpdateScores(string result, ref int UserScore, ref int ComputerScore)
        {

        }
            

    }   

}
