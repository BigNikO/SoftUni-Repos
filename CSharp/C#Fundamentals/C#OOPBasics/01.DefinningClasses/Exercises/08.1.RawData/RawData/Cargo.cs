namespace RawData
{
    public class Cargo
    {
        private int weight;
        private string type;

        public int Weight
        {
            get => this.weight;
            set => this.weight = value;
        }
        public string Type
        {
            get => this.type;
            set => this.type = value;
        }
    }
}
