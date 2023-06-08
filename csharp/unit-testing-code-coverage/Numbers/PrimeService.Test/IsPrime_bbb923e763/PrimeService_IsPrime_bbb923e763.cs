using System;
using NUnit.Framework;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        [Test]
        public void TestPrimeService_IsPrime_PositiveCases()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            var isFivePrime = primeService.IsPrime(5);
            var isSevenPrime = primeService.IsPrime(7);

            // Assert
            Assert.IsTrue(isFivePrime, "5 should be a prime number.");
            Assert.IsTrue(isSevenPrime, "7 should be a prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_NegativeCases()
        {
            // Arrange
            var primeService = new PrimeService();

            // Act
            var isFourPrime = primeService.IsPrime(4);
            var isNegativePrime = primeService.IsPrime(-3);

            // Assert
            Assert.IsFalse(isFourPrime, "4 should not be a prime number.");
            Assert.IsFalse(isNegativePrime, "-3 should not be a prime number.");
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