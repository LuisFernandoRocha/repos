using Estacionamento.Emtities;
using System;

namespace Estacionamento.Services
{
    class RentalServices
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private BrazilTaxSercice _brazilTaxSercice = new BrazilTaxSercice();
        public RentalServices(double pricePerHour, double preicePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = preicePerDay;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0){
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);//arendonda a hora pra cima
            }
            else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxSercice.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment,tax);
        }

        
    }
}
