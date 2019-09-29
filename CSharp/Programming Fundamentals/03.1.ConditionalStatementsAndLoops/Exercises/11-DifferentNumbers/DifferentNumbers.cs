using System;

namespace Exe11DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number2 - 4 < number1)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = number1; i <= number2 - 4; i++)
                {
                    for (int j = (i + 1); j <= number2 - 3; j++)
                    {
                        for (int k = (i + 2); k <= number2 - 2; k++)
                        {
                            for (int m = (i + 3); m <= number2 - 1; m++)
                            {
                                for (int n = (i + 4); n <= number2; n++)
                                {
                                    if(i<j && j<k && k<m && m<n)
                                    Console.WriteLine($"{i} {j} {k} {m} {n}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
