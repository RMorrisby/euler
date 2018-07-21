using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Euler36b
{
    /// <summary>
    /// Class that actually solves Euler problem 36
    /// </summary>
   public class Euler36bSolver
    {

        /// <summary>
        /// Solves Euler problem 36 for a given maximum number, up to Int32.MaxValue
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>long</returns>
        public long Solve(int limit)
        {
            int maxLimit = Int32.MaxValue;
            if (limit > maxLimit)
            {
                throw new Exception($"Euler36Solver.Solve cannot solve for numbers greater than {maxLimit}");
            }

            var palendromes = new HashSet<int>();
            for (int i = 1; i < limit; i++)
            {
                // Convert to String, reverse & compare - is it a palendrome?
                String base10String = i.ToString();
                char[] base10CharArray = i.ToString().ToCharArray();
                Array.Reverse(base10CharArray);
                String base10Reverse = new String(base10CharArray);

                if (base10String != base10Reverse)
                {
                    //Console.WriteLine($"{i} was not a palendrome");
                    continue;
                }

                // Is the number a base-2 palendrome?
                String base2String = Convert.ToString(i, 2);

                char[] base2CharArray = base2String.ToCharArray();
                Array.Reverse(base2CharArray);
                String base2Reverse = new String(base2CharArray);

                if (base2String != base2Reverse)
                {
                    //Console.WriteLine($"{i} was not a base-2 palendrome");
                    continue;
                }

                Console.WriteLine($"{i} :: {base2String} was a base-10 and base-2 palendrome");
                palendromes.Add(i);
            }

            long total = palendromes.ToList().Sum();
            return total;
        }
    }
}
