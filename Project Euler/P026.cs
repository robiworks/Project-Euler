namespace Project_Euler
{
    internal class P026
    {
        /*
         * A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
         * 1/2 = 0.5 | 1/3 = 0.(3) | 1/4 = 0.25 | 1/5 = 0.25 | 1/6 = 0.1(6) | 1/7 = 0.(142857) | 1/8 = 0.125 | 1/9 = 0.(1) | 1/10 = 0.1
         * Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
         * Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
         */

        public static int Solve() // thanks to mathblog.dk, had no idea how to solve this without checking every double
        {
            int cycleLength = 0;
            int n = 0;
            for (int i = 1000; i > 1; i--)
            {
                if (cycleLength >= i)
                {
                    break;
                }
                var remainders = new int[i];
                int val = 1;
                int pos = 0;
                while (remainders[val] == 0 && val != 0)
                {
                    remainders[val] = pos;
                    val = val * 10;
                    val = val % i;
                    pos++;
                }
                if (pos - remainders[val] > cycleLength)
                {
                    n = i;
                    cycleLength = pos - remainders[val];
                }
            }
            return n;
        }
    }
}