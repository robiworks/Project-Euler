using System.Collections.Generic;

namespace Project_Euler
{
    internal class P017
    {
        /*
         * Problem 17: Number letter counts
         * If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
         * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
         * NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
         */

        public static int Solve()
        {
            int totalLetters = 0;
            for (int i = 1; i <= 1000; i++)
            {
                totalLetters += GetWordLength(i);
            }
            return totalLetters;
        }

        public static int GetWordLength(int number)
        {
            var basicNumbers = new Dictionary<int, string>() { { 0, "" }, { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" } };
            var multiplesOfTen = new Dictionary<int, string>() { { 0, "" }, { 10, "ten" }, { 20, "twenty" }, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty" }, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" }, { 100, "hundred" }, { 1000, "thousand" } };
            var numbersTo20 = new Dictionary<int, string>() { { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen" }, { 14, "fourteen" }, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen" }, { 18, "eighteen" }, { 19, "nineteen" } };
            string num = number.ToString();
            string word;
            int tens;
            int ones;
            string tensWord;
            string onesWord;
            switch (num.Length)
            {
                case 1:
                    word = basicNumbers[number];
                    return word.Length;

                case 2:
                    if (multiplesOfTen.ContainsKey(number))
                    {
                        word = multiplesOfTen[number];
                        return word.Length;
                    }
                    else if (numbersTo20.ContainsKey(number))
                    {
                        word = numbersTo20[number];
                        return word.Length;
                    }
                    else
                    {
                        tens = int.Parse(num.Substring(0, 1)) * 10;
                        ones = int.Parse(num.Substring(1));
                        tensWord = multiplesOfTen[tens];
                        onesWord = basicNumbers[ones];
                        return tensWord.Length + onesWord.Length;
                    }
                case 3:
                    int hundreds = int.Parse(num.Substring(0, 1));
                    string hundredsWord = basicNumbers[hundreds] + "hundred";
                    tens = int.Parse(num.Substring(1, 1)) * 10;
                    ones = int.Parse(num.Substring(2));
                    tensWord = multiplesOfTen[tens];
                    onesWord = basicNumbers[ones];
                    if (tens == 0 && ones == 0)
                    {
                        return hundredsWord.Length + tensWord.Length + onesWord.Length;
                    }
                    else
                    {
                        if (numbersTo20.ContainsKey(tens + ones))
                        {
                            word = numbersTo20[tens + ones];
                            return hundredsWord.Length + word.Length + 3;
                        }
                        else
                        {
                            return hundredsWord.Length + tensWord.Length + onesWord.Length + 3;
                        }
                    }
                case 4: // one thousand
                    return 11;
            }
            return 0;
        }
    }
}