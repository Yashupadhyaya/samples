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
        public void TestPrimeService_IsPrime_WhenCandidateIsPrime()
        {
            // Arrange
            int primeCandidate = 7;

            // Act
            bool isPrime = _primeService.IsPrime(primeCandidate);

            // Assert
            Assert.IsTrue(isPrime, "Expected 7 to be prime");
        }

        [Test]
        public void TestPrimeService_IsPrime_WhenCandidateIsNotPrime()
        {
            // Arrange
            int nonPrimeCandidate = 10;

            // Act
            bool isPrime = _primeService.IsPrime(nonPrimeCandidate);

            // Assert
            Assert.IsFalse(isPrime, "Expected 10 to be not prime");
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