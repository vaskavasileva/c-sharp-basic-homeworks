using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string you want to reverse: ");
            string input = Console.ReadLine();
            string copy = input;
            var characters = input.ToCharArray();
            Array.Reverse(characters);
            Console.WriteLine("The reversed order of characters in the string {0} is : ", copy);
            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }

        }
    }
}
