using System;

namespace Lab4Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)(numberOfPeople / capacity); 
            if (numberOfPeople % capacity!=0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
