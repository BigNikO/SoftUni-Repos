using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public Cargo Cargo { get; set; }

        public Car()
        {
            this.Tires = new Tire[4];
        }

        public Car(string carInfo)
            : this()
        {
            var carDetails = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var model = carDetails[0];
            var engine = new Engine(int.Parse(carDetails[1]), int.Parse(carDetails[2]));
            var cargo = new Cargo(double.Parse(carDetails[3]), carDetails[4]);
            var tires = new List<Tire>();
            for (int i = 5; i < carDetails.Length; i += 2)
            {
                Tire tire = new Tire();
                tire.Age = int.Parse(carDetails[i+1]);
                tire.Pressure = double.Parse(carDetails[i]);
                tires.Add(tire);
            }
            this.Tires = tires.ToArray();
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
    }
}
