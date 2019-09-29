using System;

namespace Labo11PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());
            for (int i = 1; i < numberOfPrices; i++)
            {
                double currentPrice = double.Parse (Console.ReadLine());
                double percent = percentDifference (previousPrice, currentPrice);
                bool differenceCheck = checkDifference(threshold, percent);
                string result = Get(currentPrice, previousPrice, percent, differenceCheck);
                Console.WriteLine(result);
                previousPrice = currentPrice;
            }
            
        }
        static string Get(double currentPrice, double firstPrice, double difference, bool differenceCheck)
        {
            string result = "";
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!differenceCheck)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, difference*100);
            }
            else if (differenceCheck && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, difference*100);
            }
            else if (differenceCheck && (difference < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, difference*100);
            return result;
        }
        static bool checkDifference(double threshold, double percent)
        {
            if (Math.Abs(threshold) <= Math.Abs(percent))
            {
                return true;
            }
                return false;     
        }
        static double percentDifference(double previousPrice, double currentPrice)
        {
            double newPrice = (currentPrice - previousPrice) / previousPrice;
            return newPrice;
        }
    }
}

