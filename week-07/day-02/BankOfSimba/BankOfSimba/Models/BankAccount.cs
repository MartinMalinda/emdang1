﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; } = "CZK";

        public BankAccount(string name, double balance, string animalType, string status)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            Status = status;
        }
    }
}
