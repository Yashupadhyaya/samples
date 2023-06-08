using System;
using NUnit.Framework;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        // Test method for checking if a number is prime
        [Test]
        public void TestPrimeService_IsPrime_Positive()
        {
            // Arrange
            int candidate = 7;
            bool expectedResult = true;

            // Act
            bool actualResult = IsPrime(candidate);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "The IsPrime method failed to identify a prime number.");
        }

        // Test method for checking if a number is not prime
        [Test]
        public void TestPrimeService_IsPrime_Negative()
        {
            // Arrange
            int candidate = 10;
            bool expectedResult = false;

            // Act
            bool actualResult = IsPrime(candidate);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "The IsPrime method failed to identify a non-prime number.");
        }

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