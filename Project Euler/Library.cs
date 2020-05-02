using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project_Euler
{
    internal class Library
    {
        /*
         * Library of mathematical functions for use in my Project Euler solutions.
         */

        public static List<int> FindPrimes(int max) // Sieve of Eratosthenes up to given maximum
        {
            bool[] isPrime = new bool[max + 1];
            for (int n = 2; n < max; n++)
            {
                isPrime[n] = true;
            }
            int root = Convert.ToInt32(Math.Sqrt(max));
            for (int i = 2; i < root; i++)
            {
                if (isPrime[i] == true)
                {
                    for (int j = i * i; j < max; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            List<int> primes = new List<int>();
            for (int k = 2; k < max; k++)
            {
                if (isPrime[k] == true)
                {
                    primes.Add(k);
                }
            }
            return primes;
        }

        public static List<int> FibonacciSequence(int index) // Generate Fibonacci sequence up to n-th index
        {
            List<int> sequence = new List<int>() { 0, 1, 1, 2 };
            for (int i = 4; i <= index; i++)
            {
                int nextTerm = sequence[i - 1] + sequence[i - 2];
                sequence.Add(nextTerm);
            }
            return sequence;
        }

        public static int GCD(int m, int n) // Euclidean algorithm
        {
            if (m < n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            while (n != 0)
            {
                int r = m % n;
                m = n;
                n = r;
            }
            return m;
        }

        public static int LCM(int a, int b) // Least common multiple using GCD
        {
            int lcm = (Math.Abs(a) / GCD(a, b)) * Math.Abs(b);
            return lcm;
        }

        public static long Factorial(long n) // Factorial function for smaller numbers
        {
            if (n == 0)
            {
                return 1;
            }
            long fac = 1;
            for (long i = n; i > 1; i--)
            {
                fac *= i;
            }
            return fac;
        }

        public static BigInteger BigFactorial(BigInteger n) // Factorial function for big numbers
        {
            if (n == 0)
            {
                return 1;
            }
            BigInteger fac = 1;
            for (BigInteger i = n; i > 1; i--)
            {
                fac *= i;
            }
            return fac;
        }

        public static bool IsPrime(int number) // Simple algorithm for checking if number is prime
        {
            List<int> precomputedPrimes = FindPrimes(500);
            foreach (int prime in precomputedPrimes)
            {
                if (number % prime == 0)
                {
                    return false;
                }
            }
            if (number <= 3)
            {
                return (number > 1);
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }

        public static bool IsPalindrome(int number) // Check if a number is palindrome
        {
            char[] arr = number.ToString().ToCharArray();
            Array.Reverse(arr);
            string reversedNumber = new string(arr);
            if (number.ToString() == reversedNumber)
            {
                return true;
            }
            return false;
        }

        public static bool IsPalindrome(ulong binaryNumber) // Check if a binary number is palindrome
        {
            char[] arr = binaryNumber.ToString().ToCharArray();
            Array.Reverse(arr);
            string reversedNumber = new string(arr);
            if (binaryNumber.ToString() == reversedNumber)
            {
                return true;
            }
            return false;
        }

        public static List<int> RotateDigits(int number)
        {
            List<int> rotations = new List<int>();
            rotations.Add(number);
            int digits = number.ToString().Length;
            int exp = (int)Math.Pow(10, digits - 1);
            for (int i = 0; i < digits - 1; i++)
            {
                int firstDigit = number / exp;
                int rot = (number * 10) + firstDigit - (firstDigit * exp * 10);
                number = rot;
                if (rot.ToString().Length == digits && !rotations.Contains(rot))
                {
                    rotations.Add(rot);
                }
            }
            return rotations;
        }

        public static ulong ToBinary(int base10number)
        {
            string temp = Convert.ToString(base10number, 2);
            ulong binary = ulong.Parse(temp);
            return binary;
        }
    }
}