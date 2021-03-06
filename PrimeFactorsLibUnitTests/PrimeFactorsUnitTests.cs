using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void Test1()
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
    }
}
