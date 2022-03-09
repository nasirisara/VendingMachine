using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Food : AbstractProduct 
    {
        public string Type { get; set; }

        public Food (string name, int price,string information,int productId, string type): base(name , price, information, productId)
        {
            Type = type;
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
