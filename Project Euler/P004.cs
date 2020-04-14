using System;

namespace Project_Euler
{
    internal class P004
    {
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