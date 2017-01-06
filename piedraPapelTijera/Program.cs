using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedraPapelTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            var playAgain = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rock, Paper & Scissors game!");
                Console.WriteLine("Do you choose rock, paper or scissors?");
                var userChoice = Console.ReadLine();

                // ComputerChoice Logic
                var rnd = new Random();
                var computerOption = rnd.Next(1, 4);
                string computerChoise = string.Empty;

                switch (computerOption)
                {
                    case 1:
                        computerChoise = "rock";
                        break;
                    case 2:
                        computerChoise = "paper";
                        break;
                    case 3:
                        computerChoise = "scissors";
                        break;
                    default:
                        break;
                } // end switch computerOption

                Console.WriteLine();

                var game = new Program();
                Console.WriteLine(game.compare(userChoice, computerChoise).ToString().ToUpper());
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? Y/N");
                playAgain = Console.ReadLine();
            } while (playAgain.ToLower() == "y");

        } // End Main()

        public string compare(string userInput, string computerInput)
        {
            if (userInput == computerInput)
            {
                return "The result is a tie!";
            }
            else if (userInput == "rock")
            {
                if (computerInput == "scissors")
                {
                    return "rock wins.";
                }
                else if (computerInput == "paper")
                {
                    return "paper wins.";
                }
            }
            else if (userInput == "paper")
            {
                if (computerInput == "rock")
                {
                    return "paper wins.";
                }
                else
                {
                    return "scissors wins.";
                }
            }
            else if (userInput == "scissors")
            {
                if (computerInput == "rock")
                {
                    return "rock wins.";
                }
                else
                {
                    return "scissors wins";
                }
            }
            return "";
        } // end compare
    }
}
