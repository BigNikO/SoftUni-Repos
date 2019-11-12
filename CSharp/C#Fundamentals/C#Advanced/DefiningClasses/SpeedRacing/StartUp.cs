
namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var carDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = carDetails[0];
                var fuelAmount = double.Parse(carDetails[1]);
                var fuelConsumptionPerKilometer = double.Parse(carDetails[2]);

                var car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
                cars.Add(car);
            }

            var command = Console.ReadLine();
            while (command != "End")
            {
                string[] driveDetails = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = driveDetails[1];
                var distance = double.Parse(driveDetails[2]);
                cars.Find(x => x.Model == model).Drive(distance);
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
