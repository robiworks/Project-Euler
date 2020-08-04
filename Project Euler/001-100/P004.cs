using System;

namespace Project_Euler
{
    internal class P004
    {
        /*
         * Problem 4: Largest palindrome product
         * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 * 99.
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */

        public static int Solve()
        {
            int maxPalindrome = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int prod = i * j;
                    if (IsPalindrome(prod) && prod > maxPalindrome)
                    {
                        maxPalindrome = prod;
                    }
                }
            }
            return maxPalindrome;
        }

        public static bool IsPalindrome(int number)
        {
            char[] arr = number.ToString().ToCharArray();
            Array.Reverse(arr);
            string reversedNumber = new string(arr);
            if (number.ToString() == reversedNumber)
            {
                return true;
            }
            return false;
        }
    }
}