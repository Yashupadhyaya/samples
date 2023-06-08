using NUnit.Framework;
using System;

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
        public void TestPrimeService_IsPrime_NegativeNumber()
        {
            int candidate = -5;
            bool result = _primeService.IsPrime(candidate);
            Assert.IsFalse(result, "Negative numbers are not prime.");
        }

        [Test]
        public void TestPrimeService_IsPrime_PositivePrimeNumber()
        {
            int candidate = 7;
            bool result = _primeService.IsPrime(candidate);
            Assert.IsTrue(result, "7 is a prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_PositiveNonPrimeNumber()
        {
            int candidate = 10;
            bool result = _primeService.IsPrime(candidate);
            Assert.IsFalse(result, "10 is not a prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_Zero()
        {
            int candidate = 0;
            bool result = _primeService.IsPrime(candidate);
            Assert.IsFalse(result, "0 is not a prime number.");
        }

        [Test]
        public void TestPrimeService_IsPrime_One()
        {
            int candidate = 1;
            bool result = _primeService.IsPrime(candidate);
            Assert.IsFalse(result, "1 is not a prime number.");
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