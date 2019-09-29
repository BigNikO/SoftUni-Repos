using System;

namespace Ex6DNASequences
{
    class DNASequence
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        string sequence = "" + getCharacter(i) + getCharacter(j) + getCharacter(k);
                        Console.Write("{0}{1}{0} ", i + j + k >= targetSum ? 'O' : 'X', sequence);
                    }
                    Console.WriteLine();
                }
        }

        static char getCharacter(int i)
        {
            switch (i)
            {
                case 1:
                    return 'A';
                case 2:
                    return 'C';
                case 3:
                    return 'G';
                case 4:
                    return 'T';
                default:
                    return '0';
            }
        }
    }
}
