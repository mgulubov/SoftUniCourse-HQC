using Orders.Models;

namespace Orders
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Interfaces;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            IDataMapper dataMapper = new DataMapper();

            IEnumerable<ICategory> categories = dataMapper.GetAllCategories();
            IEnumerable<IProduct> products = dataMapper.GetAllProducts();
            IEnumerable<IOrder> orders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            IEnumerable<string> fiveMostExpensiveProducts = GetNamesOfMostExpensiveProducts(products, 5);

            Console.WriteLine(string.Join(Environment.NewLine, fiveMostExpensiveProducts));
            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProductsInEachCategory = products
                .GroupBy(p => p.CategoryId)
                .Select(grp => new { Category = categories.First(c => c.Id == grp.Key).Name, Count = grp.Count() })
                .ToList();
            foreach (var item in numberOfProductsInEachCategory)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var fiveTopOrders = orders
                .GroupBy(o => o.ProductId)
                .Select(grp => new { Product = products.First(p => p.Id == grp.Key).Name, Quantities = grp.Sum(grpgrp => grpgrp.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in fiveTopOrders)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(o => o.ProductId)
                .Select(g => new { catId = products.First(p => p.Id == g.Key).CategoryId, price = products.First(p => p.Id == g.Key).UnitPrice, quantity = g.Sum(p => p.Quantity) })
                .GroupBy(gg => gg.catId)
                .Select(grp => new { category_name = categories.First(c => c.Id == grp.Key).Name, total_quantity = grp.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.category_name, mostProfitableCategory.total_quantity);
        }

        private static IEnumerable<string> GetNamesOfMostExpensiveProducts(
            IEnumerable<IProduct> products, 
            int takeCount)
        {
            return products
                .OrderByDescending(p => p.UnitPrice)
                .Take(takeCount)
                .Select(p => p.Name);
        }
    }
}
