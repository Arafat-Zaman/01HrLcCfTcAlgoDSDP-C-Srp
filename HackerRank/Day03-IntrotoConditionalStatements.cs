using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day03_IntrotoConditionalStatements
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if ((N % 2 == 1) || (N >= 6 && N <= 20))
                Console.WriteLine("Weird");

            else if ((N >= 2 && N <= 5) || N > 20) Console.WriteLine("Not Weird");
        }
    }
}
