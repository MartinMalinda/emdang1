﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Reservation : IReservation
    {
        public string Code { get; set; }
        public string Dow { get; set; }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }


        public Reservation()
        {
            Code = GetCodeBooking();
            Dow = GetDowBooking();
        }

    public string GetCodeBooking()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] code = new char[8];
            //Random random = new Random();

            for (int i = 0; i < code.Length; i++)
            {
                code[i] = chars[RandomNumber(0, chars.Length)];
            }

            string finalCode = new string(code);
            return finalCode;
        }

        public string GetDowBooking()
        {
            string[] dow = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            //Random random = new Random();
            //string finalDow = dow[random.Next(0,dow.Length)];
            string finalDow = dow[RandomNumber(0, dow.Length)];

            return finalDow;
        }
    }
}
