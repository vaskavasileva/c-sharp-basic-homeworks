using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        private int Age { get; set; }
        public Habit[] GoodHabits = new Habit[0];
        public Habit[] BadHabits = new Habit[0];
        public static User[] AllUsers = new User[0];
    }
}
