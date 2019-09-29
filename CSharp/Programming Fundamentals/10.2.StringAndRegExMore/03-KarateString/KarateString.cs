using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3KarateString
{
    class KarateString
    {
        static void Main(string[] args)
        {
            List<string> strenght = Console.ReadLine().Split('>').ToList();
            int restPower = 0;
            for (int i = 1; i < strenght.Count; i++)
            {
                string punch = strenght[i];
                int index = int.Parse(punch[0].ToString())+restPower;
                restPower = 0;
                {
                    if (index<=punch.Length)
                    {
                        punch = punch.Remove(0, index);
                        strenght[i] = punch;
                    }
                    else
                    {
                        punch = punch.Remove(0);
                        restPower = index - punch.Length-1;
                        strenght[i] = punch;
                    }                   
                }
            }
            Console.WriteLine(string.Join(">", strenght));
        }
    }
}
