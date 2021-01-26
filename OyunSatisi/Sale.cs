using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class Sale : IEntity
    {
        public int SaleId { get; set; }
        public string Category { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public Customer CustomerBought { get; set; }
    }
}
