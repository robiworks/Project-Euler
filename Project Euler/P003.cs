using System;

namespace Project_Euler
{
    internal class P003
    {
        /*
         * Problem 003:
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         */

        public static long Solve()
        {
            long num = 600851475143;
            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
            return num;
        }
    }
}