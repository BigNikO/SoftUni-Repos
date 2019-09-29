
namespace Task9MultiplicationTable2
{
    using System;
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int theCounter = int.Parse(Console.ReadLine());
            Console.WriteLine(theInteger + " X " + theCounter + " = " + theInteger * theCounter);
            for (int i = theCounter+1; i <= 10; i++)
            {
                Console.WriteLine(theInteger + " X " + i + " = " + theInteger * i);
            }
        }
    }
}
