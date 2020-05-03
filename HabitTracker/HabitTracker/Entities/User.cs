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
        public List<Habit> GoodHabits { get; set; } = new List<Habit>();
        public List<Habit> BadHabits { get; set; } = new List<Habit>();
        public static List<User> AllUsers { get; set; } = new List<User>();

        public static void SetAge(User user)
        {
            var thisTime = DateTime.Today;
            user.Age = user.DateOfBirth.Year - thisTime.Year;
        }
    }
}
