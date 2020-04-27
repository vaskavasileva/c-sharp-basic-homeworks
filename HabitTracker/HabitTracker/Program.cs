using HabitTracker.Helpers;
using System;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to login (1) or create an account (2) ?");
            int answer = 0;
            var input = Console.ReadLine();

            while (true)
            {
                int.TryParse(input, out answer);
                if (answer == 1 || answer == 2)
                {
                    break;
                }

                Console.WriteLine("You need to choose 1 or 2.");
                input = Console.ReadLine();
            }

            switch (answer)
            {
                case 1:
                    //login
                    break;

                case 2:
                    //register
                    RegisterHelper.RegisterNewUser();
                    
                    break;

            }
        }
    }
}
