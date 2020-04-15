using System;
using System.Collections.Generic;

namespace Project_Euler
{
    internal class P007
    {
        /*
         * Problem 007:
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         */

        public static long Solve()
        {
            var primes = new List<long>() { 2, 3 };
            long n = 4;
            while (primes.Count < 10001)
            {
                if (IsPrime(n))
                {
                    primes.Add(n);
                }
                n += 1;
            }
            return primes[10000];
        }

        public static bool IsPrime(long number)
        {
            if (number < 2) { return false; }
            if (number % 2 == 0) { return number == 2; }
            long squareRoot = (long)Math.Sqrt(number);
            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}