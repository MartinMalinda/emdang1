﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    interface IReservation
    {
        string GetDowBooking();
        string GetCodeBooking();

        //string[] dow { get; set; }
    }
}
