using System;
using System.Collections.Generic;

namespace ExercicoContrato.Emtities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date{ get; set; }
        public Double TotalValue { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments =new List<Installment>();

        }

        public void AddInstallment(Installment installment)
        {

            Installments.Add(installment);

        }
    }
}
