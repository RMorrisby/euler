using System;
using Euler36d;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler36dTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSolver()
        {
            int limit = 1000000; // 1 million
            int expected = 872187;

            long total = Euler36dSolver.Solve(limit);

            Assert.AreEqual(expected, total, "Euler36dSolver produced the wrong result");
        }

        [TestMethod]
        public void TestSolver2()
        {
            int limit = 10000; // 10 thousand
            int expected = 18228;

            long total = Euler36dSolver.Solve(limit);

            Assert.AreEqual(expected, total, "Euler36dSolver produced the wrong result");
        }

        [TestMethod]
        public void TestIsBase10Palendrome()
        {
            int p = 98789;
            int notP = 98799;

            bool isP = PalendromeHelper.IsBase10Palendrome(p);

            Assert.IsTrue(isP, "IsBase10Palendrome did not detect a base-10 palendrome");

            bool isNotP = PalendromeHelper.IsBase10Palendrome(notP);

            Assert.IsFalse(isNotP, "IsBase10Palendrome claimed a non-palendrome was a base-10 palendrome");
        }

        [TestMethod]
        public void TestIsBase2Palendrome()
        {
            int p = 9; // is 1001 in base-2
            int notP = 11;

            bool isP = PalendromeHelper.IsBase2Palendrome(p);

            Assert.IsTrue(isP, "IsBase2Palendrome did not detect a base-2 palendrome");

            bool isNotP = PalendromeHelper.IsBase2Palendrome(notP);

            Assert.IsFalse(isNotP, "IsBase2Palendrome claimed a non-palendrome was a base-2 palendrome");
        }

        [TestMethod]
        public void TestIsBaseNPalendrome1()
        {
            int p = 9; // is 1001 in base-2
            int notP = 11;
            int baseN = 2;

            bool isP = PalendromeHelper.IsBaseNPalendrome(p, baseN);

            Assert.IsTrue(isP, $"IsBaseNPalendrome did not detect a base-{baseN} palendrome");

            bool isNotP = PalendromeHelper.IsBaseNPalendrome(notP, baseN);

            Assert.IsFalse(isNotP, "IsBaseNPalendrome claimed a non-palendrome was a base-2 palendrome");
        }

        [TestMethod]
        public void TestIsBaseNPalendrome2()
        {
            int p = 98789;
            int notP = 98799;
            int baseN = 10;

            bool isP = PalendromeHelper.IsBaseNPalendrome(p, baseN);

            Assert.IsTrue(isP, $"IsBaseNPalendrome did not detect a base-{baseN} palendrome");

            bool isNotP = PalendromeHelper.IsBaseNPalendrome(notP, baseN);

            Assert.IsFalse(isNotP, $"IsBaseNPalendrome claimed a non-palendrome was a base-{baseN} palendrome");
        }

        [TestMethod]
        public void TestStringIsPalendrome()
        {
            String p = "hannah";
            String notP = "palendrome";

            bool isP = PalendromeHelper.IsPalendrome(p);

            Assert.IsTrue(isP, $"IsPalendrome did not detect a palendrome");

            bool isNotP = PalendromeHelper.IsPalendrome(notP);

            Assert.IsFalse(isNotP, $"IsPalendrome claimed a non-palendrome was a palendrome");
        }

        [TestMethod]
        public void TestSolverSmallNumber()
        {
            try
            {
                int limit = 5;
                long total = Euler36dSolver.Solve(limit);
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
                long total = Euler36dSolver.Solve(limit);
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
