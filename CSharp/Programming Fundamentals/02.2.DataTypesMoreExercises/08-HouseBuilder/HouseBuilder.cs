using System;

namespace Ex8HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            long typeOne = long.Parse(Console.ReadLine());
            long typeTwo = long.Parse(Console.ReadLine());
            long totalPrice = 0;
            if (typeOne>typeTwo)
            {
                totalPrice = typeTwo * 4 + typeOne * 10;
            }
            else
            {
                totalPrice = typeTwo * 10 + typeOne * 4;
            }
            Console.WriteLine(totalPrice);
        }
    }
}
