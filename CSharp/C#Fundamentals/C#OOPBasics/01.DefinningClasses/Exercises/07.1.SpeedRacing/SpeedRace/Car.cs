namespace SpeedRace
{
    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int traveledDistance;

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public decimal FuelAmount
        {
            get => this.fuelAmount;
            set => this.fuelAmount = value;
        }
        public decimal FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        public int TravelledDistance
        {
            get => this.traveledDistance;
            set => this.traveledDistance = value;
        }
        public bool CanTravelTheDistance(int distance)
        {
            if ((this.TravelledDistance + distance) * this.FuelConsumption <= this.FuelAmount)
            {
                this.TravelledDistance += distance;
                return true;
            }
            return false;
        }
    }
}
