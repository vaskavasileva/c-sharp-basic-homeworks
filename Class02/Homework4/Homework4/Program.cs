using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            var input = Console.ReadLine();
            int number;
            bool output = int.TryParse(input, out number);
            if (output == true)

            {
                if (number % 2 == 0)
                    Console.WriteLine("The number is even.");
                else
                    Console.WriteLine("The number is odd.");
            }

            else
                Console.WriteLine("Invalid input.");
            Console.ReadLine();
        }
    }
}
