using System;
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
        public string Currency { get; set; } = "Zebra";

        public BankAccount(string name, double balance, string animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }
    }
}
