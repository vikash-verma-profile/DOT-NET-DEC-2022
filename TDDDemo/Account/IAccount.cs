﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public interface IAccount
    {
        double CurrentBalance { get; }
        double Deposit(double amount);
        double Withdraw(double amount);
    }
}
