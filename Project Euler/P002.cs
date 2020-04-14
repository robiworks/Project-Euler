namespace Project_Euler
{
    internal class P002
    {
        public static int Solve()
        {
            int a = 1;
            int b = 2;
            int sum = 2; // 2 is even valued so included from the start
            while (b < 4000000)
            {
                int t = a + b;
                a = b;
                b = t;
                if (t % 2 == 0)
                {
                    sum += t;
                }
            }
            return sum;
        }
    }
}