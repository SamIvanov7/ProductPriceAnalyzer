using System;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product("MacBook", 2000, "Electronics"),
                new Product("Iphone", 1500, "Electronics"),
                new Product("Apple Vision Pro", 3500, "Electronics"),
                new Product("Jeans", 40, "Clothing"),
                new Product("T-Shirt", 20, "Clothing"),
                new Product("Belt", 10, "Clothing"),
            };

            var averagePrices = ProductCollection.CalculateAveragePriceByCategory(products);

            Console.WriteLine("Average Price by Category:");
            foreach (var category in averagePrices)
            {
                Console.WriteLine($"{category.Key}: ${category.Value:F2}");
            }
        }
    }
}
