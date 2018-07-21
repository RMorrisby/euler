using System;
using Euler3a;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler3aTest
{
    [TestClass]
    public class PrimeHelperTests
    {

        [TestMethod]
        public void TestBasicPrimes1To10()
        {
            int[] primes = { 2, 3, 5, 7 };
            foreach (int prime in primes)
            {
                Assert.IsTrue(PrimeHelper.IsPrime(prime), $"{prime} was not found to be prime");
            }
        }

        [TestMethod]
        public void TestBasicNonPrimes1To10()
        {
            int[] notPrimes = { 1, 4, 6, 8, 9, 10 };
            foreach (int notPrime in notPrimes)
            {
                Assert.IsFalse(PrimeHelper.IsPrime(notPrime), $"{notPrime} was found to be prime");
            }
        }


        [TestMethod]
        public void TestGetLowestAndHighestFactor()
        {
            int number = 909;
            LowestAndHighestFactor factors = PrimeHelper.GetLowestAndHighestFactor(number);
            LowestAndHighestFactor expectedFactors = new LowestAndHighestFactor(3, 303);

            Assert.AreEqual(expectedFactors.lowest, factors.lowest, $"The lowest factor of {number} was incorrect");
            Assert.AreEqual(expectedFactors.highest, factors.highest, $"The highest factor of {number} was incorrect");
        }
    }
}
