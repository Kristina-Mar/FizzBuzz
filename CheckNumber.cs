using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class CheckNumber
    {
        public static bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }
        public static bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}
