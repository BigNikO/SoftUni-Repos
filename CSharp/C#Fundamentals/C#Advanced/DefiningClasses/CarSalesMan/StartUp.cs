using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesMan
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();

            int numerOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numerOfEngines; i++)
            {
                var engineDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = engineDetails[0];
                var power = int.Parse(engineDetails[1]);

                if (engineDetails.Length > 2)
                {
                    var engine = engineDetails.Length == 3
                        ? new Engine(model, power, engineDetails[2])
                        : new Engine(model, power, engineDetails[2], engineDetails[3]);
                    engines.Add(engine);
                }
                else
                {
                    var engine = new Engine(model, power);
                    engines.Add(engine);
                }
            }

            int numerOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numerOfCars; i++)
            {
                var carDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = carDetails[0];
                var engine = engines.Find(x => x.Model == carDetails[1]);

                if (carDetails.Length > 2)
                {
                    var car = carDetails.Length == 3
                        ? new Car(model, engine, carDetails[2])
                        : new Car(model, engine, carDetails[2], carDetails[3]);
                    cars.Add(car);
                }
                else
                {
                    var car = new Car(model, engine);
                    cars.Add(car);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, cars.Select(c=>c.ToString())));
        }
    }
}
