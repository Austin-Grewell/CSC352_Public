﻿using System;

namespace GCD
{
    public class Logic
    {
        public static long gcd(long x, long y)
        {
            /*if (y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }*/


            //Iterative Brute Force
            /*long result = 0;

            for (long i = 1; i <= x; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    result = i;
                }
            }

            return result;*/


            //Iterative 
            long gcd = 0;

            while (y != 0)
            {
                long modXY = x % y;
                gcd = y;
                y = x % y;
                x = gcd;
            }

            return gcd;
        }
    }
}
