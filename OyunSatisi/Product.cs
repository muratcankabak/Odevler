using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
