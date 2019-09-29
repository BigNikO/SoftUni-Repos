namespace Ex3MilesToKm
{
    using System;
    class Ex3StartUp
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double kilometer = 1.60934 * mile;

            Console.WriteLine("{0:f2}", kilometer);
        }
    }
}
