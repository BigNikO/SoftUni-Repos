using System;
using System.Numerics;
namespace Ex1SnowBalls
{
    class SnowBalls
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
            int snowBallSnowMax = 0;
            int snowballTimeMax = 0;
            int snowBallQualityMax = 0;
            BigInteger snowBallValueMax = -1;
            for (int i = 0; i < counts; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                BigInteger snowBallValue = BigInteger.Pow(snowBallSnow / snowBallTime, snowBallQuality);
                if (snowBallValue>snowBallValueMax)
                {
                    snowBallValueMax = snowBallValue;
                    snowballTimeMax = snowBallTime;
                    snowBallSnowMax = snowBallSnow;
                    snowBallQualityMax = snowBallQuality;
                }
            }
            Console.WriteLine($"{snowBallSnowMax} : {snowballTimeMax} = {snowBallValueMax} ({snowBallQualityMax})");
        }
    }
}
