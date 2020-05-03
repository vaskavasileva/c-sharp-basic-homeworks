using HabitTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Helpers
{
    public class LoggedInHelper
    {
        public static void LoggedIn(User user)
        {
            Console.WriteLine("Do you want to access Habits(1), Staticstics(2) or Edit Account(3)?");
            var input = Console.ReadLine();
            int answer = CheckInputHelper.CheckThreePossibilities(input);

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Do you want to access your daily log or single log?");
                    var input2 = Console.ReadLine();
                    int answer2 = CheckInputHelper.CheckTwoPossibilities(input2);
                    switch (answer2)
                    {
                        case 1:
                            foreach (var habit in user.GoodHabits)
                            {
                                var today = new DateTime();
                                today = DateTime.Today;
                                Console.WriteLine("Is the habit completed(1) or not(2)");
                                var input1 = Console.ReadLine();
                                int answer1 = CheckInputHelper.CheckTwoPossibilities(input1);
                                switch (answer1)
                                {
                                    case 1:
                                        habit.DailyLog.Add(today, true);
                                        break;
                                    case 2:
                                        habit.DailyLog.Add(today, false);
                                        break;
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine("Please enter the title of the habit you want to add info to: ");
                            var title = Console.ReadLine();
                            foreach (var habit in user.GoodHabits)
                            {
                                if (title == habit.Title)
                                {
                                    var day = new DateTime();
                                    Console.Write("Please enter the date you want to add to your habit: ");
                                    var input3 = Console.ReadLine();
                                    day = Convert.ToDateTime(input3);
                                    Console.WriteLine("Is the habit completed(1) or not(2)");
                                    var input1 = Console.ReadLine();
                                    int answer1 = CheckInputHelper.CheckTwoPossibilities(input1);
                                    switch (answer1)
                                    {
                                        case 1:
                                            habit.DailyLog.Add(day, true);
                                            break;
                                        case 2:
                                            habit.DailyLog.Add(day, false);
                                            break;
                                    }
                                }
                                
                            }
                            break;
                            
                    }
                    break;
                    
            }
        }
    }
}
