using System;
using System.Linq;

namespace Ex2ManipulateArray
{
    class SafeManipulation
    {
         static void Main(string[] args)
        {
            string[] theArray = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Reverse")
                {
                    theArray = theArray.Reverse().ToArray();
                }
                else if (command[0] == "Distinct")
                {
                    var dist = theArray.Distinct();
                    theArray = dist.ToArray();
                }
                else if (command[0]=="END")
                {
                    break;
                }
                else if (command[0] == "Replace")
                {                     
                    if (int.Parse(command[1])>=theArray.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        theArray[int.Parse(command[1])] = command[2];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.Write(theArray[0]);
            for (int i = 1; i < theArray.Length; i++)
            {
                
                Console.Write(", "+theArray[i]);
            }
        }        
    }
}
