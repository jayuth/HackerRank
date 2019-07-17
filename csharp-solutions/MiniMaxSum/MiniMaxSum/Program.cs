using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    class Solution 
    {
        public long sum;
        public List<long> list = new List<long>();
        public List<long> result = new List<long>();


        public  List<long> MiniMaxSum(params int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; 
            }

            for (var i = 0; i < arr.Length; i++)
            {
                list.Add(sum - arr[i]); 
            }

            result.Add(list.Min());
            result.Add(list.Max());

            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           var solution = new Solution();
           var result = solution.MiniMaxSum(256741038, 623958417, 467905213, 714532089, 938071625);
            foreach (var num in result)
            {
                Console.WriteLine(num);

            }
        }
    }
}
