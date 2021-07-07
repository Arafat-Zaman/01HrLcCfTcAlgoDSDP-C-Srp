using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank
{
    class Day16_ExceptionsStringtoInteger
    {
        static void Main(String[] args)
        {
            string S = Console.ReadLine();

            try
            {
                int stringConvertedToInt = Convert.ToInt32(S);
                Console.WriteLine(stringConvertedToInt);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}




