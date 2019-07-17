using System;
using System.Collections.Generic;

namespace CircularArrayRotation
{
    class Solution
    {
        public static int[] CircularArrayRotation(int[] arr, int k, int[] queries)
        {
            var fraction = k % arr.Length;
            var list = new List<int> { };

            if (k % arr.Length == 0)
            {
                for (var i = 0; i < queries.Length; i++)
                {
                    list.Add(arr[queries[i]]);
                }
                return list.ToArray();
            }

            if (k < arr.Length)
            {
                for (var i = 0; i < queries.Length; i++)
                {
                    if (queries[i] - k < 0)
                    {
                        list.Add(arr[queries[i] - k + arr.Length]);
                    }
                    else
                    {
                        list.Add(arr[queries[i] - k]);
                    }
                }
            }
            else
            {
                for (var i = 0; i < queries.Length; i++)
                {
                    if (queries[i] - fraction < 0)
                    {
                        list.Add(arr[queries[i] - fraction + arr.Length]);
                    }
                    else
                    {
                        list.Add(arr[queries[i] - fraction]);
                    }
                }
            }
            return list.ToArray();
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                var result = Solution.CircularArrayRotation(new int[] { 1, 2, 3, 4, 5}, 100000, new int[] { 1, 2 });
                Console.WriteLine(string.Join(",", result));
            }
        }
}
