using System;
using System.Collections.Generic;
using System.Linq;

//Find the sum of all base-10 numbers, less than one million, which are palindromic in base-10 and base-2

// A proper OO-design

namespace Euler36d
{
    class Euler36d
    {
        static void Main(string[] args)
        {
            int limit = 1000000; // 1 million

            var total = Euler36dSolver.Solve(limit);

            Console.WriteLine($"Euler 36d Solver reports the total of all base-10 and base-2 palendromes is {total}");
        }

    }
}
