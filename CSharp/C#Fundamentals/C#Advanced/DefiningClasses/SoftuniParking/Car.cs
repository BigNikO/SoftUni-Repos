namespace SoftUniParking
{
    using System.Text;

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.RegistrationNumber = registrationNumber;
            this.HorsePower = horsePower;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"HorsePower: {this.HorsePower}");
            result.Append($"RegistrationNumber: {this.RegistrationNumber}");

            return result.ToString();
        }
    }
}
