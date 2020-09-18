using System;
using System.Collections.Generic;

namespace Summation
{
    public class Logic
    {
        public static long Summation(long n)
        {

            //Recursive
            /*if (n == 0)
            {
                return 0;
            } 
            else
            {
                long nextNumber = Summation(n - 1);
                return n + nextNumber;
            }*/


            //Iterative
            /*long result = 0;

            for (long i = n; i > 0; i--)
            {
                result = result + i;
            }

            return result;*/


            //Stack
            Stack<long> stack = new Stack<long>();

            while (n != 0)
            {
                stack.Push(n);
                n = n - 1;
            }

            long result = 0;

            while (stack.Count != 0)
            {
                result = result + stack.Pop();
            }

            return result;
        }
    }
}
