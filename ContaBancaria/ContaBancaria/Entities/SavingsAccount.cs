namespace ContaBancaria.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount ()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)

            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Whitdraw(double amount)
        {
            //Balance -= amount;
            base.Whitdraw(amount); 
            Balance -= 2.0;
        }
    }
}
