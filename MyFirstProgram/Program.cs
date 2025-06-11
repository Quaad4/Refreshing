using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] angles = new int[3];
            bool[] success = new bool[3];

            Console.Write("Enter the first angle: ");
            success[0] = int.TryParse(Console.ReadLine(), out angles[0]);

            Console.Write("Enter the second angle: ");
            success[1] = int.TryParse(Console.ReadLine(), out angles[1]);

            Console.Write("Enter the third angle: ");
            success[2] = int.TryParse(Console.ReadLine(), out angles[2]);

            Console.WriteLine("The angles you entered are:");
            for(int i = 0; i < angles.Length; i++)
            {
                if (success[i])
                {
                    Console.WriteLine($"Angle {i + 1}: {angles[i]} degrees");
                }
                else
                {
                    Console.WriteLine($"Angle {i + 1}: Invalid input");
                }
            }

            Console.ReadKey();
        }
    }
}