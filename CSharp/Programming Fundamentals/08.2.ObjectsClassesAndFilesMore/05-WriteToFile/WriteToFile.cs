using System.IO;
using System.Text.RegularExpressions;

namespace Ex5WriteToFile
{
    class WriteToFile
    {
        static void Main(string[] args)
        {          
            string text = File.ReadAllText("sample_text.txt");
            string pattern = @"[.,!?:]";
            string result = Regex.Replace(text, pattern, "");
            File.WriteAllText("new_sample_text.txt", result);
        }
    }
}
 