using LotteryApp.Enums;
using LotteryApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Entities
{
    public class Ticket
    {


        public Ticket()
        {
            Combination = new int[7];
        }
        public int[] Combination { get; set; }
        public User User { get; set; }
        public Price Price { get; set; }
        public Ticket[] allTickets = new Ticket[0];

        public void AddToArrayTickets(Ticket ticket)
        {
            Array.Resize(ref allTickets, allTickets.Length + 1);
            allTickets[allTickets.Length - 1] = ticket;
        }


    }
}

