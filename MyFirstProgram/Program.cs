using System;

namespace MyFirstProgram
{
   class Program
    {
        private static void Main(string[] args)
        {
            double pi = 3.14;
            // does not mutate the value of pi. Creates new int variable based off its value 
            int pi2 = Convert.ToInt32(pi);

            Console.WriteLine(pi);
            Console.WriteLine(pi2);

            Console.WriteLine(pi.GetType());
            Console.WriteLine(pi2.GetType());

            int password = 123;
            double decimalNum = Convert.ToDouble(password) + 0.1;

            Console.WriteLine(decimalNum);
            Console.WriteLine(decimalNum.GetType());

            int nums = 91554;
            string food = nums.ToString();
            string food2 = Convert.ToString(nums);

            Console.WriteLine(food);
            Console.WriteLine(food.GetType());

            string currency = "$";
            char dollar = Convert.ToChar(currency);
            Console.WriteLine(dollar);
            Console.WriteLine(dollar.GetType());

            string optionChosen = "true";
            bool option = Convert.ToBoolean(optionChosen);  

            Console.WriteLine(option);
            Console.ReadKey();
        }
    }
}