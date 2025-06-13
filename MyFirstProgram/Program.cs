using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] numbers = new int[length];

            for(int i = 1; i <= length; i++)
            {
                numbers[i - 1] = num * i;
            }

            Console.WriteLine(string.Join(" ", numbers));

            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}