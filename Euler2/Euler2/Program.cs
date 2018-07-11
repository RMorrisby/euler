
using System;
using System.Collections;
using System.Linq;

namespace Euler2
{
    class Program
    {

        static void Main(string[] args)
        {
            var limit = 4000000; // 4 million
            //var limit = 100;
            ArrayList evens = new ArrayList();

            var fib_a = 0;
            var fib_b = 1;
            var fib_c = 1;

            while (true)
            {
                // Determine next Fibonacci number
                fib_c = new_fib(fib_a, fib_b);

                // If above the limit, stop the loop
                if (fib_c >= limit)
                {
                    break;
                }

                // If it's even, store it
                if (fib_c % 2 == 0)
                {
                    evens.Add(fib_c);
                }

                // Reassign fib_a and _b
                fib_a = fib_b;
                fib_b = fib_c;

            }

            int sum = evens.Cast<int>().Sum();

            p($"Sum of even Fibonacci numbers lower than {limit} is {sum}");
        }


        public static void p(Object s)
        {
            Console.WriteLine(s);
        }

        private static int new_fib(int fib_a, int fib_b)
        {
            return fib_a + fib_b;
        }

    }
}
