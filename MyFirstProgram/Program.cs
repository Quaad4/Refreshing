using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            int friends = 5;
            int remainder = 0;

            //friends = friends + 1; // Incrementing friends using addition assignment operator
            //friends += 2; // Incrementing friends using compound assignment operator
            //friends++; // Incrementing friends using postfix increment operator

            //friends--; // Decrementing friends using postfix decrement operator

            //friends *= 2; // Multiplying friends by 2 using compound assignment operator
            //friends /= 2; // Dividing friends by 2 using compound assignment operator
            remainder = friends % 2; // Modulus operation to find remainder when friends is divided by 2

            Console.WriteLine(remainder); // Output the value of remainder

            Console.ReadKey();
        }
    }
}