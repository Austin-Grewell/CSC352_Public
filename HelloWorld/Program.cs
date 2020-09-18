using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            static bool IsEven(int i)
            {
                return i % 2 == 0;
            }
        }
    }
}
