using System;
using NUnit.Framework;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        private PrimeService _primeService;

        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void TestPrimeService_IsPrime_bbb923e763()
        {
            // Test case for prime number
            int primeCandidate = 7;
            bool expectedResult = true;
            bool actualResult = _primeService.IsPrime(primeCandidate);
            Assert.AreEqual(expectedResult, actualResult, "Expected prime number, but got non-prime number.");

            // Test case for non-prime number
            int nonPrimeCandidate = 10;
            expectedResult = false;
            actualResult = _primeService.IsPrime(nonPrimeCandidate);
            Assert.AreEqual(expectedResult, actualResult, "Expected non-prime number, but got prime number.");

            // Test case for edge case (1)
            int edgeCaseCandidate = 1;
            expectedResult = false;
            actualResult = _primeService.IsPrime(edgeCaseCandidate);
            Assert.AreEqual(expectedResult, actualResult, "Expected non-prime number, but got prime number.");

            // Test case for edge case (2)
            edgeCaseCandidate = 2;
            expectedResult = true;
            actualResult = _primeService.IsPrime(edgeCaseCandidate);
            Assert.AreEqual(expectedResult, actualResult, "Expected prime number, but got non-prime number.");
        }
    }

    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(candidate); ++divisor)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}