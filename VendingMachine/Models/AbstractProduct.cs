using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public  abstract class AbstractProduct
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Information { get; set; }

        public int ProductId { get; set; }


        public AbstractProduct (string name)
        {
            Name = name;

        }

        public AbstractProduct(string name, int price) : this (name)
        {
            Price = price;

        }
        public AbstractProduct   (string name, int price, string information ): this (name, price)
        {
            Information = information;
        }
        public AbstractProduct(string name, int price, string information, int productId) : this(name, price, information)
        {
            ProductId = productId;
        }
        public abstract string Examine();
        public abstract string Use();


    }
}
