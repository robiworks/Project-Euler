using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;

namespace Project_Euler
{
    class P035
    {
        /*
         * Problem 35: Circular primes
         * The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
         * There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
         * How many circular primes are there below one million?
         */

        public static int Solve() // runs in like 30 seconds and a lot of improvement can be done and will be done
        {
            List<int> primes = Library.FindPrimes(1000000);
            List<int> circulars = new List<int>();
            for (int i = 2; i < 1000000; i++)
            {
                List<int> rots = Library.RotateDigits(i);
                if (rots.All(val => primes.Contains(val)))
                {
                    foreach (int r in rots)
                    {
                        circulars.Add(r);
                        primes.Remove(r);
                    }
                }
            }
            int circularCount = circulars.Count;
            return circularCount;
        }
    }
}
