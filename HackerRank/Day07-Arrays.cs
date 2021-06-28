using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day07_Arrays
    {
        public static string arrayReverseToString(int[] arr)
        {
            string arrString = "";
            foreach (int itemArr in arr.Reverse())
            {
                arrString += $"{itemArr} ";
            }
            return arrString;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Console.WriteLine(arrayReverseToString(arr));
        }
    }
}
