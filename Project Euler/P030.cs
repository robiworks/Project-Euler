namespace Project_Euler
{
    internal class P030
    {
        /*
         * Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
         * 1634 = 1^4 + 6^4 + 3^4 + 4^4
         * 8208 = 8^4 + 2^4 + 0^4 + 8^4
         * 9474 = 9^4 + 4^4 + 7^4 + 4^4
         * As 1 = 1^4 is not a sum it is not included.
         * The sum of these numbers is 1634 + 8208 + 9474 = 19316.
         * Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
         */

        public static int Solve()
        {
            int sum = 0;
            for (int i = 2; i <= 354294; i++) // highest number to check = 6 * 9^5
            {
                char[] digits = i.ToString().ToCharArray();
                int tempSum = 0;
                foreach (char d in digits)
                {
                    int n = int.Parse(d.ToString());
                    tempSum += n * n * n * n * n;
                }
                if (tempSum == i)
                {
                    sum += tempSum;
                }
            }
            return sum;
        }
    }
}