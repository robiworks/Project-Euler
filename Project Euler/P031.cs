﻿namespace Project_Euler
{
    internal class P031
    {
        /*
         * Problem 31: Coin sums
         * In the United Kingdom the currency is made up of pound (£) and pence (p). There are eight coins in general circulation:
         * 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p), and £2 (200p).
         * It is possible to make £2 in the following way:
         * 1 * £1 + 1 * 50p + 2 * 20p + 1 * 5p + 1 * 2p + 3 * 1p
         * How many different ways can £2 be made using any number of coins?
         */

        public static int Solve()
        {
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            var ways = new int[201];
            ways[0] = 1;
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= 200; j++)
                {
                    ways[j] += ways[j - coins[i]];
                }
            }
            return ways[200];
        }
    }
}