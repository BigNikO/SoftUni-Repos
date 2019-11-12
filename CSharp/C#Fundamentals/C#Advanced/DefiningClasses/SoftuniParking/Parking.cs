namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public int Count
        {
            get => this.cars.Count;
        }

        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }


        public string AddCar(Car car)
        {
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.cars.Count >= this.capacity)
            {
                return "Parking is full!";
            }
            else
            {
                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                var car = cars.Find(c => c.RegistrationNumber == registrationNumber);
                this.cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                return cars.Find(c => c.RegistrationNumber == registrationNumber);
            }
            else
            {
                Console.WriteLine("Car with that registration number, doesn't exist!");
                return null;
            }
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNUmbers)
        {
            this.cars.RemoveAll(c => registrationNUmbers.Contains(c.RegistrationNumber));
        }
    }
}
