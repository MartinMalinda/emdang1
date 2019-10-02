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
            Console.WriteLine(reservation.GetCodeBooking());



            Console.ReadLine();
        }
    }
}
