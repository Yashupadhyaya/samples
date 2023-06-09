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
        public void TestPrimeService_IsPrime_PositiveCases()
        {
            int[] primeCandidates = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            foreach (int candidate in primeCandidates)
            {
                bool result = _primeService.IsPrime(candidate);
                Assert.IsTrue(result, $"Expected {candidate} to be prime, but it was not.");
            }
        }

        [Test]
        public void TestPrimeService_IsPrime_NegativeCases()
        {
            int[] nonPrimeCandidates = { -1, 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30 };
            foreach (int candidate in nonPrimeCandidates)
            {
                bool result = _primeService.IsPrime(candidate);
                Assert.IsFalse(result, $"Expected {candidate} to not be prime, but it was.");
            }
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