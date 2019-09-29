using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfengines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfengines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                string power = engineInfo[1];
                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int result))
                    {
                        engine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    engine.Displacement = engineInfo[2];
                    engine.Efficiency = engineInfo[3];
                }
                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = engines.First(x => x.Model == engineModel);
                Car car = new Car(model, engine);

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int result))
                    {
                        car.Weight = carInfo[2];
                    }
                    else
                    {
                        car.Color = carInfo[2];
                    }

                }
                else if (carInfo.Length == 4)
                {
                    car.Weight = carInfo[2];
                    car.Color = carInfo[3];
                }

                cars.Add(car);
            }
            cars.ForEach(x =>
            {
                Console.WriteLine(x.Model + ":");
                Console.WriteLine(" " + x.Engine.Model + ":");
                Console.WriteLine("  Power: " + x.Engine.Power);
                Console.WriteLine("  Displacement: " + x.Engine.Displacement);
                Console.WriteLine("  Efficiency: " + x.Engine.Efficiency);
                Console.WriteLine(" Weight: " + x.Weight);
                Console.WriteLine(" Color: " + x.Color);
            });
        }
    }
}
