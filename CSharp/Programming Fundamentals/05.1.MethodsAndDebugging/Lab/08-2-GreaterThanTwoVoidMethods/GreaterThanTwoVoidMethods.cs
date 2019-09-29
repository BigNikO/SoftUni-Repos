using System;

namespace lab8._1GreaterThanTwoVoidMethods
{
    class GreaterThanTwoVoidMethods
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                GetMaxInt();
            }

            if (type == "char")
            {
                GetMaxChar();
            }

            if (type == "string")
            {
                GetMaxString();
            }

        }
        static void GetMaxString()
        {
            string first = (Console.ReadLine());
            string second = (Console.ReadLine());
            string maxValue = first;

            if (first.CompareTo(second) <= 0)
            {
                maxValue = second;
            }
            Console.WriteLine(maxValue);
        }
        static void GetMaxChar()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char maxValue = first;
            if (first < second)
            {
                maxValue = second;
            }
            Console.WriteLine(maxValue);
        }
        static void GetMaxInt()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int maxValue = first;
            if (first < second)
            {
                maxValue = second;
            }
            Console.WriteLine(maxValue);
        }
    }
}
