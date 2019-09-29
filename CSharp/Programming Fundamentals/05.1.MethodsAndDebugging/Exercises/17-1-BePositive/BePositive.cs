using System;

namespace Exe17BePositive
{
    class BePositive
    {
        public static void Main()
        {
            long countSequences = long.Parse(Console.ReadLine());

            for (long i = 0; i < countSequences; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool found = false;

                for (long j = 0; j < input.Length; j++)
                {
                    long currentNum = long.Parse(input[j]);

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(currentNum);
                        found = true;
                    }
                    else
                    {

                        if (j + 1 < input.Length)
                        {
                            currentNum += long.Parse(input[j + 1]);
                            j++;
                            if (currentNum >= 0)
                            {
                                if (found)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(currentNum);
                                found = true;
                            }
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
