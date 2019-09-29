using System;

namespace Ex8SMSTyping
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string SMS = Console.ReadLine();
                if (SMS == "0")
                {
                    Console.Write(" ");
                    continue;
                }
                int index = (SMS[0] - '0' - 2) * 3 + SMS.Length - 1 + (SMS[0] > '7' ? 1 : 0);
                Console.Write((char)('a' + index));
            }
        }
    }
}
