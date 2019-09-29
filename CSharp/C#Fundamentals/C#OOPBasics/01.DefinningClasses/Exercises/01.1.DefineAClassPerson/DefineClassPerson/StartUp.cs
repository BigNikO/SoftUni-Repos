using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho",  20);
            Person gosho = new Person();
            Person stamat = new Person();

            gosho.Name = "gosho";
            gosho.Age = 18;
            stamat.Name = "Stamat";
            stamat.Age = 43;
        }
    }
}
