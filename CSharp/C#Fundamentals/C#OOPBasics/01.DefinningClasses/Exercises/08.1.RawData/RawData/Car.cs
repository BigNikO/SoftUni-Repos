using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public Engine Engine
        {
            get => this.engine;
            set => this.engine = value;
        }
        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }

            set
            {
                this.cargo = value;
            }
        }
        public List<Tire> Tires
        {
            get
            {
                return this.tires;
            }

            set
            {
                this.tires = value;

            }
        }

    }
}
