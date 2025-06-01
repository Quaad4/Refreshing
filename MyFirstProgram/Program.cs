using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            double side1 = 0;
            double side2 = 0;

            Console.WriteLine("Find the hypotenuse of a right triangle.");

            Console.WriteLine("Please Enter the length of the first side: ");

            try
            {
                side1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading input: " + ex.Message);
            }

            Console.WriteLine("Please Enter the length of the second side: ");

            try
            {
                side2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading input: " + ex.Message);
            }

            double res = Math.Round(Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)), 1);
            Console.WriteLine($"The hypotenuse is: {res}");
            Console.ReadKey();
        }
    }
}