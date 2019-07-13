using System;

namespace BirthdayCakeCandles
{
    public class Candles
    {
        public int Calculate( params int[] candles)
        {
            var max = candles[0];

            for (var i = 0; i < candles.Length; i++)
            {
                if (max < candles[i])
                    max = candles[i];
            }

            var count = 0;

            foreach (var num in candles)
            {
                if (num == max)
                    count++;
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var candles = new Candles();
            Console.WriteLine(candles.Calculate(1, 2, 3, 3, 1, 5, 2));
        }
    }
}
