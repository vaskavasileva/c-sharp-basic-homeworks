using HabitTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HabitTracker.Helpers
{
    public class LoggedInActions
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

                case 2:
                    {
                        Console.WriteLine("Do you want to see your Good Habits(1), Bad Habits(2), Weekly statistics(3) or All time statistics(4)?");
                        var input3 = Console.ReadLine();
                        int answer3 = 0;
                        while (true)
                        {
                            int.TryParse(input3, out answer3);
                            if (answer == 1 || answer == 2 || answer == 3 || answer == 4)
                            {
                                break;
                            }

                            Console.WriteLine("You need to choose 1, 2, 3 or 4.");
                            input = Console.ReadLine();
                        }

                        switch (answer3)
                        {
                            case 1:
                                
                                foreach (var habit in user.GoodHabits)
                                {
                                    int count = 0;
                                    foreach (var log in habit.DailyLog)
                                    {
                                        if (log.Value == true)
                                        {
                                            count++;
                                        }
                                    }
                                    Console.WriteLine($"Habit: {habit.Title}, Times completed: {count}");
                                }
                                break;

                            case 2:

                                foreach (var habit in user.BadHabits)
                                {
                                    int count = 0;
                                    foreach (var log in habit.DailyLog)
                                    {
                                        if (log.Value == true)
                                        {
                                            count++;
                                        }
                                    }
                                    Console.WriteLine($"Habit: {habit.Title}, Times completed: {count}");
                                }
                                break;

                            case 3:

                                var habitsInLast7Days = new List<Habit>();
                                int countCompleted = 0;
                                int countNotCompleted = 0;
                                DateTime todayDate = new DateTime();
                                todayDate = DateTime.Today;
                                var lastSevenDays = new List<DateTime>();
                                for (int i = 0; i < 7; i++)
                                {
                                    lastSevenDays.Add(todayDate);
                                    todayDate = todayDate.AddDays(-1);
                                }

                                var userGoodHabits = user.GoodHabits;
                                foreach (var habit in userGoodHabits)
                                {
                                    foreach (var day in lastSevenDays)
                                    {
                                        if (habit.DailyLog.ContainsKey(day))
                                        {
                                            habitsInLast7Days.Add(habit);
                                        }
                                    }
                                    
                                }

                                foreach (var habit in habitsInLast7Days)
                                {
                                    if (habit.DailyLog.ContainsValue(true))
                                    {
                                        countCompleted++;
                                    }
                                    else if (habit.DailyLog.ContainsValue(false))
                                    {
                                        countNotCompleted++;
                                    }
                                }

                                Console.WriteLine($"In the last 7 days {countCompleted} habits were completed.");
                                Console.WriteLine($"In the last 7 days {countNotCompleted} habits were not completed.");

                                break;

                            case 4:

                                break;

                                
                                    
                                
                        }
                        break;

                        
                    }

                case 3:


            }
        }
    }
}
