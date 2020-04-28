using System;
using System.Collections.Generic;
using System.IO;

namespace Project_Euler
{
    internal class P022
    {
        /*
         * Problem 22: Names scores
         * Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
         * Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
         * For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 * 53 = 49714.
         * What is the total of all the name scores in the file?
         */

        public static int Solve()
        {
            var fileContents = File.ReadAllText("D:/Robert/CSharp/p022_names.txt").Replace("\"", "");
            string[] content = fileContents.Split(",");
            var names = new List<string>(content);
            names.Sort();
            var alphaValues = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int sum = 0;
            foreach (string name in names)
            {
                var arr = name.ToCharArray();
                int nameScore = 0;
                foreach (char c in arr)
                {
                    nameScore += Array.FindIndex(alphaValues, ch => ch == c) + 1;
                }
                nameScore *= names.IndexOf(name) + 1;
                sum += nameScore;
            }
            return sum;
        }
    }
}