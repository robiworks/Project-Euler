using System;

namespace Project_Euler
{
    internal class P003
    {
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