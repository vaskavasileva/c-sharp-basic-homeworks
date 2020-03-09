using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            string input = "9";
            int number1 = Convert.ToInt32(input);

            int result = number1 - number;
            Console.WriteLine("The result is: " + result);
        }
    }
}
