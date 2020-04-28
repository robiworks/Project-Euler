namespace Project_Euler
{
    internal class P015
    {
        /*
         * Problem 15: Lattice paths
         * Starting in the top left corner of a 2x2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
         * How many such routes are there through a 20x20 grid?
         */

        public static long Solve()
        {
            long numberOfPaths = 1;
            for (long n = 0; n < 20; n++)
            {
                numberOfPaths = numberOfPaths * (2 * 20 - n);
                numberOfPaths = numberOfPaths / (n + 1);
            }
            return numberOfPaths;
        }
    }
}