using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex4Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d{2}\.\d{1,2})([A-z]+)\|";
            Dictionary<string, string> cityConditions = new Dictionary<string, string>();
            Dictionary<string, double> cityTeperatures = new Dictionary<string, double>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                Match checkWeather = Regex.Match(input, pattern);              
                if (checkWeather.Success)
                {
                    string city = checkWeather.Groups[1].Value;
                    double temperature = double.Parse(checkWeather.Groups[2].Value);
                    string condition = checkWeather.Groups[3].Value.Trim('|');                   
                    cityTeperatures[city] = temperature;
                    cityConditions[city] = condition;
                }              
            }
            foreach (var city in cityTeperatures.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{city.Key} => {city.Value:f2} => { cityConditions[city.Key]}");
            }
        }
    }
}
