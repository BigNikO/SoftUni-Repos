namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                Car car = new Car(Console.ReadLine());
                cars.Add(car);
            }
            var cargoType = Console.ReadLine();
            var cargoTypeCars = cars.Where(c => c.Cargo.Type == cargoType);
            var result = cargoType == "fragile"
                ? cargoTypeCars.Where(c => c.Tires.Where(x => x.Pressure < 1).ToArray().Length > 0)
                : cargoTypeCars.Where(c => c.Engine.Power > 250);

            Console.WriteLine(String.Join(Environment.NewLine, result.Select(x => x.Model)));
        }
    }
}
