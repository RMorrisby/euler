using System;
using System.Collections.Generic;
using System.Linq;

//Find the sum of all base-10 numbers, less than one million, which are palindromic in base-10 and base-2

// The next step to a proper OO-design - move the solver into its own class

namespace Euler36b
{
    class Euler36b
    {
        static void Main(string[] args)
        {
            int limit = 1000000; // 1 million

            Euler36bSolver euler36Solver = new Euler36bSolver();
            var total = euler36Solver.Solve(limit);

            Console.WriteLine($"Euler 36b Solver reports the total of all base-10 and base-2 palendromes is {total}");
        }

    }
}
