using System;
using NUnit.Framework;

[TestFixture]
public class PrimeServiceTests
{
    [Test]
    public void TestPrimeService_IsPrime_PositiveCases()
    {
        // Arrange
        int[] primeCandidates = { 2, 3, 5, 7, 11, 13, 17, 19 };

        // Act
        foreach (int candidate in primeCandidates)
        {
            bool result = IsPrime(candidate);

            // Assert
            Assert.IsTrue(result, $"{candidate} should be a prime number.");
        }
    }

    [Test]
    public void TestPrimeService_IsPrime_NegativeCases()
    {
        // Arrange
        int[] nonPrimeCandidates = { -1, 0, 1, 4, 6, 8, 9, 10, 12 };

        // Act
        foreach (int candidate in nonPrimeCandidates)
        {
            bool result = IsPrime(candidate);

            // Assert
            Assert.IsFalse(result, $"{candidate} should not be a prime number.");
        }
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