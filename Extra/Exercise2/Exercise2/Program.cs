using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var average = 0;
            var summ = 0;
            int number = 0;
            var numbers = new int[10];
            while ( i <= 9)
            {
                
                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();
                bool answer = int.TryParse(input, out number);
                if (answer == false)
                {
                    Console.WriteLine("You need to enter a number!");
                    continue;
                }
                numbers[i] = number;
                i++;
            }

            foreach (var num in numbers)
            {
                summ += num;
            }

            average = summ / 10;

            Console.WriteLine("The summ of the numbers is: " + summ);
            Console.WriteLine("The average of the numbers is: " + average);
        }
    }
}
