using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitPrice { get; set; }
    }
}
