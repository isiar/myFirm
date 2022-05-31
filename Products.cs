using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirm
{
   public class Products
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Quantity;
        public double Price { get; set; }
      

        public void FixPrice(double price)
        {
            if (price < 0)
            {
                throw new Exception("Please set a price! ");
            }
            this.Price = price;
        }

    }
}
