using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirm
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime DatePlaced { get; set; }

        public List<OrderLine> Lines { get; set; }

        public Address Destination { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double Total { get; set; }

        public Client Client { get; set; }
    }
}
