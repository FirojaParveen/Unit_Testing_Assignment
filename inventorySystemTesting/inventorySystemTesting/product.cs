using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace inventorySystemTesting
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public string Type;

        public Product(string Name, double Price, int Quantity, string Type)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Type = Type;
        }

    }

}


