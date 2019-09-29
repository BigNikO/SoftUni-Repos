using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Person noName = new Person(20);
            Person noNameAge = new Person();
        }
    }
}
