using System;

namespace DrawingBook
{
    class Solution
    {
        public static int PageCount(int n, int p)
        {
            double first = (p / 2);
            double second = (n / 2) - ( p / 2);
            var firstResult = Convert.ToInt32(Math.Floor(first));
            var secondResult = Convert.ToInt32(Math.Floor(second));
            var result = Math.Min(firstResult, secondResult);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.PageCount(10, 9));
        }
    }
}
