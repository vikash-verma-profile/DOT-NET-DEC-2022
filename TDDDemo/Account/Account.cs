using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Account : IAccount
    {
        double _balance;
        public double CurrentBalance { get { return _balance; } }

        public double Deposit(double amount)
        {
            if (amount>0)
            {
                _balance += amount;
                return _balance;
            }
            else
            {
                throw new ArgumentException("Invalid Deposit Amount!");
            }
        }

        public double Withdraw(double amount)
        {
            if (amount>0 && _balance>=amount)
            {
                _balance-= amount;
            }
            else
            {
                throw new ArgumentException("No balance to Withdraw!");
            }
            return _balance;
        }

    }
}
