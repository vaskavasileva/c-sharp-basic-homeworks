using System;
using System.Collections.Generic;
using System.Text;
using HabitTracker.Entities;

namespace HabitTracker.Helpers
{
    public class Login
    {
        public static User LoginUser()
        {
            while (true)
            {

                Console.Write("Please enter your username: ");
                var username = Console.ReadLine();
                Console.Write("Please enter your password: ");
                var password = Console.ReadLine();
                int count = 1;
                if (count <= 3)
                {
                    foreach (var user in User.AllUsers)
                    {
                        if (username == user.Username)
                        {
                            if (password == user.Password)
                            {
                                return user;
                            }
                            Console.WriteLine("Incorrect username or password.");
                            count++;
                            continue;
                        }

                        Console.WriteLine("Incorrect username or password.");
                        count++;
                        continue;
                    }
                }

                if (count > 3)
                {
                    Console.WriteLine("You entered wrong username or password for 3 times.");
                }
                return null;
            }
        }
    }
}
