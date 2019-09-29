using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            string[] inputLine;

            Dictionary<string, Dictionary<string, Double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while ((inputLine = Console.ReadLine().Split(", "))[0] != "Revision")
            {
                string shop = inputLine[0];
                string product = inputLine[1];
                double price = double.Parse(inputLine[2]);
                var products = new Dictionary<string, double>();
                products.Add(product, price);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, products);
                }
                else
                {
                    shops[shop][product] = price;
                }
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine(shop.Key+"->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
