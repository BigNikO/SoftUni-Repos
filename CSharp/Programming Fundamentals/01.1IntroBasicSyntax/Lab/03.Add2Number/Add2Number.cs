using System;

namespace Add2Number
{
    class Add2Number
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var sum = a + b;
            Console.WriteLine(a + " + " + b + " = " + sum);
        }
    }
}
