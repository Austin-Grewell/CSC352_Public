namespace FunWithLoops
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        internal static IEnumerable<int> NumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> EvenNumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> OddNumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> PrimeNumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static bool IsPrime(int number)
        {
            bool isPrime = true;

            //Any Positive Integer
            //can't be even
            //Divisible by 1 and itself

            if(number == 2)
            {
                isPrime = true;
            }

            else if(number > 2)
            {
                if (number % 2 == 0)
                {
                    isPrime = false;
                }

                else
                {
                    isPrime = true;

                    for(int i = 3; i < number; i++)
                    {
                        if(number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
            }

            throw new NotImplementedException();
        }

        internal static IEnumerable<int> GetNumbersOneThru(int thruInclusive)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> GetRangeThruInclusive(int start, int end)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> GetPrimesInRangeInclusive(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
