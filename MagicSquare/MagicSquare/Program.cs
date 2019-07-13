using System;
using System.Collections.Generic;

namespace MagicSquare
{
    class Solution
    { 
        public static int FormingMagicSquare(int[][] arr)
        {
            var cost = 0;

            while (true)
            {
                var diff = 15 - (arr[0][0] + arr[0][1] + arr[0][2]);


                if (arr[0][0] + arr[1][0] + arr[2][0] + diff == 15 && arr[0][0] + arr[1][1] + arr[2][2] + diff == 15)
                {
                    var temp = arr[0][0];
                    arr[0][0] = arr[0][0] + diff;
                    cost += Math.Abs(temp - arr[0][0]);
                    break;
                }

                if (arr[0][2] + arr[1][2] + arr[2][2] + diff == 15 && arr[0][2] + arr[1][1] + arr[2][0] + diff == 15)
                {
                    var temp = arr[0][2];
                    arr[0][2] = arr[0][2] + diff;
                    cost += Math.Abs(temp - arr[0][2]);
                    break;
                }

                var temp1 = arr[0][1];
                arr[0][1] = arr[0][1] + diff;
                cost += Math.Abs(temp1 - arr[0][1]);
                break;
            }

            //row 2
            var sum = arr[1][0] + arr[1][1] + arr[1][2];
            var diff2 = 15 - sum;

            if (sum != 15)
            {
                if (arr[0][0] + arr[1][0] + arr[2][0] != 15)
                {
                    var temp = arr[1][0];
                    arr[1][0] = arr[1][0] + diff2;
                    cost += Math.Abs(temp - arr[1][0]);
                }
                else
                {
                    var temp = arr[1][2];
                    arr[1][2] = arr[1][2] + diff2;
                    cost += Math.Abs(temp - arr[1][2]);
                }
            }

            // row 3
            var sum3 = arr[2][0] + arr[2][1] + arr[2][2];
            var diff3 = 15 - sum3;

            if (sum3 != 15)
            {
                if (arr[0][0] + arr[1][0] + arr[2][0] != 15)
                {
                    var temp = arr[2][0];
                    arr[2][0] = arr[2][0] + diff3;
                    cost += Math.Abs(temp - arr[2][0]);
                }
                else if (arr[0][1] + arr[1][1] + arr[2][1] != 15)
                {
                    var temp = arr[2][1];
                    arr[2][1] = arr[2][1] + diff3;
                    cost += Math.Abs(temp - arr[2][1]);
                }
                else
                {
                    var temp = arr[2][2];
                    arr[2][2] = arr[2][2] + diff3;
                    cost += Math.Abs(temp - arr[2][2]);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                // element({0})
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);

                }
            }
      

           Console.WriteLine("cost");

           Console.WriteLine(cost);

            return 1;
            

        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            //Solution.FormingMagicSquare(new int[][] { new int[] { 4, 3, 5, 8, 5, 1, 2, 4, 6 } });
            Solution.FormingMagicSquare(new int[][]
            {   new int[] { 5, 3, 4 },
                new int[] { 1, 5, 8 } ,
                new int[] {6, 4, 2 } });
            //Solution.FormingMagicSquare(new int[][] { new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8 } } );
            //Solution.FormingMagicSquare(new int[,] { { 4, 3, 5 }, { 8, 5, 1 }, { 2, 4, 6 } });
            //Solution.FormingMagicSquare(new int[,] { { 2, 8, 4 }, { 7, 5, 4 }, { 6, 1, 6 } });
            //Solution.FormingMagicSquare(new int[,] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 5 } });
            //Solution.FormingMagicSquare(new int[,] { { 5, 3, 4 }, { 1, 5, 8 }, { 6, 4, 2 } });
            //Solution.FormingMagicSquare(new int[,] { { 4, 8, 2 }, { 4, 5, 7 }, { 6, 1, 6 } });
            //Solution.FormingMagicSquare(new int[,] { { 4, 8, 2 }, { 4, 5, 7 }, { 6, 1, 6 } });
        }
    }
}

    
