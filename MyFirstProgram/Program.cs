using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            bool isRunning = true;
            int age = 0;

            do
            {
                try {
                    Console.WriteLine("Enter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    isRunning = false;
                } catch (Exception ex) {
                    Console.WriteLine(ex);
                    isRunning = true;
                }
            } while (isRunning);

            Console.WriteLine($"Your age is: {age}");

            Console.ReadKey();
        }
    }
}