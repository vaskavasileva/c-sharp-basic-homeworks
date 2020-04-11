using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Entities
{
    public class FirstSession : Session
    {

        
        public static Ticket winner { get; set; }
        public static void GetFirstSessionWinner(Session session)
        {
            if (TicketsWithoutAPrice.Length >= 1)
            {
                var winnerIndex = new Random().Next(0, TicketsWithoutAPrice.Length - 1);
                winner = TicketsWithoutAPrice[winnerIndex];
                Console.WriteLine("The winner of the first session is " + winner.User.Name + ", who won a TV!");
            }
            
        }

        
    }
}
