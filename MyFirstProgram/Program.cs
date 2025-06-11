using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] angles = new int[3];
            bool[] success = new bool[angles.Length];
            bool hasFailed = false;
            int res = 0;

            for(int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle number {i + 1}: ");
                success[i] = int.TryParse(Console.ReadLine(), out angles[i]);
            }

            Console.WriteLine("The angles you entered are:");
            for(int i = 0; i < angles.Length; i++)
            {
                if (success[i])
                {
                    res += angles[i];
                    Console.WriteLine($"Angle {i + 1}: {angles[i]} degrees");
                }
                else
                {
                    hasFailed = true;
                    Console.WriteLine($"Angle {i + 1}: Invalid input");
                }
            }

            if(!hasFailed)
            {
                Console.WriteLine(res == 180 ? "The angles form a valid triangle." : "The angles do not form a valid triangle.");
            }
            else
            {
                Console.WriteLine("Please ensure all inputs are valid integers.");
            }

            Console.ReadKey();
        }
    }
}