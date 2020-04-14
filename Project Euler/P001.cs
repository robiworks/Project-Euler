namespace Project_Euler
{
    internal class P001
    {
        public static int Solve()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 | i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}