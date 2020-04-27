using LotteryApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Helpers
{
    public class AddUserHelper
    {
        public static void AddNewTicket()
        {
            User.BuyTicket();
            var ticket = new Ticket();

            Console.Write("Please enter a name for the user: ");
            ticket.User.Name = Console.ReadLine();

            Console.WriteLine("Please enter the age of the user: ");
            
            while (true)
            {
                var input = Console.ReadLine();
                int.TryParse(input, out int age);
                if (age >= 18)
                {
                    ticket.User.SetAge(age);
                    break;
                }

                Console.WriteLine("Please enter a valid age!");
                input = Console.ReadLine();
            }

            Console.WriteLine("Please enter your combination of 7 numbers from 1 to 36");
            
                for (int i  = 0; i  < ticket.Combination.Length; i ++)
                {
                    var input = Console.ReadLine();
                    int.TryParse(input, out int number);
                    if (number >= 1 && number <= 36)
                    {
                        ticket.Combination[i] = number;
                        break;
                    }

                    Console.WriteLine("Please enter a valid number!");
                    input = Console.ReadLine();
                }
            Session.AddToArrayTickets(ticket);
        }
    }
}
