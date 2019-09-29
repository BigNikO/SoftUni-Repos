using System;
using System.IO;

namespace Ex1OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string path = "../../../../InputFiles";
            string fileName = "text.txt";
            path = Path.Combine(path, fileName);
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int count = 0;
                while (line != null)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
