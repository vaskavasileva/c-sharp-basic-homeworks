using System;

namespace Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2008; i <= 2020; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine(i + " is a leap year!");
                }
            }
        }
    }
}
