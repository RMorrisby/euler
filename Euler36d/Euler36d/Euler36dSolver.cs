using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Euler36d.PalendromeHelper;

namespace Euler36d
{
    /// <summary>
    /// Class that actually solves Euler problem 36
    /// </summary>
   public class Euler36dSolver
    {

        /// <summary>
        /// Solves Euler problem 36 for a given maximum number, up to Int32.MaxValue
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

            var palendromes = new HashSet<int>();
            for (int i = 1; i < limit; i++)
            {
                if (!IsBase10Palendrome(i))
                {
                    continue;
                }

                if (!IsBase2Palendrome(i))
                {
                    continue;
                }

                Console.WriteLine($"{i} was a base-10 and base-2 palendrome");
                palendromes.Add(i);
            }

            long total = palendromes.ToList().Sum();
            return total;
        }

    }
}
