using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7SalesReport
{
    class Sale
    {
        public String Town { get; set; }
        public String Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {          
            SortedDictionary<string, double> townPrice = new SortedDictionary<string, double>();
            Sale sales = new Sale();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<String> inputLine = Console.ReadLine().Split().ToList();
                sales.Town = inputLine[0];
                sales.Product = inputLine[0];
                sales.Price = double.Parse(inputLine[2]);
                sales.Quantity = double.Parse(inputLine[3]);
                if (townPrice.ContainsKey(sales.Town))
                {
                    townPrice[sales.Town] += sales.TotalPrice;
                }
                else
                {
                    townPrice[sales.Town] = sales.TotalPrice;
                }
            }
            foreach (var town in townPrice)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
    }
}
