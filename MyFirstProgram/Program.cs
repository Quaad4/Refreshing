using System;

namespace MyFirstProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            int index = numbers.IndexOf(3);

            if(index >= 0)
            {
                numbers.RemoveAt(index);
                Console.WriteLine($"Found at index {index}");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("not found in the list.");
            }

            Console.ReadKey();
        }
    }
}