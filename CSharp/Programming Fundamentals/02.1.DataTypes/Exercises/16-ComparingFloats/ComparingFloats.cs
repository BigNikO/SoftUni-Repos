using System;

namespace Exe16ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double firstFPNumber = double.Parse(Console.ReadLine());
            double secondFpNumber = double.Parse(Console.ReadLine());
            bool check = false;
            if (Math.Abs(firstFPNumber - secondFpNumber) < eps)
            {
                check = true;
            }
            Console.WriteLine(check);
        }
    }
}
