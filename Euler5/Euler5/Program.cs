using System;


//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


/*
 * The code below solves the problem, in a very brute-force way. There are numerous ways to speed up the code (e.g. if the number % 20 == 0, then you know it will also divide by 2, 4, 5 and 10).
 * This solution is deliberately verbose so as to explain the basic strategy.
 */
namespace Euler5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* First, establish an upper limit
            * By definition, 1*2*3*4*5*6*7*8*9*10*11*12*13*14*15*16*17*18*19*20 is evenly divisible by all numbers 1 - 20
            * The real answer will be MUCH smaller than this
            */
            long max = 1;
            for (int i = 1; i <= 20; i++)
            {
                max = max * i;
            }


            /*
             * Since the problem wants to find the *smallest* number, start from a small number and work upwards until 
             * a number is found that is evenly divisible by all numbers 1 - 20. Do not search upwards to infinity, only
             * to the "reasonable" maximum.
             */
            bool found = false;
            int evenlyDivisibleNumberCount = 0; // how many of 1 - 20 does the candidate number divide evenly by?
            long number = 2520;
            while (number < max)
            {
                // For each candidate number, try dividing it by 1 - 20; 
                // if any fail to divide evenly, move on to the next candidate
                for (int i = 1; i <= 20; i++)
                {
                    if (number % i == 0)
                    {
                        evenlyDivisibleNumberCount++;
                    }
                    else
                    {
                        // The candidate has failed one of the division-criteria, so immediately move on to the next candidate
                        break; // break out of the for-loop
                    }
                } // end for i

                // If the candidate was evenly-divisible by all of 1 - 20, evenlyDivisibleNumberCount should be 20
                if (evenlyDivisibleNumberCount == 20)
                {
                    found = true;
                }

                // If we've found a number satisfying all criteria, break out of the while-loop
                if (found)
                {
                    break;
                }

                // If we get to this point, the candidate number was not successful, so move on to the next number
                evenlyDivisibleNumberCount = 0;
                number++;

            } // end while

            if (found)
            {
                Console.WriteLine($"Found answer : {number}");
            }
            else
            {
                Console.WriteLine("Failed to find answer");
            }
        }
    }
}
