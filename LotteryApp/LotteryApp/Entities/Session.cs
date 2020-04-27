using System;
using System.Collections.Generic;
using System.Text;
using LottoServices;
using LotteryApp.Enums;
using LotteryApp.Helpers;

namespace LotteryApp.Entities
{
    public class Session 
    {

        static int counter = 0;
        public Session()
        {
            counter += 1;
            SessionID = counter;
            WinningCombination = new int[7];
        }
        private int SessionID { get; set; }

        public int[] WinningCombination { get; set; }

        public static Ticket[] Tickets = new Ticket[0];

        public static void AddToArrayTickets(Ticket ticket)
        {
            Array.Resize(ref Tickets, Tickets.Length + 1);
            Tickets[Tickets.Length - 1] = ticket;
        }

        public void StartSession()
        {
            WinningCombination = LottoNumbersGenerator.GenerateNumbers();
        }

        public void PrintWinningCombination()
        {
            Console.WriteLine("The winning combination is: ");
            for (int i = 0; i < WinningCombination.Length; i++)
            {
                Console.Write(WinningCombination[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Print()
        {
            foreach (var ticket in Tickets)
            {
                Console.WriteLine(ticket.User.Name);
            }
        }
        public static Ticket[] TicketsWithoutAPrice = Array.Empty<Ticket>();

        public static Ticket[] TicketsWithTwoMatches = new Ticket[0];

        public static Ticket[] WonTickets = new Ticket[0];
    }
}
