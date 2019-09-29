using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Child
    {

        public Child(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
        public string Name { get; private set; }

        public string BirthDate { get; private set; }


    }
}
