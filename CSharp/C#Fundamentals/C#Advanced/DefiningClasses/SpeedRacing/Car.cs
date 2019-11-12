using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public Car()
        {
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelAmount - distance * this.FuelConsumptionPerKilometer >= 0;
            if (canContinue)
            {
                this.FuelAmount -= distance * this.FuelConsumptionPerKilometer;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
