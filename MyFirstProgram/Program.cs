using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            Console.Write("Enter a Number: ");

            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine($"You entered: {userInput}");
            }
            else
            {
                Console.WriteLine("You did not enter a number or entered 0, which is not a valid number.");
            }

            Console.ReadKey();
        }
    }
}