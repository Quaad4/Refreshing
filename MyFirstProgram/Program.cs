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
                String computer;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        validInput = false;
                    }

                    if(input == "N")
                    {
                        playing = false;
                        validInput = true;
                    } else if (input == "Y")
                    {
                        validInput = true;
                    }
                } while (!validInput);

            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}