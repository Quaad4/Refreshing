using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            double x = 3;
            double y = 9;
            double z = -3;
            double a = 3.14;

            double powerOf = Math.Pow(x, 2); // raises x to the power of 2 (x^2)
            double squareRoot = Math.Sqrt(y); // returns the square root of a number
            double absoluteValue = Math.Abs(z); // returns the absolute value of a number
            double roundedValue = Math.Round(a, 1); // rounds to the closest tenth. The second argument efines the number of decimal places
            double ceilingValue = Math.Ceiling(a); // rounds up to the nearest whole number
            double floorValue = Math.Floor(a); // rounds down to the nearest whole number
            double maxValue = Math.Max(x, y); // returns the maximum of two numbers
            double minValue = Math.Min(x, y); // returns the minimum of two numbers

            Console.WriteLine("The square of " + x + " is: " + powerOf); // Expected output: 9
            Console.WriteLine("The square root of " + y + " is: " + squareRoot); // Expected output: 3
            Console.WriteLine("The absolute value of " + z + " is: " + absoluteValue); // Expected output: 3
            Console.WriteLine("The rounded value of " + a + " is: " + roundedValue); // Expected output: 3.1
            Console.WriteLine("The ceiling value of " + a + " is: " + ceilingValue); // Expected output: 4
            Console.WriteLine("The floor value of " + a + " is: " + floorValue); // Expected output: 3
            Console.WriteLine("The maximum value between " + x + " and " + y + " is: " + maxValue); // Expected output: 9
            Console.WriteLine("The minimum value between " + x + " and " + y + " is: " + minValue); // Expected output: 3

            Console.ReadKey();
        }
    }
}