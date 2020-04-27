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
            if (TicketsWithTwoMatches.Length != 0)
            {
                var winnerIndex = new Random().Next(0, TicketsWithTwoMatches.Length - 1);
                secondSessionWinner = TicketsWithTwoMatches[winnerIndex];
                Console.WriteLine("The winner of the second session is " + secondSessionWinner.User.Name + ", who won a Vacation!");
            }
            
           
        }
    }
}
