using System;
using System.Linq.Expressions;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            bool playing = true;

            while (playing)
            {
                String computer = "";
                String? player = "";
                string? input = "";
                bool validInput = false;

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Pick between rock, paper, or scissors: ");
                    try
                    {
                        player = Console.ReadLine();
                        if(player == null)
                        {
                            continue;
                        }
                        player = player.ToUpper().Trim();
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                switch(random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine($"You chose {player} and the Computer chose {computer}.");

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose! Paper beats Rock.");
                        }
                        else
                        {
                            Console.WriteLine("You win! Rock beats Scissors.");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win! Paper beats Rock.");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        else
                        {
                            Console.WriteLine("You lose! Scissors beat Paper.");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose! Rock beats Scissors.");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win! Scissors beat Paper.");
                        }
                        else
                        {
                            Console.WriteLine("It's a tie!");
                        }
                        break;
                }

                do
                {
                    try
                    {
                        Console.Write("play again? (Y/N): ");
                        input = Console.ReadLine();

                        if(input == null)
                        {
                            continue;
                        }

                        input = input.ToUpper().Trim();

                        switch (input)
                        {
                            case "Y":
                                break;
                            case "N":
                                playing = false;
                                break;
                            default:
                                continue;
                        }

                        validInput = true;

                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        validInput = false;
                    }

                } while (!validInput);

            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}