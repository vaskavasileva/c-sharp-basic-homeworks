using HabitTracker.Entities;
using HabitTracker.Helpers;
using System;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to login (1) or create an account (2) ?");
            var input = Console.ReadLine();
            int answer = CheckInputHelper.CheckTwoPossibilities(input);

            switch (answer)
            {
                case 1:
                    //login
                    var loggedUser = Login.LoginUser();
                    if (loggedUser == null)
                    {
                        break;
                    }
                    LoggedIn.LoggedIn(loggedUser);

                    break;

                case 2:
                    //register
                    Register.RegisterNewUser();
                    Console.WriteLine("Do you want to add another habit(1), log into your account(2) or exit the application(3)?");
                    var input1 = Console.ReadLine();
                    int answer1 = CheckInputHelper.CheckThreePossibilities(input1);
                    
                    switch (answer1)
                    {
                        //add another habit
                        case 1:
                            Console.WriteLine("Do you want to add a good habit(1) or a bad habit(2)?");
                            var input2 = Console.ReadLine(); ;
                            int answer2 = CheckInputHelper.CheckTwoPossibilities(input2);
                            var lastUser = User.AllUsers[User.AllUsers.Count - 1];
                            if (answer2 == 1)
                            {
                                var goodHabit = new Habit();
                                
                                lastUser.GoodHabits.Add(goodHabit);
                                Console.WriteLine("Please set a good habit.");
                                HabitsAdder.SetHabit(goodHabit);
                            }
                            else if (answer2 == 2)
                            {
                                var badHabit = new Habit();

                                lastUser.BadHabits.Add(badHabit);
                                Console.WriteLine("Please set a bad habit.");
                                HabitsAdder.SetHabit(badHabit);
                            }
                            break;

                        //login
                        case 2:
                            var loggedUser1 = Login.LoginUser();
                            if (loggedUser1 == null)
                            {
                                break;
                            }
                            LoggedIn.LoggedIn(loggedUser1);
                            break;

                        //exit application
                        case 3:
                            break;
                        
                    }

                    break;

            }
        }
    }
}
