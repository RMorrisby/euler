using System;
using System.Collections.Generic;
using System.Linq;

//Find the sum of all base-10 numbers, less than one million, which are palindromic in base-10 and base-2

// A really proper OO-design, most definitely excessive for this task...

namespace Euler36e
{
    class Euler36e
    {
        static void Main(string[] args)
        {
            int limit = 1000000; // 1 million

            var total = Euler36eSolver.Solve(limit);

            Console.WriteLine($"Euler 36e Solver reports the total of all base-10 and base-2 palendromes is {total}");
        }

    }
}
