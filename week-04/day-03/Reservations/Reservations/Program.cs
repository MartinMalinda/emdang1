using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservation reservation = new Reservation();
            Reservation reservationTwo = new Reservation();
            Reservation reservationThree = new Reservation();
            Reservation reservationFour = new Reservation();
            Reservation reservationFive = new Reservation();


            Console.WriteLine("Booking# " + reservation.GetCodeBooking() + " for the " + reservation.GetDowBooking());
            Console.WriteLine("Booking# " + reservationTwo.GetCodeBooking() + " for the " + reservationTwo.GetDowBooking());
            Console.WriteLine("Booking# " + reservationThree.GetCodeBooking() + " for the " + reservationThree.GetDowBooking());
            Console.WriteLine("Booking# " + reservationFour.GetCodeBooking() + " for the " + reservationFour.GetDowBooking());
            Console.WriteLine("Booking# " + reservationFive.GetCodeBooking() + " for the " + reservationFive.GetDowBooking());




            Console.ReadLine();
        }
    }
}
