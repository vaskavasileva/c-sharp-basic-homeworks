using System;
using System.Collections.Generic;
using System.Text;
using LottoServices;
using LotteryApp.Enums;
using LotteryApp.Helpers;

namespace LotteryApp.Entities
{
    public class Session : Ticket
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

        public Ticket[] Tickets { get; set; }


        public void StartSession()
        {
            WinningCombination = LottoNumbersGenerator.GenerateNumbers();
        }

        public static Ticket[] TicketWithTwoWins = new Ticket[0];
        public static Ticket[] TicketsWithoutAPrice = new Ticket[0];
        public static Ticket[] WonTV = new Ticket[0];
        public static Ticket[] WonVacation = new Ticket[0];
        public static Ticket[] WonMotorBike = new Ticket[0];
        public static Ticket[] WonCar = new Ticket[0];

        public void SortTickets(Session session)
        {
            foreach (var ticket in allTickets)
            {
                var matches = LotteryTicketHelper.CheckTicket(session.WinningCombination, ticket.Combination);
                switch (matches)
                {
                    case (int)Price.TV:
                        {
                            Array.Resize(ref WonTV, WonTV.Length + 1);
                            WonTV[WonTV.Length - 1] = ticket;
                        }
                        break;
                    case (int)Price.Vacation:
                        {
                            Array.Resize(ref WonVacation, WonVacation.Length + 1);
                            WonVacation[WonVacation.Length - 1] = ticket;
                        }
                        break;
                    case (int)Price.MotorBike:
                        {
                            Array.Resize(ref WonMotorBike, WonMotorBike.Length + 1);
                            WonMotorBike[WonMotorBike.Length - 1] = ticket;
                        }
                        break;
                    case (int)Price.Car:
                        {
                            Array.Resize(ref WonCar, WonCar.Length + 1);
                            WonCar[WonCar.Length - 1] = ticket;
                        }
                        break;

                    default:
 
                            break;


                }

                if (matches < 4)
                {
                    Array.Resize(ref TicketsWithoutAPrice, TicketsWithoutAPrice.Length + 1);
                    TicketsWithoutAPrice[TicketsWithoutAPrice.Length - 1] = ticket;
                }

                if (matches == 2)
                {
                    Array.Resize(ref TicketWithTwoWins, TicketWithTwoWins.Length + 1);
                    TicketWithTwoWins[TicketWithTwoWins.Length - 1] = ticket;
                }
            }
                                    
        }

        public static void AnnounceWinners(Session session)
        {
            if (WonTV.Length >= 1)
            {
                Console.WriteLine("The users that had 4 matches and won a TV are: ");
                foreach (var ticket in WonTV)
                {
                    Console.WriteLine(ticket.User.Name);
                }
            }

            if (WonVacation.Length >= 1)
            {
                Console.WriteLine("The users that had 5 matches and won a Vacation are: ");
                foreach (var ticket in WonVacation)
                {
                    Console.WriteLine(ticket.User.Name);
                }
            }

            if (WonMotorBike.Length >= 1)
            {
                Console.WriteLine("The users that had 6 matches and won a Motorbike are: ");
                foreach (var ticket in WonMotorBike)
                {
                    Console.WriteLine(ticket.User.Name);
                }
            }

            if (WonCar.Length >= 1)
            {
                Console.WriteLine("The users that had 7 matches and won a Car are: ");
                foreach (var ticket in WonCar)
                {
                    Console.WriteLine(ticket.User.Name);
                }
            }
        }

    }
}
