using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {           
            Dictionary<string, int> handsPower = new Dictionary<string, int>();
            {
                handsPower["2"] = 2;
                handsPower["3"] = 3;
                handsPower["4"] = 4;
                handsPower["5"] = 5;
                handsPower["6"] = 6;
                handsPower["7"] = 7;
                handsPower["8"] = 2;
                handsPower["9"] = 9;
                handsPower["10"] = 10;
                handsPower["J"] = 11;
                handsPower["Q"] = 12;
                handsPower["K"] = 13;
                handsPower["A"] = 14;
                handsPower["C"] = 1;
                handsPower["D"] = 2;
                handsPower["H"] = 3;
                handsPower["S"] = 4;
            }
            Dictionary<string, List<string>> playerHand = new Dictionary<string, List<string>>();
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split(": ").ToList();
                if (input[0] == "JOKER")
                {
                    break;
                }
                var hands = input[1].Split(", ").ToArray();
                if (playerHand.ContainsKey(input[0]))
                {
                    playerHand[input[0]] = playerHand[input[0]].Concat(hands).Distinct().ToList();
                }
                else
                {
                    playerHand[input[0]] = hands.Distinct().ToList();
                }
            }           
            foreach (var item in playerHand)
            {
                int totalPower = 0;
                var checkPower = item.Value.ToList();
                foreach (string card in checkPower)
                {
                    int cardPower=0;
                    int cardType=0;
                    if (card.Length>2)
                    {
                        cardPower = handsPower[card[0].ToString()+(card[1].ToString())];
                        cardType = handsPower[card[2].ToString()];
                    }
                    else
                    {
                        cardPower = handsPower[card[0].ToString()];
                        cardType = handsPower[card[1].ToString()];
                    }
                    totalPower += cardPower * cardType;
                }
                result[item.Key] = totalPower;              
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
