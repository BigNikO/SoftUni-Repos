using System;

namespace Ex5BooleanVarriable
{
    class BooleanVarriable
    {
        static void Main(string[] args)
        {
            bool check = bool.Parse(Console.ReadLine());
            if (check)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
