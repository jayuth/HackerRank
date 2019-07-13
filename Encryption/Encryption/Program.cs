using System;
using System.Collections.Generic;

namespace Encryption
{
    class Solution
    {
        public static void Encryption(string s)
        {
            var trim = s.Replace(" ", "");
            var rows = Convert.ToInt32(Math.Floor(Math.Sqrt(trim.Length)));
            var columns = Convert.ToInt32(Math.Ceiling(Math.Sqrt(trim.Length)));

            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("Columns: " + columns);

            var list = new List<string>();
            var i = 0;
            var count = 0;

            while (i < columns)
            {
                // logic:
                // the pattern of an array is the first index + columns for columns times.
                // e.g. colmuns = 4 and string length = 12
                // the pattern will be 0, 4, . The value of j will increase by columns each time.
                // 0 < 12, 4 < 12, 8 < 12 = 3 times 
                for (var j = count; j < trim.Length; j += columns)
                {
                    list.Add(Convert.ToString(trim[j]));
                }
                list.Add(" ");
                count++;
                i++;
            }

            var combine = string.Join("", list);
            Console.WriteLine(combine);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var str = "chillout";
            // var str = "feed the dog";
            var str = "have a nice day";
            // var str = "if man was meant to stay on the ground god would have given us roots";
            Solution.Encryption(str);
        }
    }
}
