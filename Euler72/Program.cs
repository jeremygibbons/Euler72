using System;

namespace Euler72
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = 0;

            for(int d = 2; d < 1000000; d++)
            {
                for(int n = 1; n < d; n++)
                {
                    if (GCD(n, d) == 1)
                        count++;
                }
            }
            Console.WriteLine(count);
        }

        public static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }
    }
}
