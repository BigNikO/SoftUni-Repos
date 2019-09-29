namespace Ex6IntervalOfNumbers
{
    using System;
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number = number1;
            if (number1 > number2)
            {
                number1 = number2;
                number2 = number;
            }
            for (int i = number1; i <= number2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
