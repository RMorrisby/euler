using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Euler36c
{
    /// <summary>
    /// Class that actually solves Euler problem 36
    /// </summary>
    public class Euler36cSolver
    {

        /// <summary>
        /// Solves Euler problem 36 for a given maximum number, from 10 up to Int32.MaxValue
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>long</returns>
        public long Solve(int limit)
        {
            int maxLimit = Int32.MaxValue;
            if (limit > maxLimit)
            {
                throw new ArgumentException($"Euler36Solver.Solve cannot solve for numbers greater than {maxLimit}");
            }

            if (limit < 10)
            {
                throw new ArgumentException($"Euler36Solver.Solve cannot solve for numbers less than 10");
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

        /// <summary>
        /// Is the supplied base-10 int a palendrome?
        /// </summary>
        /// <param name="i"></param>
        /// <returns>bool</returns>
        public static bool IsBase10Palendrome(int i)
        {
            // Convert to String, reverse & compare - is it a palendrome?
            String base10String = i.ToString();
            char[] base10CharArray = i.ToString().ToCharArray();
            Array.Reverse(base10CharArray);
            String base10Reverse = new String(base10CharArray);

            return (base10String == base10Reverse);            
        }

        /// <summary>
        /// Is the supplied base-10 int a palendrome when it is converted into a base-2 int?
        /// </summary>
        /// <param name="i"></param>
        /// <returns>bool</returns>
        public static bool IsBase2Palendrome(int i)
        {
            // Convert to base-2, convert to String, reverse & compare - is it a palendrome?
            String base2String = Convert.ToString(i, 2);

            char[] base2CharArray = base2String.ToCharArray();
            Array.Reverse(base2CharArray);
            String base2Reverse = new String(base2CharArray);

            return (base2String == base2Reverse);
        }
    }
}
