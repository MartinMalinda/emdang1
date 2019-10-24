using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class ShopItem
    {
        private string name;
        private string description;
        private double price;
        private int quantityOfStock;

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityOfStock { get; set; }

        public ShopItem(string name, string description, double price, int quantityOfStock)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityOfStock = quantityOfStock;
        }
    }

    
}
