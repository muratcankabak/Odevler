using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class Customer : IPerson
    {
        public int CustomerId { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
