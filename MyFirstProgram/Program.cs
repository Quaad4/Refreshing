using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please write your name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "! Welcome to my first program.");

            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old!");

            Console.ReadKey();
        }
    }
}