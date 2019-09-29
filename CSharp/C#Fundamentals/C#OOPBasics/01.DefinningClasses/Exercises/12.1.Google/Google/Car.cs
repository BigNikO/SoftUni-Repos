namespace Google
{
    public class Car
    {

        public Car(string model, string birthDate)
        {
            this.Model = model;
            this.Speed = birthDate;
        }
        public string Model { get; private set; }

        public string Speed { get; private set; }
    }
}
