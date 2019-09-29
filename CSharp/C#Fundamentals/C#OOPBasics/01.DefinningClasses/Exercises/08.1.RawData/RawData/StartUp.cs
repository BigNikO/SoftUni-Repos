using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire22ressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);
                Engine engine = new Engine
                {
                    Power = enginePower,
                    Speed = engineSpeed
                };
                Cargo cargo = new Cargo
                {
                    Weight = cargoWeight,
                    Type = cargoType,
                };
                List<Tire> tires = new List<Tire>();
                tires.Add(new Tire(tire1Pressure, tire1Age));
                tires.Add(new Tire(tire1Pressure, tire2Age));
                tires.Add(new Tire(tire3Pressure, tire3Age));
                tires.Add(new Tire(tire4Pressure, tire4Age));
                Car car = new Car();

                car.Model = model;
                car.Cargo = cargo;
                car.Engine = engine;
                car.Tires = tires;

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                Console.WriteLine(String
                .Join(Environment.NewLine, cars
                .Where(x => x.Cargo.Type == command && x.Tires.Any(y => y.Pressure < 1))
                .Select(x => x.Model)));
            }
            else if (command == "flamable")
            {
                Console.WriteLine(String
                    .Join(Environment.NewLine, cars
                    .Where(x => x.Cargo.Type == command && x.Engine.Power > 250)
                    .Select(x => x.Model)));
            }
        }
    }
}
