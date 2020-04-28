namespace Project_Euler
{
    internal class P028
    {
        /*
         * Problem 28: Number spiral diagonals
         * Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
         * 21 22 23 24 25
         * 20  7  8  9 10
         * 19  6  1  2 11
         * 18  5  4  3 12
         * 17 16 15 14 13
         * It can be verified that the sum of the numbers on the diagonals is 101.
         * What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
         */

        public static int Solve()
        {
            int sum = 1;                                            // 1 is added at the start for the centre point
            for (int n = 1; n <= 500; n++)                          // upper right corner is (2n+1)^2
            {                                                       // moving left, (2n+1)^2 - 2n
                sum += 4 * (2 * n + 1) * (2 * n + 1) - 12 * n;      // moving down, (2n+1)^2 - 4n
            }                                                       // moving right, (2n+1)^2 - 6n
            return sum;
        }
    }
}