using System;
using static Euler3.PrimeHelper;

// Problem 3 : find the largest prime factor of a number

namespace Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 2; i < 30; i++)
            //{
            //    p($"{i} :: {isPrime(i)}");
            //}
            long k = 600851475143;
            p($"{k} :: {isPrime(k)}");
            p($"{k} :: {getLargestPrimeFactor(k)}");
        }


        public static void p(Object s)
        {
            Console.WriteLine(s);
        }
    }
}
