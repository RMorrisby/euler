using System;
using System.Collections.Generic;
using System.Linq;

//Find the sum of all base-10 numbers, less than one million, which are palindromic in base-10 and base-2

// Closer to a proper OO-design - move the solver into its own class and separate the Solve() method into sub-methods to avoid duplicating code

namespace Euler36c
{
    class Euler36c
    {
        static void Main(string[] args)
        {
            int limit = 1000000; // 1 million

            Euler36cSolver euler36Solver = new Euler36cSolver();
            var total = euler36Solver.Solve(limit);

            Console.WriteLine($"Euler 36c Solver reports the total of all base-10 and base-2 palendromes is {total}");
        }

    }
}
