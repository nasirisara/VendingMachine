using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Food :Product 
    {
        public string Type { get; set; }

        public Food (string name, int price,string information,int productId, string type): base(name , price, information, productId)
        {
            Type = type;
        }

        public override string Examine()
        {
            return $"return name: {Name} - price: {Price } information:{Information }- productId:{ProductId} -Type:{ Type }";
        }

        public override string Use()
        {
            VendingMachinService vendingMachin = new VendingMachinService();
            foreach (Product product in vendingMachin.storage)
            {



                if (vendingMachin.Purchase(ProductId) != null)
                {
                    return $"Instruction:{Information}";

                }
            }
            return null;

        }
    }
   
}
