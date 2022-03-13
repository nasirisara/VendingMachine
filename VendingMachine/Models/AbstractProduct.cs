using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public  abstract class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Information { get; set; }

        public int ProductId { get; set; }


        public Product (string name)
        {
            Name = name;

        }

        public Product(string name, int price) : this (name)
        {
            Price = price;

        }
        public Product   (string name, int price, string information ): this (name, price)
        {
            Information = information;
        }
        public Product(string name, int price, string information, int productId) : this(name, price, information)
        {
            ProductId = productId;
        }
        public abstract string Examine();
        public abstract string Use();


    }
}
