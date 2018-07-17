using System;
using System.Collections.Generic;
using System.Text;

// More concise solution
namespace Euler5
{
    class Program2
    {
        static void Main(string[] args)
        {
            long number = 2520; // start with this number and work upwards
            int evenlyDivisibleNumberCount = 0; // how many of 1 - 20 does the candidate number divide evenly by?
            long max = 1;
            for (int i = 1; i <= 20; i++)
            {
                max *= i;
            }

            while (number < max)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (number % i != 0)
                    {
                        break;
                    }
                    evenlyDivisibleNumberCount++;
                } // end for i

                if (evenlyDivisibleNumberCount == 20)
                {
                    break;
                }

                // If we get to this point, the candidate number was not successful, so move on to the next number
                evenlyDivisibleNumberCount = 0;
                number++;
            } // end while

            Console.WriteLine($"Found answer : {number}");
        }
    }
}
