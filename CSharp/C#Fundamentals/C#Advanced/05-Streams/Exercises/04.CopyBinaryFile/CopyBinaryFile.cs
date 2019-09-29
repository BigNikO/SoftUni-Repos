using System;
using System.IO;

namespace Ex4CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = "../../../../InputFiles";
            string outputPath = "../../../../Outputfiles";
            string fileName = "copyMe.png";
            string outputFile = "coppied.png";
            inputPath = Path.Combine(inputPath, fileName);
            outputPath = Path.Combine(outputPath, outputFile);
            using (var readStream = new FileStream(inputPath, FileMode.Open))
            {
                using (var writeStream = new FileStream(outputPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int byteCount = readStream.Read(buffer, 0, 4096);
                        if (byteCount == 0)
                        {
                            break;
                        }

                        writeStream.Write(buffer, 0, byteCount);
                    }
                }

            }
        }
    }
}
