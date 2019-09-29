using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public string Colour { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();
            List<Vehicle> vehicles = new List<Vehicle>();

            List<string> models = new List<string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                Vehicle vehicle = new Vehicle() { Type = input[0], Model = input[1], Colour = input[2], Horsepower = int.Parse(input[3]) };
                if (input[0].ToLower() == "car")
                {
                    vehicle.Type = "Car";
                    cars.Add(vehicle);
                }
                else
                {
                    vehicle.Type = "Truck";
                    trucks.Add(vehicle);
                }
                vehicles.Add(vehicle);
            }
            while (true)
            {
                string checkModel = Console.ReadLine();
                if (checkModel == "Close the Catalogue")
                {
                    break;
                }
                foreach (var vehicle in vehicles)
                {
                    if (checkModel == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Colour}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
            }
            try
            {
                Console.WriteLine($"Cars have average horsepower of: {cars.Average(x => x.Horsepower):f2}.");
            }
            catch 
            {
                Console.WriteLine($"Cars have average horsepower of: {0.00:f2}.");
            }
            try
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucks.Average(x => x.Horsepower):f2}.");
            }
            catch 
            {
                Console.WriteLine($"Trucks have average horsepower of: {0.00:f2}.");
            }
        }
    }
}

