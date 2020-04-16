using System.Numerics;

namespace Project_Euler
{
    internal class P020
    {
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