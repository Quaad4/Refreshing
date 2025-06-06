using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            string[] names = { "Alice", "Bob", "Charlie" };
            int[] nums = { 1, 2, 3 };
            double[] doubles = { 1.1, 2.2, 3.3 };

            PrintArray(names);
            PrintArray(nums);
            PrintArray(doubles);

            Console.ReadKey();
        }
        //generics
        public static void PrintArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}