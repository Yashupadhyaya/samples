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
            // Test case 1: Testing a prime number
            int primeCandidate = 7;
            bool isPrime = _primeService.IsPrime(primeCandidate);
            Assert.IsTrue(isPrime, $"Expected {primeCandidate} to be a prime number.");

            // Test case 2: Testing a non-prime number
            int nonPrimeCandidate = 10;
            bool isNotPrime = _primeService.IsPrime(nonPrimeCandidate);
            Assert.IsFalse(isNotPrime, $"Expected {nonPrimeCandidate} not to be a prime number.");

            // Test case 3: Testing an edge case (1)
            int edgeCaseOne = 1;
            bool isEdgeCaseOnePrime = _primeService.IsPrime(edgeCaseOne);
            Assert.IsFalse(isEdgeCaseOnePrime, $"Expected {edgeCaseOne} not to be a prime number.");

            // Test case 4: Testing an edge case (0)
            int edgeCaseZero = 0;
            bool isEdgeCaseZeroPrime = _primeService.IsPrime(edgeCaseZero);
            Assert.IsFalse(isEdgeCaseZeroPrime, $"Expected {edgeCaseZero} not to be a prime number.");

            // Test case 5: Testing a negative number
            int negativeCandidate = -7;
            bool isNegativeCandidatePrime = _primeService.IsPrime(negativeCandidate);
            Assert.IsFalse(isNegativeCandidatePrime, $"Expected {negativeCandidate} not to be a prime number.");
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