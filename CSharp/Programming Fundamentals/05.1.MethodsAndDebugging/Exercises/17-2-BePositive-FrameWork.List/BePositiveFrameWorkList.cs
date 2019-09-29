using System;
using System.Collections.Generic;
using System.Linq;

namespace Exe17BePositive_FrameWork.List
{
    class BePositiveFrameWorkList
    {
        public static void Main()
        {
            {
                long countSequences = long.Parse(Console.ReadLine());

                for (long i = 0; i < countSequences; i++)
                {
                    List<long> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToList();

                    bool found = false;

                    for (int j = 0; j < numbers.Count; j++)
                    {
                        long currentNum = numbers[j];

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
                            if (j + 1 < numbers.Count)
                            {
                                currentNum += numbers[j + 1];
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
}
