using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class CheckNumber
    {
        public static string Line = string.Empty; // line that appears in the console
        public static string CheckDivisibility(int number)
        {
            if (number % 3 == 0)
            {
                Line = "Fizz";
            }
            if (number % 5 == 0)
            {
                Line += "Buzz"; // if the number is divisible by both 3 and 5, the line reads FizzBuzz (adds Buzz to Fizz from previous condition)
            }
            if (Line == string.Empty)
            {
                Line = number.ToString();
            }
            return Line;
        }
    }
}
