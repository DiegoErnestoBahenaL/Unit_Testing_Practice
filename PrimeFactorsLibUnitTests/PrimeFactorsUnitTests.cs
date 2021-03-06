using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void ValidTest()
        {

            //arrange
            int number = 50;
            string expected = "2,5,5";
            var primes = new PrimeFactors();

            //act
            string actual = primes.GetPrimeFactors(number);
            
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void NegativeNumbersTest()
        {
            //arrange
            int number = -50;
            string expected = null;
            var primes = new PrimeFactors();

            //act
            string actual = primes.GetPrimeFactors(number);
            
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LargeNumbersTest()
        {
            //arrange
            int number = 20000000;
            string expected = null;
            var primes = new PrimeFactors();

            //act
            string actual = primes.GetPrimeFactors(number);
            
            //assert
            Assert.Equal(expected, actual);
        }

    }
}
