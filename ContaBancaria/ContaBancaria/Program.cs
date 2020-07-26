using System;
using System.Collections.Generic;
using System.Globalization;
using ContaBancaria.Entities;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "ALEX", 500.0,0.01));
            list.Add(new BusinessAccount(1002, "mARIA", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "bOB", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "ANNA", 500.0, 500.0));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("TOTAL BALANCE: "+sum.ToString("F2", CultureInfo.InvariantCulture) );

            foreach (Account acc in list)
            {
             acc.Whitdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account: " 
                    + acc.Number + "; "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
