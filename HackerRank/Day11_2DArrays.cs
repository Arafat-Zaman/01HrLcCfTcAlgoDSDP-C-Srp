using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day11_2DArrays
    {
        static int sumHourglasses(int[][] arr, int i, int j)
        {
            return arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] +
                arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int higherHourglasses = 0;
            int currentCount = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    currentCount = sumHourglasses(arr, i, j);
                    if (
                        currentCount > higherHourglasses
                        || (i == 0 && j == 0)
                    )
                        higherHourglasses = currentCount;
                }
            }

            Console.WriteLine(higherHourglasses);
        }
    }
}
