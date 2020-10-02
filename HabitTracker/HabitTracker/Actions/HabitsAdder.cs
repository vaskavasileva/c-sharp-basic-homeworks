using System;
using System.Collections.Generic;
using System.Text;
using HabitTracker.Entities;
using HabitTracker.Enums;

namespace HabitTracker.Helpers
{
    public class HabitsAdder
    {
        public static Habit SetHabit(Habit habit)
        {
            Console.Write("Enter the title of that habit: ");
            habit.Title = Console.ReadLine();
            Console.WriteLine("Please choose a group to which your habit belongs from the following, and enter the number next to it: ");
            while (true)
            {
                int number = 1;
                foreach (var group in Enum.GetNames(typeof(Group)))
                {
                    Console.Write(group + ", " + number);
                    number++;

                }
                var input = Console.ReadLine();
                int.TryParse(input, out int answer);
                if (answer! > 0 && answer! <= 6)
                {
                    Console.WriteLine("You need to enter a valid group number!");
                    continue;
                }

                switch (answer)
                {
                    case 1:
                        {
                            habit.Group = Group.ExerciseAndSports;
                        }
                        break;
                    case 2:
                        {
                            habit.Group = Group.StudyAndLearning;
                        }
                        break;
                    case 3:
                        {
                            habit.Group = Group.ActivitiesAndHobbies;
                        }
                        break;
                    case 4:
                        {
                            habit.Group = Group.WorkAndCareer;
                        }
                        break;
                    case 5:
                        {
                            habit.Group = Group.HomeAndPersonal;
                        }
                        break;
                    case 6:
                        {
                            habit.Group = Group.Other;
                        }
                        break;

                }
                break;
            }


            Console.WriteLine("Please add a difficulty for your habit by choosing the number next to the difficulty: ");
            while (true)
            {
                var number = 1;
                foreach (var difficulty in Enum.GetNames(typeof(Difficulty)))
                {
                    Console.WriteLine(difficulty);
                    Console.WriteLine(number);
                    number++;
                }
                var input = Console.ReadLine();
                int.TryParse(input, out int answer);
                if (answer! > 0 && answer! <= 3)
                {
                    Console.WriteLine("You need to enter a valid difficulty number!");
                    continue;
                }
                switch (answer)
                {
                    case 1:
                        {
                            habit.Difficulty = Difficulty.Low;
                        }
                        break;
                    case 2:
                        {
                            habit.Difficulty = Difficulty.Medium;
                        }
                        break;
                    case 3:
                        {
                            habit.Difficulty = Difficulty.Hard;
                        }
                        break;
                }
                break;
            }
            return habit;
        }
    }
}
