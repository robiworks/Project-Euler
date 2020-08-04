using System.Numerics;

namespace Project_Euler
{
    internal class P020
    {
        /*
         * Problem 20: Factorial digit sum
         * n! means n * (n − 1) * ... * 3 * 2 * 1
         * For example, 10! = 10 * 9 * ... * 3 * 2 * 1 = 3628800, and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
         * Find the sum of the digits in the number 100!
         */

        public static int Solve()
        {
            BigInteger n = Factorial(100);
            string num = n.ToString();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int digit = int.Parse(num.Substring(i, 1));
                sum += digit;
            }
            return sum;
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger fact = 1;
            for (int i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}