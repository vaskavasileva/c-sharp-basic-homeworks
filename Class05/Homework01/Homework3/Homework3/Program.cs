using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            var input = Console.ReadLine();
            string inputLower = input.ToLower();
            var characters = inputLower.ToCharArray();
            var numberOfRepetitions = new int[characters.Length];
            for (int i = 0; i < characters.Length; i++)
            {
                var count = 0;
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[i] == characters[j])
                    {
                        count++;
                    }
                }
                numberOfRepetitions[i] = count;
            }

            int greatest = 0;

            foreach (var number in numberOfRepetitions)
            {
                if (number > greatest)
                {
                    greatest = number;
                }
            }

            var mostRepetitions = new char[0];
            for (int i = 0; i < numberOfRepetitions.Length; i++)
            {
                if (numberOfRepetitions[i] == greatest)
                {
                    Array.Resize(ref mostRepetitions, mostRepetitions.Length + 1);
                    mostRepetitions[mostRepetitions.Length - 1] = characters[i];
                }
            }

            Console.Write("The character/s that appear most times are: ");
            foreach (var character in mostRepetitions)
            {
                Console.Write(character);
                Console.Write(", ");
            }
            Console.WriteLine("They appear {0} times.", greatest + 1);



        }
    }
}
