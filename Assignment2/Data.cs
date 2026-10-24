using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    internal class Data
    {
        public static List<Product> ProductList = new List<Product>
    {
        new Product { ProductID = 1,  ProductName = "Chai",                    Category = "Beverages",    UnitPrice = 18.00m, UnitsInStock = 39 },
        new Product { ProductID = 2,  ProductName = "Chang",                   Category = "Beverages",    UnitPrice = 19.00m, UnitsInStock = 17 },
        new Product { ProductID = 3,  ProductName = "Aniseed Syrup",           Category = "Condiments",   UnitPrice = 10.00m, UnitsInStock = 13 },
        new Product { ProductID = 18, ProductName = "Carnarvon Tigers",        Category = "Seafood",      UnitPrice = 62.50m, UnitsInStock = 42 },
    };

        public static List<Customer> CustomerList = new List<Customer>
    {
        new Customer { CustomerID = "ALFKI", CompanyName = "Alfreds Futterkiste", Country = "Germany",
            Orders = new List<Order> { new Order { OrderID = 1, Total = 814.50m }, new Order { OrderID = 2, Total = 878.00m } } },
        new Customer { CustomerID = "ANATR", CompanyName = "Ana Trujillo Emparedados", Country = "Mexico",
            Orders = new List<Order> { new Order { OrderID = 3, Total = 514.40m } } },
        new Customer { CustomerID = "BLAUS", CompanyName = "Blauer See Delikatessen", Country = "Germany",
            Orders = new List<Order> { new Order { OrderID = 4, Total = 330.00m } } },
        new Customer { CustomerID = "BONAP", CompanyName = "Bon app'", Country = "France",
            Orders = new List<Order> { new Order { OrderID = 5, Total = 1200.00m } } },
        new Customer { CustomerID = "AROUT", CompanyName = "Around the Horn", Country = "UK",
            Orders = new List<Order> { new Order { OrderID = 6, Total = 480.00m }, new Order { OrderID = 7, Total = 120.00m } } },
    };
    }
}
