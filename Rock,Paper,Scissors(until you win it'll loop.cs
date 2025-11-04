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

            bool untilWin = false;

            while (!untilWin)
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
                }
                else if (playerChoice == "rock")
                {
                    if (computerChoice == "scissors")
                    {
                        Console.WriteLine("Rock smashes scissors, You Win!!!");
                        untilWin = true;
                    }
                    else
                    {
                        Console.WriteLine("Paper Covers rock, You Lose...");

                    }
                }
                else if (playerChoice == "paper")
                {
                    if (computerChoice == "rock")
                    {
                        Console.WriteLine("Paper covers rock, You Win!!!");
                        untilWin = true;
                    }
                    else
                    {
                        Console.WriteLine("Scissors cuts paper, You Lose...");

                    }
                }
                else if (playerChoice == "scissors")
                {
                    if (computerChoice == "paper")
                    {
                        Console.WriteLine("Scissors cuts paper, You Win!!!");
                        untilWin = true;

                    }
                    else
                    {
                        Console.WriteLine("Rock smashes scissors, You Lose...");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice, please enter (rock, paper or scissors)");
                }

            }
            

            Console.ReadLine();
        }
    }
}
