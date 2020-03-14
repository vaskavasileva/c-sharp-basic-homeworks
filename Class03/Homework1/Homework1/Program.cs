using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            int number1 = Convert.ToInt32(input);
            for (int i = 1; i <= number1; i++)
                Console.WriteLine(i);

            Console.Write("Enter a new number: ");
            var input1 = Console.ReadLine();
            int number2 = Convert.ToInt32(input1);
            for (int m = number2; m >= 1; m--)
                Console.WriteLine(m);

        }
    }
}
