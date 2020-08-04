﻿namespace Project_Euler
{
    internal class P009
    {
        /*
         * Problem 9: Special Pythagorean triplet
         * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
         * a^2 + b^2 = c^2
         * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
         * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
         * Find the product abc.
         */

        public static int Solve()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    int c = 1000 - b - a;
                    if ((a * a) + (b * b) == (c * c))
                    {
                        return a * b * c;
                    }
                }
            }
            return 0;
        }
    }
}