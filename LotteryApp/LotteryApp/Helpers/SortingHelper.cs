using System;
using System.Collections.Generic;
using System.Text;
using LotteryApp.Entities;
using LotteryApp.Enums;

namespace LotteryApp.Helpers
{
    public class SortingHelper
    {
        public static void SortTickets(Session session)
        {
            foreach (var ticket in Session.Tickets)
            {
                var matches = LotteryTicketHelper.CheckTicket(session.WinningCombination, ticket.Combination);
                if (matches == (int)Price.TV)
                {
                    ticket.Price = Price.TV;
                }
                if (matches == (int)Price.Vacation)
                {
                    ticket.Price = Price.Vacation;
                }
                if (matches == (int)Price.MotorBike)
                {
                    ticket.Price = Price.MotorBike;
                }
                if (matches == (int)Price.Car)
                {
                    ticket.Price = Price.Car;
                }
                if (matches == 2)
                {
                    Array.Resize(ref Session.TicketsWithTwoMatches, Session.TicketsWithTwoMatches.Length + 1);
                    Session.TicketsWithTwoMatches[Session.TicketsWithTwoMatches.Length - 1] = ticket;
                }
                if (matches < 4)
                {
                    Array.Resize(ref Session.TicketsWithoutAPrice, Session.TicketsWithoutAPrice.Length + 1);
                    Session.TicketsWithoutAPrice[Session.TicketsWithoutAPrice.Length - 1] = ticket;
                }
                if (matches >= 4)
                {
                    Array.Resize(ref Session.WonTickets, Session.WonTickets.Length + 1);
                    Session.WonTickets[Session.WonTickets.Length - 1] = ticket;
                }
                
            }
        }
    }
}
