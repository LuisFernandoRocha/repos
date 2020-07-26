using Conta.Emtities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Emtities
{
    class Account
    {
        public int Nunber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int nunber, string holder, double balance, double withdrawLimit)
        {
            Nunber = nunber;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)

        {

            Balance += amount;

        }
        public void Withdraw(double amount)

        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;

        }
    }
}
