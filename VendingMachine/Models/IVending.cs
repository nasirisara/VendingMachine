using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public interface IVending
 
    {
            Product Purchase(int Id);

            List<Product> ShowAll();

            string Details(Product selctedproduct);

            void InsertMoney(int payment);

            Dictionary<int, int> EndTransaction();



    }


    
}
