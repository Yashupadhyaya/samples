using NUnit.Framework;
using System;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeServiceTests
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

        [Test]
        public void TestPrimeService_IsPrime_PositiveCase()
        {
            // Arrange
            int primeCandidate = 7;

            // Act
            bool result = IsPrime(primeCandidate);

            // Assert
            Assert.IsTrue(result, "The IsPrime method did not return true for a prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_NegativeCase()
        {
            // Arrange
            int nonPrimeCandidate = 10;

            // Act
            bool result = IsPrime(nonPrimeCandidate);

            // Assert
            Assert.IsFalse(result, "The IsPrime method did not return false for a non-prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_EdgeCase()
        {
            // Arrange
            int edgeCandidate = 2;

            // Act
            bool result = IsPrime(edgeCandidate);

            // Assert
            Assert.IsTrue(result, "The IsPrime method did not return true for the smallest prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_ErrorHandling()
        {
            // Arrange
            int negativeCandidate = -5;

            // Act
            bool result = IsPrime(negativeCandidate);

            // Assert
            Assert.IsFalse(result, "The IsPrime method did not return false for a negative number.");
        }
    }
}