using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
        private double pressure;
        private int age;

        public double Pressure
        {
            get => this.pressure;
            set => this.pressure = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

    }
}
