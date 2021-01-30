using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}