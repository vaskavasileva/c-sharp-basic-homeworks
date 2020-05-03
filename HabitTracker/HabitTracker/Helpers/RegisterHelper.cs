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
                User.SetAge(user);
                break;
            }

            User.AllUsers.Add(user);
            Console.WriteLine("You have succesfully created a user!");
        

            Console.WriteLine("You need to set at least one good and one bad habit!");

            //set good habit
            var goodHabit = new Habit();
            user.GoodHabits.Add(goodHabit);
            Console.WriteLine("Please set a good habit.");
            HabitsHelper.SetHabit(goodHabit);

            //set bad habit
            var badHabit = new Habit();
            user.BadHabits.Add(badHabit);
            Console.WriteLine("Please set a bad habit.");
            HabitsHelper.SetHabit(badHabit);
            
        }
    }
}
