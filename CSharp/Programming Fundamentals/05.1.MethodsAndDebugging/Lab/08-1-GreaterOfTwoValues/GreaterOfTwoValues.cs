using System;

namespace lab8GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int maxValue = GetMax(first, second);
                Console.WriteLine(maxValue);
            }

            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char maxValue = GetMax(first, second);
                Console.WriteLine(maxValue);
            }

            if (type == "string")
            {
                string first = (Console.ReadLine());
                string second = (Console.ReadLine());
                string maxValue = GetMax(first, second);
                Console.WriteLine(maxValue);
            }

        }
        static string GetMax(string first, string second)
        {
            string result = first;
            if (first.CompareTo(second) <= 0)
            {
                result = second;
            }
            return result;
        }
        static char GetMax(char first, char second)
        {
            char result = first;
            if (first < second)
            {
                result = second;
            }
            return result;
        }
        static int GetMax(int first, int second)
        {
            int result = first;
            if (first < second)
            {
                result = second;
            }
            return result;
        }
    }
}
