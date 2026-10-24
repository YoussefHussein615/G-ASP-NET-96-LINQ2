using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString() =>
            $"ID={ProductID}, {ProductName}, {Category}, Price={UnitPrice}, Stock={UnitsInStock}";
    }
}
