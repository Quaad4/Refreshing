using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool isValid = true;
            string validatePassword = string.Empty;
            string password = string.Empty;

            Console.Write("Hello, please enter  your password: ");
            password = Console.ReadLine();
            Console.Write("Please repeat your password: ");
            validatePassword = Console.ReadLine();

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(validatePassword))
            {
                Console.WriteLine("You did not enter a valid password.");
                isValid = false;
            }

            if(password.Equals(validatePassword) && isValid)
            {
                Console.WriteLine("Welcome");
            } 
            else
            {
                Console.WriteLine("The passwords do not match. Please try again.");
            }

            Console.ReadKey();
        }
    }
}