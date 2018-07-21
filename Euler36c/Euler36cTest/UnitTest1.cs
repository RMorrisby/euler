using System;
using Euler36c;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler36cTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSolver()
        {
            int limit = 1000000; // 1 million
            int expected = 872187;

            Euler36cSolver euler36Solver = new Euler36cSolver();
            long total = euler36Solver.Solve(limit);

            Assert.AreEqual(expected, total, "Euler36cSolver produced the wrong result");
        }

        [TestMethod]
        public void TestSolver2()
        {
            int limit = 10000; // 10 thousand
            int expected = 18228;

            Euler36cSolver euler36Solver = new Euler36cSolver();
            long total = euler36Solver.Solve(limit);

            Assert.AreEqual(expected, total, "Euler36cSolver produced the wrong result");
        }

        [TestMethod]
        public void TestIsBase10Palendrome()
        {
            int p = 98789;
            int notP = 98799;

            bool isP = Euler36cSolver.IsBase10Palendrome(p);

            Assert.IsTrue(isP, "IsBase10Palendrome did not detect a base-10 palendrome");

            bool isNotP = Euler36cSolver.IsBase10Palendrome(notP);

            Assert.IsFalse(isNotP, "IsBase10Palendrome claimed a non-palendrome was a base-10 palendrome");
        }

        [TestMethod]
        public void TestIsBase2Palendrome()
        {
            int p = 9; // is 1001 in base-2
            int notP = 11;

            bool isP = Euler36cSolver.IsBase2Palendrome(p);

            Assert.IsTrue(isP, "IsBase2Palendrome did not detect a base-2 palendrome");

            bool isNotP = Euler36cSolver.IsBase2Palendrome(notP);

            Assert.IsFalse(isNotP, "IsBase10Palendrome claimed a non-palendrome was a base-2 palendrome");
        }

        [TestMethod]
        public void TestSolverSmallNumber()
        {
            try
            {
                int limit = 5;
                Euler36cSolver euler36Solver = new Euler36cSolver();
                long total = euler36Solver.Solve(limit);
                Assert.Fail(); // if Solve() doesn't throw an exception, the test has failed
            }
            catch (ArgumentException e)
            {
                String expectedMessage = "Euler36Solver.Solve cannot solve for numbers less than 10";
                Assert.AreEqual(expectedMessage, e.Message);                
            }
            catch (Exception)
            {
                // not the right kind of exception
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestSolverNegativeNumber()
        {
            try
            {
                int limit = -1000;
                Euler36cSolver euler36Solver = new Euler36cSolver();
                long total = euler36Solver.Solve(limit);
                Assert.Fail(); // if Solve() doesn't throw an exception, the test has failed
            }
            catch (ArgumentException e)
            {
                String expectedMessage = "Euler36Solver.Solve cannot solve for numbers less than 10";
                Assert.AreEqual(expectedMessage, e.Message);
            }
            catch (Exception)
            {
                // not the right kind of exception
                Assert.Fail();
            }
        }

    }
}
