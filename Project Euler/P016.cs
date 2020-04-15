using System;
using System.Numerics;

namespace Project_Euler
{
    internal class P016
    {
        /*
         * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
         * What is the sum of the digits of the number 2^1000?
         */

        public static long Solve()
        {
            BigInteger number = (BigInteger)Math.Pow(2, 1000);
            string digits = number.ToString();
            long sum = 0;
            foreach (char digit in digits)
            {
                long d = long.Parse(digit.ToString());
                sum += d;
            }
            return sum;
        }
    }
}