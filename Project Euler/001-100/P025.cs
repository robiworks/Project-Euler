using System.Collections.Generic;
using System.Numerics;

namespace Project_Euler
{
    internal class P025
    {
        /*
         * Problem 25: 1000-digit Fibonacci number
         * The Fibonacci sequence is defined by the recurrence relation:
         * Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
         * Hence the first 12 terms will be: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
         * The 12th term, F12, is the first term to contain three digits.
         * What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
         */

        public static int Solve()
        {
            bool foundTerm = false;
            var sequence = new List<BigInteger>() { 1, 1, 2 };
            int i = 3;
            while (!foundTerm)
            {
                sequence.Add(sequence[i - 1] + sequence[i - 2]);
                if (sequence[i].ToString().Length == 1000)
                {
                    foundTerm = true;
                    return i + 1;
                }
                i++;
            }
            return 0;
        }
    }
}