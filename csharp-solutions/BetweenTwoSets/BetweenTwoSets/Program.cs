using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class Solution
    {
        public static void GetTotalX(List<int> a, List<int> b) 
        {
            List<int> firstFactor = new List<int> { };
            List<int> firstIntersect = new List<int> { };
            List<int> secondFactor = new List<int> { };
            List<int> secondIntersect = new List<int> { };

            for (var i = 0; i < a.Count; i++)
            {
                for (var j = 1; j <= 100; j++)
                {
                    if (j % a[i] == 0)
                    {
                        firstFactor.Add(j);

                        if (firstFactor.Count(x => x == j) == a.Count) 
                        {
                            firstIntersect.Add(j);
                        }
                    }
                }
            }

            for (var i = 0; i < b.Count; i++)
            {
                for (var j = 0; j < firstIntersect.Count; j++)
                {
                    if (b[i] % firstIntersect[j] == 0)
                    {
                        secondFactor.Add(firstIntersect[j]);

                        if (secondFactor.Count(x => x == firstIntersect[j]) == b.Count)
                        {
                            secondIntersect.Add(firstIntersect[j]);
                        }
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution.GetTotalX(new List<int> { 2, 4 }, new List<int> { 16, 32, 96 });
        }
    }
}
