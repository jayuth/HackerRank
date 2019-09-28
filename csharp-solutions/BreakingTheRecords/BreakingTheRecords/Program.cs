// problem link: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

using System;
using System.Collections.Generic;

namespace BreakingTheRecords
{
    class solution
    {
        public static int[] BreakingRecords(int[] scores)
        {
            var max = 0;
            var min = scores[0];
            var maxCount = 0;
            var minCount = 0;

            /* for debugging
            List<int> maxCount = new List<int>();
            List<int> minCount = new List<int>();
            */

            List<int> result = new List<int>();

            for (var i = 1; i < scores.Length; i++)
            {
                if (scores[i] > scores[0])
                {
                    if (scores[i] > max)
                    {
                        max = scores[i];
                        maxCount++;
                        // maxCount.Add(scores[i]);
                    }
                }
                else
                {
                    if (scores[i] < min)
                    {
                        min = scores[i];
                        minCount++;
                        // minCount.Add(scores[i]);
                    }
                }
            }

            result.Add(maxCount);
            result.Add(minCount);

            return result.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // int[] scoresArr = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            int[] scoresArr = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            var result = solution.BreakingRecords(scoresArr);

            Console.WriteLine(string.Join(",", result));
        }
    }
}
