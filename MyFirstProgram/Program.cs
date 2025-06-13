using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 == 1)
                {
                    oddNumbers.Add(i);
                }
                else
                {
                    evenNumbers.Add(i);
                }
            }

            Console.WriteLine("Odd Numbers");
            foreach(int number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Even Numbers");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}