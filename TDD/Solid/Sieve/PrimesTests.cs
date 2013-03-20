using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


public class PrimesTests
{
    private static List<int> knownPrimes = new List<int>()
        { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

    public class GenerateTests
    {
        [Fact]
        public void Zero_NoPrimes()
        {
            List<int> primes = Primes.Generate(0);

            Assert.Equal(0, primes.Count);
        }

        [Fact]
        public void PrimesMaxValueTwo_ReturnsTwo()
        {
            List<int> primes = Primes.Generate(2);

            Assert.Equal(1, primes.Count);
            Assert.Equal(2, primes[0]);
        }

        [Fact]
        public void PrimesMaxValue100_Returns25Primes()
        {
            List<int> primes = Primes.Generate(100);

            Assert.Equal(25, primes.Count);
            Assert.Equal(97, primes[24]);
        }

        [Fact]
        public void PrimesMaxValue30_ReturnsKnownPrimes()
        {
            List<int> primes = Primes.Generate(30);

            Assert.Equal(knownPrimes, primes);
        }
    }
}

