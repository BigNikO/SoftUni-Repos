namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string newMake = Console.ReadLine();
            string newModel = Console.ReadLine();
            int newYear = int.Parse(Console.ReadLine());
            double newFuelQuantity = double.Parse(Console.ReadLine());
            double newFuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(newMake, newModel, newYear);
            Car thirdCar = new Car(newMake, newModel, newYear, newFuelQuantity, newFuelConsumption);

            Console.WriteLine(firstCar.CarInformation);
            Console.WriteLine(secondCar.CarInformation);
            Console.WriteLine(thirdCar.CarInformation);
            Console.WriteLine(thirdCar.WhoAmI());

            var carTires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };

            var carEngine = new Engine(560, 6300);
            var newCar = new Car("Lamborghini", "Urus", 2010, 250, 9, carEngine, carTires);

            string command = Console.ReadLine();
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            while (command != "No more tires")
            {
                var tireProperties = (command.Split(" ", StringSplitOptions.RemoveEmptyEntries));

                var currentTires = new Tire[4];
                for (int i = 0; i < tireProperties.Length; i += 2)
                {
                    int year = int.Parse(tireProperties[i]);
                    double pressure = double.Parse(tireProperties[i + 1]);
                    var tire = new Tire(year, pressure);
                    currentTires[i / 2] = tire;
                }
                tires.Add(currentTires);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "Engines done")
            {
                var engineProperties = (command.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                int horsePowers = int.Parse(engineProperties[0]);
                double cubicCapacity = double.Parse(engineProperties[1]);
                var engine = new Engine(horsePowers, cubicCapacity);
                engines.Add(engine);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "Show special")
            {
                var tireProperties = (command.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                string make = tireProperties[0];
                string model = tireProperties[1];
                int year = int.Parse(tireProperties[2]);
                int fuelQuantity = int.Parse(tireProperties[3]);
                int fuelConsumption = int.Parse(tireProperties[4]);
                int engineIndex = int.Parse(tireProperties[5]);
                int tireIndex = int.Parse(tireProperties[6]);
                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                cars.Add(car);
                command = Console.ReadLine();
            }

            var specialCars = cars.Where(c => c.Year >= 2017)
                 .Where(c => c.Engine.HorsePower >= 330)
                 .Where(c => c.Tires.Select(t => t.Pressure).Sum() >= 9 && c.Tires.Select(t => t.Pressure).Sum() <= 10).ToList();

            foreach (var car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
