using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Snack : AbstractProduct
    {
        public string Family { get; set; }
        public Snack (string name, int price,string information, int productId, string family): base(name, price, information, productId)
        {
            Family = family;
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
