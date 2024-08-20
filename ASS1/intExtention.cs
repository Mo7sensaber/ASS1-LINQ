using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1
{
    internal class intExtention
    {
        public static int Reverse(int number)
        {
            int reversedNumber = 0, lastDigit;
            while (number > 0)
            {
                lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number /= 10;
            }
            return reversedNumber;
        }
    }
}
