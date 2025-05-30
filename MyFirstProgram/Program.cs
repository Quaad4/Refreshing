using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            int age = 27;
            double height = 183;
            string name = "Alex";
            bool alive = true;
            char character = '@';

            Console.WriteLine(String.Concat(age, " ", name));

            Console.WriteLine(age + " " + name);

            Console.WriteLine("Your height is: " + height);

            if (alive)
            {
                Console.WriteLine("You are alive");
            }

            Console.WriteLine(character);
            Console.ReadKey();
        }
    }
}