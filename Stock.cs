using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirm
{
    public class Stock
    {
        public Stock(string prodName, int quanity)
        {
            this.ProductName = prodName;
            this.Quantity = quanity;
        }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public static int SafetyStock = 500;
    }
}
