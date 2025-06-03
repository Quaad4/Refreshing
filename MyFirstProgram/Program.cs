using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game! ");
            bool playing = true;
            bool validInput = false;
            Random random = new Random();
            int guess = 0;
            int guessCount = 0;

            while (playing)
            {
                int numberToGuess = random.Next(1, 101); // Random number between 1 and 100

                while (guess != numberToGuess)
                {
                    try
                    {
                        Console.Write("Please enter a number between 1 and 100: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}.. Invalid input. Please enter a valid number.");
                        continue; // Skip to the next iteration of the loop
                    }

                    if (guess > numberToGuess)
                    {
                        Console.Write($"{guess} is too high! Try Again. ");
                    }
                    else if (guess < numberToGuess)
                    {
                        Console.Write($"{guess} is too low! Try Again. ");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! {guess} is the correct number! It took you {guessCount} guesses!");

                    }
                    guessCount++;
                }

                do
                {
                    try
                    {
                        Console.Write("Do you want to play again? (y/n): ");
                        string? input = Console.ReadLine();
                        if (input == null)
                        {
                            Console.WriteLine("No input detected. Please try again.");
                            continue;
                        }
                        input = input.ToUpper();
                        switch (input)
                        {
                            case "Y":
                                playing = true;
                                break;
                            case "N":
                                playing = false;
                                break;
                            default:
                                continue;
                        }
                        validInput = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}. Something went wrong. Please try again.");
                        validInput = false;
                    }
                } while (!validInput);
            }
            Console.WriteLine("Thank you for playing! Goodbye!");
            Console.ReadKey();
        }
    }
}