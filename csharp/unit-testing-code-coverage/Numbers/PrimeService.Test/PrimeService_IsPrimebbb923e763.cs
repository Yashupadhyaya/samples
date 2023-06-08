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
            int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            foreach (int prime in primeNumbers)
            {
                bool result = _primeService.IsPrime(prime);
                Assert.IsTrue(result, $"Failed for prime number {prime}");
            }
        }

        [Test]
        public void TestPrimeService_IsPrime_NegativeCases()
        {
            int[] nonPrimeNumbers = new int[] { -3, 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30 };
            foreach (int nonPrime in nonPrimeNumbers)
            {
                bool result = _primeService.IsPrime(nonPrime);
                Assert.IsFalse(result, $"Failed for non-prime number {nonPrime}");
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