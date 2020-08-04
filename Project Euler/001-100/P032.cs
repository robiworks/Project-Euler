using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    internal class P032
    {
        /*
         * Problem 32: Pandigital products
         * We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
         * The product 7254 is unusual, as the identity, 39 * 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
         * Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
         * HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
         */

        public static int Solve()
        {
            var pandigitalNums = new List<int>();
            for (int n = 1; n <= 9876; n++)
            {
                if (IsPandigital(n))
                {
                    pandigitalNums.Add(n);
                }
            }
            pandigitalNums.Distinct();
            int sum = 0;
            for (int i = 0; i < pandigitalNums.Count; i++)
            {
                sum += pandigitalNums[i];
            }
            return sum;
        }

        private static bool IsPandigital(int number)
        {
            var divisors = new List<int>();
            var digits = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int d = 1; d <= number; d++)
            {
                if (number % d == 0)
                {
                    divisors.Add(d);
                }
            }
            for (int i = 0; i < divisors.Count; i++)
            {
                int j = number / divisors[i];
                int temp = 0;
                string identity = divisors[i].ToString() + " " + j.ToString() + " " + number.ToString();
                for (int k = 0; k < digits.Length; k++)
                {
                    if (identity.Contains(digits[k]) && identity.Count(c => c == digits[k]) == 1)
                    {
                        temp += 1;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (temp == 9) { return true; }
            }
            return false;
        }
    }
}