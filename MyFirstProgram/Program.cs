using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21); // Generates a random number between 1 and 21
            double num = random.NextDouble(); // Generates a random double between 0.0 and 1.0
            Console.WriteLine($"The random number generated is: {randomNumber}");

            //Array and its size must be declared before it can be used
            int[] numbers = new int[3];
            //list is a dynamic array that can grow and shrink in size
            List<int> myNums = new List<int>();

            for(int i = 0; i < 3; i++)
            {
                //Use Add method to add elements to the list
                //With a standard array, you would use numbers[i] = random.Next(1, 101);
                myNums.Add(random.Next(1, 101));
            }

            Console.WriteLine("The random numbers generated are: ");
            //Using a foreach loop to iterate through the list. Use Count property to get the number of elements in the list
            //For a typical array, you would use numbers.Length to get the number of elements
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}