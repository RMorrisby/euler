using System;
using Euler36b;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler36bTest
{

    // Only one method available to test, so can't write very many tests

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSolver()
        {
            int limit = 1000000; // 1 million
            int expected = 872187;

            Euler36bSolver euler36Solver = new Euler36bSolver();
            long total = euler36Solver.Solve(limit);

            Assert.AreEqual(expected, total, "Euler36bSolver produced the wrong result");
        }

        [TestMethod]
        public void TestSolver2()
        {
            int limit = 10000; // 10 thousand
            int expected = 18228;

            Euler36bSolver euler36Solver = new Euler36bSolver();
            long total = euler36Solver.Solve(limit);

            Assert.AreEqual(expected, total, "Euler36bSolver produced the wrong result");
        }
    }
}
