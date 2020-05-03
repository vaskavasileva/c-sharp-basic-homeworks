using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Helpers
{
    public class CheckInputHelper
    { 
        public static int CheckTwoPossibilities(string input)
        {
            int answer = 0;
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

            return answer;
        }

        public static int CheckThreePossibilities(string input)
        {
            int answer = 0;
            while (true)
            {
                int.TryParse(input, out answer);
                if (answer == 1 || answer == 2 || answer == 3)
                {
                    break;
                }

                Console.WriteLine("You need to choose 1, 2 or 3.");
                input = Console.ReadLine();
            }

            return answer;
        }
    }
}
