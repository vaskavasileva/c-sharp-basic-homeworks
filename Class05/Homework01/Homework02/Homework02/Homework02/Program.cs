using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            var input = Console.ReadLine();
            var words = input.Split(' ');
            int count = 0;
            foreach (var word in words)
            {
                count++;
            }
            Console.WriteLine("The number of words in your sentence is: " + count);
        }
    }
}
