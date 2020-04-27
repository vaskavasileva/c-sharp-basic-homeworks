using LotteryApp.Entities;
using LotteryApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Helpers
{
    public class WinnersAnnouncement
    {
        public static void AnnounceWinners(Session session)
        {
            
            foreach (var ticket in Session.WonTickets)
            {
                Console.WriteLine("The user " + ticket.User.Name + " won a " + ticket.Price + ".");
            }
        }
    }
}