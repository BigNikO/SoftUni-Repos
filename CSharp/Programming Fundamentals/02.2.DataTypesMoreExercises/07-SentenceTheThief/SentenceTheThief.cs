using System;

namespace Ex7SentenceTheThief
{
    class SentenceTheThief
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            long maxValue = long.MinValue;
            switch (type)
            {
                case "int":
                    maxValue = int.MinValue;
                    break;
                case "sbyte":
                    maxValue = sbyte.MinValue;
                    break;
            }
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                long number = long.Parse(Console.ReadLine());
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue && maxValue < number && type == "sbyte")
                {
                    maxValue = number;
                }
                else if (number >= int.MinValue && number <= int.MaxValue && maxValue < number && type == "int")
                {
                    maxValue = number;
                }
                else if (number >= long.MinValue && number <= long.MaxValue && maxValue < number && type == "long")
                {
                    maxValue = number;
                }
            }
            double sentence = 0.0;
            if (maxValue>0)
            {
                sentence = maxValue / 127.0;
            }
            else
            {
                sentence = maxValue / -128.0;
            }
            sentence = Math.Ceiling(sentence);
            if (sentence==1)
            {
                Console.WriteLine($"Prisoner with id {maxValue} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {maxValue} is sentenced to {sentence} years");
            }

        }
    }
}
