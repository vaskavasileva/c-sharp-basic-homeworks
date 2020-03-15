using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            var denovi = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            int number;
            bool answer = int.TryParse(input, out number);
            while (answer == false || number > 7 || number < 1)
            {
                Console.Write("Enter a new number: ");
                input = Console.ReadLine();
                answer = int.TryParse(input, out number);
            }
            for (int i = 0; i < denovi.Length; i++)
            {
                    if (number == i + 1)
                    {
                        Console.WriteLine("The day is " + denovi[i]);
                    }
            }
            
        }
    }
}
