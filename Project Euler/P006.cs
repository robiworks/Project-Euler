namespace Project_Euler
{
    internal class P006
    {
        public static int Solve()
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }
            int sumOfElements = (100 * (1 + 100)) / 2;
            int squareOfSum = sumOfElements * sumOfElements;
            return squareOfSum - sumOfSquares;
        }
    }
}