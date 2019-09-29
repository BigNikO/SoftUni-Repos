using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRace
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                Car car = new Car();
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int fuelAmount = int.Parse(carInfo[1]);
                decimal fuelConsumption = decimal.Parse(carInfo[2]);
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumption = fuelConsumption;
                cars.Add(car);
            }

            string carDriveInfo;

            while ((carDriveInfo = Console.ReadLine()) != "End")
            {
                string model = carDriveInfo.Split()[1];
                int amountOfDistance = int.Parse(carDriveInfo.Split()[2]);
                if (cars.Select(x => x.Model).ToList().Contains(model))
                {
                    Car currentModel = cars
                        .Where(x => x.Model == model)
                        .FirstOrDefault();
                    if (!currentModel.CanTravelTheDistance(amountOfDistance))
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {(car.FuelAmount - car.FuelConsumption * car.TravelledDistance):F2} {car.TravelledDistance}");
            }
        }
    }
}
