using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            // a line is created after the line is written with writeline
            Console.WriteLine("Hello!");
            // This is a comment and no enter is added
            Console.Write("Hey! ");
            Console.WriteLine("Hey again on the same line!");

            //tab
            Console.WriteLine("Alex\tWood");
            //backslash
            Console.WriteLine("Alex\bWood");
            //newline
            Console.WriteLine("Alex\nWood");

            //await key input before ending program
            Console.ReadKey();
        }
    }
}