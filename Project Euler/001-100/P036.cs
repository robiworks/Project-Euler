using System.Collections.Generic;

namespace Project_Euler
{
    internal class P036
    {
        /*
         * Problem 36: Double-base palindromes
         * The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
         * Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
         * (Please note that the palindromic number, in either base, may not include leading zeros.)
         */

        public static int Solve()
        {
            List<int> palindromes10 = new List<int>();
            int sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (Library.IsPalindrome(i))
                {
                    palindromes10.Add(i);
                }
            }
            foreach (int p in palindromes10)
            {
                ulong b = Library.ToBinary(p);
                if (Library.IsPalindrome(b))
                {
                    sum += p;
                }
            }
            return sum;
        }
    }
}