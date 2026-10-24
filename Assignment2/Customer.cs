using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public List<Order> Orders { get; set; }
    }
}
