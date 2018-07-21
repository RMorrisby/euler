using System;
using System.Collections.Generic;
using System.Linq;

//Find the sum of all base-10 numbers, less than one million, which are palindromic in base-10 and base-2

namespace Euler36a
{
    class Euler36a
    {
        static void Main(string[] args)
        {
            Euler36a euler36Solver = new Euler36a();
            euler36Solver.Solve();
        }

        public void Solve() { 

            int limit = 1000000; // 1 million
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
            Console.WriteLine($"Solver reports the total of all base-10 and base-2 palendromes is {total}");
        }
    }
}
