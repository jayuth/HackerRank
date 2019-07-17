using System;

namespace AppleOrange
{
    class Solution
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var appleCount = 0;
            var orangeCount = 0;

            // a = distance of apple tree
            foreach (var apple in apples)
            {
                if ((apple + a) >= s && (apple + a) <= t)
                {
                    appleCount++;
                }
            }

            foreach(var orange in oranges)
            {
                if ((orange + b) >= s && (orange + b) <= t)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution.CountApplesAndOranges(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 });
        }
    }
}
