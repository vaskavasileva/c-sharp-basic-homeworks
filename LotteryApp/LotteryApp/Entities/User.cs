using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Entities
{
    public class User
    {
        public User()
        {

        }
        public User(string name)
        {
            Name = name;
        }

        public  string Name { get; set; }
        private int Age { get; set; }

        public static void BuyTicket()
        {
            Console.WriteLine("You got a new ticket");
        }


        public void SetAge(int age)
        {
            if (age < 18)
                Console.WriteLine("Not allowed for users under age of 18");

            else Age = age;
        }
    }
}
