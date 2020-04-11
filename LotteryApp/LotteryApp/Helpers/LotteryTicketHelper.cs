using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryApp.Helpers
{
    public class LotteryTicketHelper
    {
        public static int CheckTicket(int[]winnigCombination, int[]ticketNumbers)
        {
            var counter = 0;
            foreach (var number in ticketNumbers)
            {
                foreach (var num in winnigCombination)
                {
                    if (number == num)
                    {
                        counter++;
                    }
                }

            }
            return counter;
        }
    }
}
