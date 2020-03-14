using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[10];
            int i = 0;
            char answer = 'y';
            do
            {
                Console.WriteLine("Enter a name: ");
                names[i] = Console.ReadLine();

                Console.WriteLine("Do you want to enter another name? (y/n)");
                var input = Console.ReadLine();
                answer = Convert.ToChar(input);

            } while (answer == 'y');


            
        }
    }
}
