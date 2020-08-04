namespace Project_Euler
{
    internal class P034
    {
        /*
         * Problem 34: Digit factorials
         * 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
         * Find the sum of all numbers which are equal to the sum of the factorial of their digits.
         * Note: as 1! = 1 and 2! = 2 are not sums they are not included.
         */

        public static int Solve()
        {
            int sum = 0;
            for (int i = 3; i <= 3265920; i++) // highest number to check is 9 * 9! = 3265920
            {
                int tempSum = 0;
                char[] num = i.ToString().ToCharArray();
                foreach (char c in num)
                {
                    int d = int.Parse(c.ToString());
                    tempSum += Factorial(d);
                }
                if (tempSum == i)
                {
                    sum += tempSum;
                }
            }
            return sum; // takes like 2 seconds but whatever, I'll do optimisation and rewriting later
        }

        private static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                int fact = 1;
                for (int i = number; i >= 1; i--)
                {
                    fact *= i;
                }
                return fact;
            }
        }
    }
}