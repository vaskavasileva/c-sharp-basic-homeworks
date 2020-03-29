using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {

            //funkcionira da najde koja e najmnogu pati, ama ako se povtoruva dava samo edno, ako ne stignam denes kje se vratam utre na toj problem za da gi kazuva site :D  
            Console.WriteLine("Please enter a string: ");
            var input = Console.ReadLine();
            string inputLower = input.ToLower();
            var characters = inputLower.ToCharArray();
            var numberOfRepetitions = new int[characters.Length];
            for (int i = 0; i < characters.Length; i++)
            {
                var count = 0;
                for (int j = i+1; j < characters.Length; j++)
                {
                    if (characters[i]==characters[j])
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

            int greatestPosition = Array.IndexOf(numberOfRepetitions, greatest);
            Console.WriteLine(@"Character ""{0}"" appears {1} times.", characters[greatestPosition], greatest);

        }
    }
}
