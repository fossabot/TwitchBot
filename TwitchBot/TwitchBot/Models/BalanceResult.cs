﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Models
{
    public class BalanceResult
    {
        public string ActionType { get; set; }
        public string Username { get; set; }
        public int Wallet { get; set; }
    }
}
