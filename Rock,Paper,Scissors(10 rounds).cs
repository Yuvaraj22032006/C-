using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            int playerScore = 0;
            int computerScore = 0;
            

            while (playerScore + computerScore < 10)
            {
                Console.Write("Please enter your choice (rock, paper, scissors): ");
                string playerChoice = Console.ReadLine().ToLower();
                Random random = new Random();
                string[] choices = { "rock", "paper", "scissors" };
                string computerChoice = choices[random.Next(choices.Length)];
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a Tie!");
                    //playerScore++;
                    //computerScore++;
                }
                else if (playerChoice == "rock")
                {
                    if (computerChoice == "scissors")
                    {
                        Console.WriteLine("Rock smashes scissors, You Win this round!!!");
                        playerScore++;
                    }
                    else
                    {
                        Console.WriteLine("Paper Covers rock, You Lose this round...");
                        computerScore++;
                    }
                }
                else if (playerChoice == "paper")
                {
                    if (computerChoice == "rock")
                    {
                        Console.WriteLine("Paper covers rock, You Win this round!!!");
                        playerScore++;
                    }
                    else
                    {
                        Console.WriteLine("Scissors cuts paper, You Lose this round...");
                        computerScore++;
                    }
                }
                else if (playerChoice == "scissors")
                {
                    if (computerChoice == "paper")
                    {
                        Console.WriteLine("Scissors cuts paper, You Win this round!!!");
                        playerScore++;

                    }
                    else
                    {
                        Console.WriteLine("Rock smashes scissors, You Lose this round...");
                        computerScore++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice, please enter (rock, paper or scissors)");
                }

            }

            if (playerScore > computerScore)
            {
                Console.WriteLine($"You WON the game!!!!! with a score of {playerScore} to {computerScore}");
            }
            else if (playerScore == computerScore)
            {
                Console.WriteLine($"It's a TIE with a score of {playerScore} to {computerScore}");
            }
            else
            {
                Console.WriteLine($"Sorry, You LOST the game..... with a score of {playerScore} to {computerScore}");
            }


                Console.ReadLine();
        }
    }
}
