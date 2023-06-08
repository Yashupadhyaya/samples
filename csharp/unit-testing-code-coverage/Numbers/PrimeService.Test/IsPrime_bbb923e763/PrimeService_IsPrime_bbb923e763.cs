using NUnit.Framework;
using System;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        [Test]
        public void TestPrimeService_IsPrime_PositiveCases()
        {
            // Arrange
            PrimeService primeService = new PrimeService();

            // Test cases
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            // Act and Assert
            foreach (int prime in primeNumbers)
            {
                Assert.IsTrue(primeService.IsPrime(prime), $"{prime} should be a prime number");
            }
        }

        [Test]
        public void TestPrimeService_IsPrime_NegativeCases()
        {
            // Arrange
            PrimeService primeService = new PrimeService();

            // Test cases
            int[] nonPrimeNumbers = { -1, 0, 1, 4, 6, 8, 9, 10, 12 };

            // Act and Assert
            foreach (int nonPrime in nonPrimeNumbers)
            {
                Assert.IsFalse(primeService.IsPrime(nonPrime), $"{nonPrime} should not be a prime number");
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