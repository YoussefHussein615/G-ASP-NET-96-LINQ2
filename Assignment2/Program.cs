using Assignment2;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;

public class Program
{
    static void Header(string title) => Console.WriteLine($"\n{title} ");

    static void Main()
    {
        var ProductList = Data.ProductList;
        var CustomerList = Data.CustomerList;

        // Q1
        Header("Q1");
        foreach (var p in ProductList.OrderByDescending(p => p.UnitPrice).Take(3))
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

        // Q2
        Header("Q2");
        int page = 2, pageSize = 5;
        foreach (var p in ProductList.Skip((page - 1) * pageSize).Take(pageSize))
            Console.WriteLine(p.ProductName);

        // Q3
        Header("Q3");
        var cheap = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
        foreach (var p in cheap)
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

        // Q4
        Header("Q4");
        bool allSeafoodInStock = ProductList
            .Where(p => p.Category == "Seafood")
            .All(p => p.UnitsInStock > 0);
        Console.WriteLine($"All Seafood in stock? {allSeafoodInStock}");

        // Q5
        Header("Q5");
        int[] ids = { 3, 9, 13, 18 };
        Console.WriteLine($"Contains 9? {ids.Contains(9)}");

        // Q6
        Header("Q6");
        foreach (var g in ProductList.GroupBy(p => p.Category))
        {
            Console.WriteLine($"{g.Key} ({g.Count()} products)");
            foreach (var p in g)
                Console.WriteLine($"   {p.ProductName}");
        }

        // Q7
        Header("Q7");
        var namesByCategory = ProductList
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });
        foreach (var g in namesByCategory)
            Console.WriteLine($"{g.Category}: {string.Join(", ", g.Names)}");

        // Q8
        Header("Q8");
        var bigCategories = ProductList
            .GroupBy(p => p.Category)
            .Where(g => g.Count() > 3)
            .Select(g => g.Key);
        foreach (var c in bigCategories)
            Console.WriteLine(c);

        // Q9
        Header("Q9");
        var byCountry = from c in CustomerList
                        group c by c.Country into g
                        select new
                        {
                            Country = g.Key,
                            Count = g.Count(),
                            TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
                        };
        foreach (var x in byCountry)
            Console.WriteLine($"{x.Country} | Count = {x.Count} | TotalOrderValue = {x.TotalOrderValue}");

        // Q10
        Header("Q10");
        Console.WriteLine($"Total units in stock: {ProductList.Sum(p => p.UnitsInStock)}");

        // Q11
        Header("Q11");
        Console.WriteLine($"Cheapest: {ProductList.Min(p => p.UnitPrice)}");
        Console.WriteLine($"Most expensive: {ProductList.Max(p => p.UnitPrice)}");

        // Q12
        Header("Q12");
        foreach (var c in ProductList.Select(p => p.Category).Distinct())
            Console.WriteLine(c);

        // Q13
        Header("Q13");
        int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        int[] setB = { 3, 6, 9, 12, 15, 13 };
        Console.WriteLine(string.Join(", ", setA.Except(setB)));

        // Q14
        Header("Q14");
        string[] list1 = { "Germany", "France", "UK", "Spain" };
        string[] list2 = { "france", "SPAIN", "Italy" };
        Console.WriteLine(string.Join(", ", list1.Except(list2, StringComparer.OrdinalIgnoreCase)));

        // Q15
        Header("Q15");
        Dictionary<int, Product> dict = ProductList.ToDictionary(p => p.ProductID);
        Console.WriteLine(dict[18]);

        // Q16
        Header("Q16");
        Console.WriteLine(ProductList.First(p => p.UnitPrice > 50));

        // Q17
        Header("Q17");
        Product expensive = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
        Console.WriteLine(expensive == null ? "null (no product found)" : expensive.ToString());

        // Q18
        Header("Q18");
        foreach (var line in Enumerable.Range(1, 10).Select(i => $"7 x {i} = {7 * i}"))
            Console.WriteLine(line);

        // Q19
        Header("Q19");
        Console.WriteLine(string.Join(", ", Enumerable.Range(1, 30).Where(n => n % 2 == 0)));

        // Q20
        Header("Q20");
        var combined = ProductList.Select(p => p.ProductName).Take(3)
            .Concat(CustomerList.Select(c => c.CompanyName).Take(3));
        foreach (var s in combined)
            Console.WriteLine(s);

        // Q21
        Header("Q21");
        var pairs = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
        foreach (var s in pairs)
            Console.WriteLine(s);
    }
}