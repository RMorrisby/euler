using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler3a
{

    /*
     * Class containing helper methods related to prime numbers 
     * 
     * TODO Unit tests!
     */
    public class PrimeHelper
    {
        /*
         * Definition of prime : only divisible by itself and 1. Therefore, a prime number has only one prime factor : itself (1 is not prime)
         */
        public static bool IsPrime(long num)
        {
            // Some safety - don't evaluate numbers < 2, instead immediately return false
            if (num < 2)
            {
                return false;
            }

            List<long> primeFactors = GetPrimeFactors(num);
            //p($"Prime factors of {num} :: {string.Join(", ", primeFactors)}");
            return (primeFactors.Count == 1);
        }

        public static long GetLargestPrimeFactor(long num)
        {
            // Some safety - don't evaluate numbers < 2, instead immediately return null
            if (num < 2)
            {
                throw new InvalidOperationException("Don't call getLargestPrimeFactor() with a number less than 2");
            }

            List<long> primeFactors = GetPrimeFactors(num);
            primeFactors.Sort();
            return primeFactors.Last();
        }

        /*
         * For the given int, return the list of its prime factors. Will include itself if it is prime.
         * Will not compress the list (i.e. the list may naturally return duplicates)
         */
        public static List<long> GetPrimeFactors(long num)
        {
            List<long> primeFactors = new List<long>();
            // Some safety - don't evaluate numbers < 2, instead immediately return the empty list
            if (num < 2)
            {
                return primeFactors;
            }

            LowestAndHighestFactor factorPair = GetLowestAndHighestFactor(num);
            long lowestFactor = factorPair.lowest;
            long highestFactor = factorPair.highest;

            // If the highest factor is itself, it is prime
            if (highestFactor == num)
            {
                primeFactors.Add(highestFactor);
                return primeFactors;
            }

            primeFactors.AddRange(GetPrimeFactors(highestFactor));
            primeFactors.Add(lowestFactor);

            return primeFactors;
        }

        /*
         * For the given int, determine the lowest and highest factor (not necessarily prime, and not including 1) and return a LowestAndHighestFactor object.
         * E.g. for 24, this method would return 2 and 12; 19 would return 19 and 19.
         */
        public static LowestAndHighestFactor GetLowestAndHighestFactor(long num)
        {
            // Some safety - don't evaluate numbers < 2, instead immediately return null
            if (num < 2)
            {
                throw new InvalidOperationException("Don't call getLowestAndHighestFactor() with a number less than 2");
            }

            bool found = false;

            long lowest = 2;
            long highest = num / lowest;

            while (lowest <= highest)
            {
                if (num % lowest == 0)
                {
                    found = true;
                    break;
                }
                else
                {
                    lowest++;
                }
            }

            if (found)
            {
                highest = num / lowest;
            }
            else
            {
                highest = num;
                lowest = num;
            }
            LowestAndHighestFactor pair = new LowestAndHighestFactor(lowest, highest);
            return pair;
        }

        public static void P(Object s)
        {
            Console.WriteLine(s);
        }
    }

    /*
     * Simple struct that holds two longs. Intended to hold the lowest and highest factor of a number (such that lowest * highest == the number)
     */
    public struct LowestAndHighestFactor
    {
        public long lowest;
        public long highest;

        public LowestAndHighestFactor(long lowest, long highest)
        {
            this.lowest = lowest;
            this.highest = highest;
        }
    }
}
