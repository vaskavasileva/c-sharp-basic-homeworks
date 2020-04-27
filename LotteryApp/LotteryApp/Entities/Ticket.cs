﻿using LotteryApp.Enums;
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
        public User User { get; set; } = new User();
        public Price Price { get; set; } 

       

    }
}

