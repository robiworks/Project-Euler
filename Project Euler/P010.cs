namespace Project_Euler
{
    internal class P010
    {
        /*
         * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
         * Find the sum of all the primes below two million.
         */

        public static long Solve()
        {
            long sum = 5;
            for (long i = 4; i < 2000000; i++)
            {
                if (P007.IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}