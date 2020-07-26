using System;
using Hotel.Entities.Exception;

namespace Hotel.Entities
{
    class Reservation
    {
        public int RommNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime  CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int rommNumber, DateTime chekin, DateTime checkout)
        {
            if (checkout <= chekin)
            {
                throw new DomainException(" Check-out date must be after check-in date ");
            }
            RommNumber = rommNumber;
            CheckIn = chekin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn,DateTime checkOut)
        {
            DateTime now1 = DateTime.Now;
            Console.WriteLine("Error  :" + now1);

            if (checkIn < now1 || checkOut < now1)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException(" Check-out date must be after check-in date ");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;            
        }
        public override string ToString()
        {
            return " Room " + RommNumber
                + " check -in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check -out: " + CheckOut.ToString("dd/MM/yyyy")
                + " , " + Duration()+ " nights";
        }
    }
}