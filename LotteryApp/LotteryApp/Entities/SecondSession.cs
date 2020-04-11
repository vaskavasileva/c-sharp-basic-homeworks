using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Entities
{
    public class SecondSession : Session
    {
        public static Ticket secondSessionWinner { get; set; }
        public static void GetSecondSessionWinner(Session session)
        {
            if (TicketWithTwoWins.Length != 0)
            {
                var winnerIndex = new Random().Next(0, TicketWithTwoWins.Length - 1);
                secondSessionWinner = TicketWithTwoWins[winnerIndex];
                Console.WriteLine("The winner of the second session is " + secondSessionWinner.User.Name + ", who won a Vacation!");
            }

            else
            {
                Console.WriteLine("No user had 2 wins, so no user gets the price Vacation!");
            }
            
        }
    }
}
