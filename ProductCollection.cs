using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class ProductCollection
    {
        public static Dictionary<string, double> CalculateAveragePriceByCategory(IEnumerable<Product> products)
        {
            return products
                .GroupBy(p => p.Category)
                .ToDictionary(group => group.Key, group => group.Average(p => p.Price));
        }
    }
}
