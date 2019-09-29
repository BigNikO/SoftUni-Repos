using System;
using System.Linq;

namespace Ex2EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@');
            int firstPart = email[0].Sum(x => x);
            int secondPart = email[1].Sum(x => x);
            if (firstPart-secondPart>=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
