using Estacionamento.Emtities;
using System;
using System.Globalization;
using Estacionamento.Services;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price e per hour: ");
            Double hour  = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            Double day = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start,finish,new Vehicle(model));

            RentalServices rentalServices = new RentalServices(hour,day);

            rentalServices.ProcessInvoice(carRental);

            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
