using System.Collections.Generic;

namespace Project_Euler
{
    internal class P005
    {
        public static int Solve()
        {
            var divisibles = new List<bool>();
            int num = 20;
            while (divisibles.Count != 20)
            {
                divisibles.Clear();
                for (int i = 1; i <= 20; i++)
                {
                    if (num % i == 0)
                    {
                        divisibles.Add(true);
                    }
                    else
                    {
                        break;
                    }
                }
                if (divisibles.Count == 20)
                {
                    return num;
                }
                num += 1;
            }
            return num;
        }
    }
}