namespace CarSalesMan
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power)
            : this()
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, string argument) : this(model, power)
        {
            if(int.TryParse(argument, out int result))
            {
                this.Displacement = argument;
            } else
            {
                this.Efficiency = argument;
            }       
        }

        public Engine(string model, int power, string displacement, string efficiency) : this(model, power, displacement)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}