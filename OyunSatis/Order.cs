using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
