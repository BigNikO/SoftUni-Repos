using System.Text;

namespace CarSalesMan
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public Car(string model, Engine engine)
            : this()
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, string argument)
            : this(model, engine)
        {
            if (int.TryParse(argument, out int result))
            {
                this.Weight = argument;
            }
            else
            {
                this.Color = argument;
            }
        }

        public Car(string model, Engine engine, string weight, string color) : this(model, engine, weight)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"{this.Model}:");
            result.AppendLine($"  {this.Engine.Model}:");
            result.AppendLine($"    Power: {this.Engine.Power}");
            result.AppendLine($"    Displacement: {this.Engine.Displacement}");
            result.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            result.AppendLine($"  Weight: {this.Weight}");
            result.Append($"  Color: {this.Color}");
            return result.ToString();
        }
    }
}
