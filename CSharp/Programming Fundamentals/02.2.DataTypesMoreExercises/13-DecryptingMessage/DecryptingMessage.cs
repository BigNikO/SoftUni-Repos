using System;

namespace Exe13DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int charCount = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < charCount; i++)
            {
                result += (char)(char.Parse(Console.ReadLine()) + key);
            }
            Console.WriteLine(result);
        }
    }
}
