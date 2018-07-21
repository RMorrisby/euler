using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Euler36e.PalendromeHelper;

namespace Euler36e
{
    /// <summary>
    /// Class that actually solves Euler problem 36
    /// </summary>
   public class Euler36eSolver
    {

        /// <summary>
        /// Solves Euler problem 36 for a given maximum number, from 10 up to Int32.MaxValue
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>long</returns>
        public static long Solve(int limit)
        {
            int maxLimit = Int32.MaxValue;
            if (limit > maxLimit)
            {
                throw new Exception($"Euler36Solver.Solve cannot solve for numbers greater than {maxLimit}");
            }

            if (limit < 10)
            {
                throw new ArgumentException($"Euler36Solver.Solve cannot solve for numbers less than 10");
            }


            var palendromes = new HashSet<Euler36Number>();
            for (int i = 1; i < limit; i++)
            {
                Euler36Number eNumber = new Euler36Number(i);
                
                if (!eNumber.IsBase10Palendrome)
                {
                    continue;
                }

                if (!eNumber.IsBase2Palendrome)
                {
                    continue;
                }

                Console.WriteLine($"{eNumber.Number} was a base-10 and base-2 palendrome");
                palendromes.Add(eNumber);
            }

            long total = 0;
            foreach (Euler36Number e in palendromes)
            {
                total = total + e.Number;
            }
            return total;
        }

    }
}
