using System;
using System.IO;
using System.Linq;

namespace Ex2LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = "../../../../InputFiles";
            string outputPath = "../../../../Outputfiles";
            string fileName = "text.txt";
            string outputFile = "output.txt";
            inputPath = Path.Combine(inputPath, fileName);
            outputPath = Path.Combine(outputPath, outputFile);
            using (StreamReader reader = new StreamReader(inputPath))
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    string line = reader.ReadLine();
                    int count = 0;
                    while (line != null)
                    {
                        writer.WriteLine($"Line {++count}: {line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
