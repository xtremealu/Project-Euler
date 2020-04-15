﻿using System;

namespace Project_Euler
{
    internal class P012
    {
        /*
         * The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
         * 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
         * Let us list the factors of the first seven triangle numbers:
         * 1: 1
         * 3: 1,3
         * 6: 1,2,3,6
         * 10: 1,2,5,10
         * 15: 1,3,5,15
         * 21: 1,3,7,21
         * 28: 1,2,4,7,14,28
         * We can see that 28 is the first triangle number to have over five divisors.
         * What is the value of the first triangle number to have over five hundred divisors?
         */

        public static int Solve()
        {
            // Formula for n-th triangle number is n(n+1)/2
            int i = 1;
            int number = 0;
            while (NumOfDivisors(number) < 500)
            {
                number = i * (i + 1) / 2;
                i += 1;
            }
            return number;
        }

        private static int NumOfDivisors(int number)
        {
            int divisors = 0;
            int sqrt = (int)Math.Sqrt(number);
            for (int d = 1; d <= sqrt; d++)
            {
                if (number % d == 0)
                {
                    divisors += 2;
                }
            }
            if (sqrt * sqrt == number)
            {
                divisors -= 1;
            }
            return divisors;
        }
    }
}