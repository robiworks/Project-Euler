using System;
using System.Diagnostics;

namespace Project_Euler
{
    internal class Program
    {
        private static void Main()
        {
            var timer = Stopwatch.StartNew();
            Console.WriteLine(P036.Solve());
            Console.WriteLine("Solution took {0} ms", timer.ElapsedMilliseconds);
        }
    }
}