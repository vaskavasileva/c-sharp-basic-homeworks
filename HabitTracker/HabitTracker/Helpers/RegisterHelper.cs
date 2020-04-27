using System;
using System.Collections.Generic;
using System.Text;
using HabitTracker.Entities;
using HabitTracker.Enums;

namespace HabitTracker.Helpers
{
    public class RegisterHelper
    {
        public static void RegisterNewUser()
        {
            Console.WriteLine("You have created a new user!");

            var user = new User();

            //add a username
            while (true)
            {
                Console.Write("Please enter a username: ");
                var input = Console.ReadLine();
                char[] characters = input.ToCharArray();
                if (characters.Length < 6)
                {
                    Console.WriteLine("Your username needs to be at least 6 characters long!");
                    continue;
                }
                if (Char.IsDigit(characters[0]))
                {
                    Console.WriteLine("The username can not start with a number!");
                    continue;
                }
                user.Username = input;
                break;
            }

            //add a password
            while (true)
            {
                Console.Write("Please enter a password: ");
                var input = Console.ReadLine();
                char[] characters = input.ToCharArray();
                if (characters.Length < 6)
                {
                    Console.WriteLine("Your username needs to be at least 6 characters long!");
                    continue;
                }
                int counter = 0;
                for (int i = 0; i < characters.Length; i++)
                {
                    if (Char.IsDigit(characters[i]))
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine("Your password needs to contain at lease one number!");
                    continue;
                }
                user.Password = input;
                break;
            }

            //add a first name
            while (true)
            {
                Console.Write("Please enter a first name: ");
                var input = Console.ReadLine();
                char[] characters = input.ToCharArray();
                if (characters.Length < 2)
                {
                    Console.WriteLine("Your first name must be at least two characters long!");
                    continue;
                }
                int counter = 0;
                for (int i = 0; i < characters.Length; i++)
                {
                    if (Char.IsDigit(characters[i]))
                    {
                        counter++;
                    }
                }
                if (counter != 0)
                {
                    Console.WriteLine("Your first name must not contain a number!");
                    continue;
                }
                user.FirstName = input;
                break;
            }

            //add a last name
            while (true)
            {
                Console.Write("Please enter a last name: ");
                var input = Console.ReadLine();
                char[] characters = input.ToCharArray();
                if (characters.Length < 2)
                {
                    Console.WriteLine("Your first name must be at least two characters long!");
                    continue;
                }
                int counter = 0;
                for (int i = 0; i < characters.Length; i++)
                {
                    if (Char.IsDigit(characters[i]))
                    {
                        counter++;
                    }
                }
                if (counter != 0)
                {
                    Console.WriteLine("Your first name must not contain a number!");
                    continue;
                }
                user.LastName = input;
                break;
            }

            //add date of birth
            while (true)
            {
                Console.Write("Please enter your date of birth in the following format (MM/dd/yyyy): ");
                var input = Console.ReadLine();
                var dateOfBirth = Convert.ToDateTime(input);
                var thisTime = DateTime.Today;
                if ((dateOfBirth.Year - thisTime.Year) !> 5 && (dateOfBirth.Year - thisTime.Year) !< 122)
                {
                    Console.WriteLine("The age must be between 5 and 122 years old!");
                    continue;
                }
                user.DateOfBirth = dateOfBirth;
                break;
            }

            Array.Resize(ref User.AllUsers, User.AllUsers.Length + 1);
            User.AllUsers[User.AllUsers.Length - 1] = user;
            Console.WriteLine("You have succesfully created a user!");
        

            Console.WriteLine("You need to set at least one good and one bad habit!");

            //set good habit
            var goodHabit = new Habit();
            user.GoodHabits[0] = goodHabit;
            Console.WriteLine("Please set a good habit.");
            Console.Write("Enter the title of that habit: ");
            goodHabit.Title = Console.ReadLine();
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
                            goodHabit.Group = Group.ExerciseAndSports;
                        }
                        break;
                    case 2:
                        {
                            goodHabit.Group = Group.StudyAndLearning;
                        }
                        break;
                    case 3:
                        {
                            goodHabit.Group = Group.ActivitiesAndHobbies;
                        }
                        break;
                    case 4:
                        {
                            goodHabit.Group = Group.WorkAndCareer;
                        }
                        break;
                    case 5:
                        {
                            goodHabit.Group = Group.HomeAndPersonal;
                        }
                        break;
                    case 6:
                        {
                            goodHabit.Group = Group.Other;
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
                            goodHabit.Difficulty = Difficulty.Low;
                        }
                        break;
                    case 2:
                        {
                            goodHabit.Difficulty = Difficulty.Medium;
                        }
                        break;
                    case 3:
                        {
                            goodHabit.Difficulty = Difficulty.Hard;
                        }
                        break;
                }
                break;
            }

            //set bad habit
            var badHabit = new Habit();
            user.BadHabits[0] = badHabit;
            Console.WriteLine("Please set a bad habit.");
            Console.Write("Enter the title of that habit: ");
            badHabit.Title = Console.ReadLine();
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
                            badHabit.Group = Group.ExerciseAndSports;
                        }
                        break;
                    case 2:
                        {
                            badHabit.Group = Group.StudyAndLearning;
                        }
                        break;
                    case 3:
                        {
                            badHabit.Group = Group.ActivitiesAndHobbies;
                        }
                        break;
                    case 4:
                        {
                            badHabit.Group = Group.WorkAndCareer;
                        }
                        break;
                    case 5:
                        {
                            badHabit.Group = Group.HomeAndPersonal;
                        }
                        break;
                    case 6:
                        {
                            badHabit.Group = Group.Other;
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
                            badHabit.Difficulty = Difficulty.Low;
                        }
                        break;
                    case 2:
                        {
                            badHabit.Difficulty = Difficulty.Medium;
                        }
                        break;
                    case 3:
                        {
                            badHabit.Difficulty = Difficulty.Hard;
                        }
                        break;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("If you want to enter another habit press 1, if you want to login to your account press 2, and if you want to exit the application press 3. ");
                var input = Console.ReadLine();
                int.TryParse(input, out int answer);
                if (answer < 1 && answer > 3)
                {
                    Console.WriteLine("You need to enter a valid option!");
                    continue;
                }

                switch (answer)
                {
                    case 1:
                        {
                            //add habit
                            
                        }
                        break;

                    case 2:
                        {
                            //login
                        }
                        break;

                    case 3:
                        break;
                }
                break;
            }
            


        }
    }
}
