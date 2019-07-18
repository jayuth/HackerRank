// Link to this problem: https://www.hackerrank.com/challenges/halloween-sale/problem
using System;

namespace HalloweenSale
{
    class Solution
    {
        public static int HowManyGames(int p, int d, int m, int s)
        {
            var subsequence = p;
            var sum = p;
            var count = 0;

            while (sum <= s)
            {
                subsequence -= d;

                if (subsequence < m) subsequence = m;

                sum += subsequence;
                count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = Solution.HowManyGames(100, 19, 1, 180);
            Console.WriteLine(result);
        }
    }
}
