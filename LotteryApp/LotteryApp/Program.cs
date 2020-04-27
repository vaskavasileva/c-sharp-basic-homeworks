using LotteryApp.Entities;
using LotteryApp.Enums;
using LotteryApp.Helpers;
using System;

namespace LotteryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Igor Dzambazov");
            user1.SetAge(55);

            User user2 = new User("Vaska Vasileva");
            user2.SetAge(26);

            User user3 = new User("Petko Petkovski");
            user3.SetAge(35);

            User user4 = new User("Mitre Mitrevski");
            user4.SetAge(52);

            User user5 = new User("Mia Minovska");
            user5.SetAge(20);

            User user6 = new User("Daniela Ristevska");
            user6.SetAge(33);

            User user7 = new User("Darko Trajkov");
            user7.SetAge(78);

            User user8 = new User("Luka Dimitriev");
            user8.SetAge(18);

            User user9 = new User("Darijan Andreevski");
            user9.SetAge(62);

            User user10 = new User("Vojdan Trpkovski");
            user10.SetAge(29);


            Ticket ticket1 = new Ticket()
            {
                Combination = new int[] { 11, 23, 5, 34, 3, 16, 7 },
                User = user1
            };
            Session.AddToArrayTickets(ticket1);


            Ticket ticket2 = new Ticket()
            {
                Combination = new int[] { 18, 6, 32, 4, 27, 9, 23 },
                User = user2
            };
            Session.AddToArrayTickets(ticket2);


            Ticket ticket3 = new Ticket()
            {
                Combination = new int[] { 5, 14, 16, 8, 25, 29, 24 },
                User = user3
            };
            Session.AddToArrayTickets(ticket3);


            Ticket ticket4 = new Ticket()
            {
                Combination = new int[] { 4, 28, 17, 19, 25, 6, 3 },
                User = user4
            };
            Session.AddToArrayTickets(ticket4);


            Ticket ticket5 = new Ticket()
            {
                Combination = new int[] { 1, 15, 24, 25, 26, 36, 31 },
                User = user5
            };
            Session.AddToArrayTickets(ticket5);


            Ticket ticket6 = new Ticket()
            {
                Combination = new int[] { 2, 8, 9, 15, 28, 34, 1 },
                User = user6
            };
            Session.AddToArrayTickets(ticket6);


            Ticket ticket7 = new Ticket()
            {
                Combination = new int[] { 5, 4, 19, 18, 6, 32, 2 },
                User = user7
            };
            Session.AddToArrayTickets(ticket7);


            Ticket ticket8 = new Ticket()
            {
                Combination = new int[] { 9, 12, 18, 25, 26, 35, 4 },
                User = user8
            };
            Session.AddToArrayTickets(ticket8);


            Ticket ticket9 = new Ticket()
            {
                Combination = new int[] { 15, 18, 21, 25, 28, 31, 34 },
                User = user9
            };
            Session.AddToArrayTickets(ticket9);


            Ticket ticket10 = new Ticket()
            {
                Combination = new int[] { 3, 19, 35, 2, 7, 14, 6 },
                User = user10
            };
            Session.AddToArrayTickets(ticket10);


            Console.WriteLine("Do you want to add a new user(1) or start the session(2)? ");
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "1" || input == "2")
                {
                    break;
                }
                Console.WriteLine("You need to enter 1(new user) or 2(start session).");
                input = Console.ReadLine();

            }

            int.TryParse(input, out int answer);

            switch (answer)
            {
                case 1:
                    AddUserHelper.AddNewTicket();
                    break;

                case 2:
                    {
                        Session firstSession = new Session();
                        firstSession.StartSession();
                        firstSession.PrintWinningCombination();
                        Console.WriteLine("All users participating in the session are: ");
                        Session.Print();

                        SortingHelper.SortTickets(firstSession);
                        WinnersAnnouncement.AnnounceWinners(firstSession);

                        FirstSession.GetFirstSessionWinner(firstSession);
                        SecondSession.GetSecondSessionWinner(firstSession);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
