using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Drink : AbstractProduct
    {
        public string Brand { get; set; }
        public Drink (string name, int price, string information,int productId, string brand) : base (name, price, information, productId)
        {
            Brand = brand;
        }

        public override string Examine()
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
