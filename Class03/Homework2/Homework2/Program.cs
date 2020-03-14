using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);
            for (int i = 2; i <= number1 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Enter another number: ");
            var input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            for (int m = 1; m <= number2; m++)
            {
                if (m % 2 != 0)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
