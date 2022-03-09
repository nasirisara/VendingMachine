using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public interface IVending

    {
        void Purchase(int ProductId);

        List<string> ShowAll(List<AbstractProduct> productsList);
        string Details(string info);

        void InsertMoney();

        Dictionary<int, int> EndTransaction();



    }
}
