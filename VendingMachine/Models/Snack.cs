using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Snack : Product
    {
        public string Family { get; set; }
        public Snack (string name, int price,string information, int productId, string family): base(name, price, information, productId)
        {
            Family = family;
        }

        public override string Examine()
        {
            return $" return name: {Name} - price: {Price } information:{Information }- productId:{ProductId}- Family:{ Family }";
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
