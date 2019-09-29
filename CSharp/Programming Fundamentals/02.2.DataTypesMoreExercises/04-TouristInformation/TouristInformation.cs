using System;

namespace Ex4TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double valuetoConvert = double.Parse(Console.ReadLine());
            switch (unit)
            {
                case "miles":
                    Console.WriteLine($"{valuetoConvert} {unit} = {valuetoConvert*1.6:f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{valuetoConvert} {unit} = {valuetoConvert * 2.54:f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{valuetoConvert} {unit} = {valuetoConvert * 30:f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{valuetoConvert} {unit} = {valuetoConvert * 0.91:f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{valuetoConvert} {unit} = {valuetoConvert * 3.8:f2} liters");
                    break;
            }
        }
    }
}





