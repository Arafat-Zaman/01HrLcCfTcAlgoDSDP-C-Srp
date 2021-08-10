using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
namespace HackerRank
{
    class Day25_RunningTimeandComplexity
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int qtdNumbers = Convert.ToInt32(Console.ReadLine());
            string inputNumber;

            while ((inputNumber = Console.ReadLine()) != null)
            {

                int number = Convert.ToInt32(inputNumber);
                bool isNumberPrime = true;
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }

                if (isNumberPrime && number > 1)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not prime");
            }
        }
    }
}