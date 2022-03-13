using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Drink : Product
    {
        public string Brand { get; set; }
        public Drink (string name, int price, string information,int productId, string brand) : base (name, price, information, productId)
        {
            Brand = brand;
        }

        public override string Examine()
        {
            return $"name: {Name} - price: {Price } information:{Information }- productId:{ProductId} brand:{ Brand}";
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
