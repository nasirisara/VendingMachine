using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class ProductSequencer
    {
        private static int idCounter = 0;

        public static int NextProductId()
        {
            return ++idCounter;
        }

        public static void Clear()
        {
            idCounter = 0;
        }
    }
}



    



