using System;
using System.Collections.Generic;
namespace Ex4SuperMarketDataBase
{
    class SuperMarketDataBase
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> stockandPrce = new Dictionary<string, double[]>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string stock = input[0];
                if (stock == "stocked")
                {
                    break;
                }
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);
                if (!stockandPrce.ContainsKey(stock))
                {
                    stockandPrce[stock] = new double[2];
                    stockandPrce[stock][0] = price;
                    stockandPrce[stock][1] = quantity;
                }
                else
                {
                    stockandPrce[stock][0] = price;
                    stockandPrce[stock][1] += quantity;
                }
            }
            double totalSum = 0;
            foreach (var stock in stockandPrce)
            {
                totalSum += stock.Value[0] * stock.Value[1];
                Console.WriteLine($"{stock.Key}: ${stock.Value[0]:f2} * {stock.Value[1]} = ${stock.Value[0]* stock.Value[1]:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalSum:f2}");
        }
    }
}
