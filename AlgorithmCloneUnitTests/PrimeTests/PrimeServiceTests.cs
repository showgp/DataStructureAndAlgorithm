using System;
using Xunit;
using AlgorithmClone.Prime;

/*
 * 在 xUnit 中, 初始化方法就是 setup, 而实现 IDisposable 就是 teardown.
 */

namespace AlgorithmCloneUnitTests.PrimeTests {
    public class PrimeServiceTests: IDisposable {
        private IPrimeService _service;

        public PrimeServiceTests() {
            _service = new PrimeService();
        }

        public void Dispose() {
            _service = null;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(-1)]
        public void IsPrimeReturnsFalseWhenInputLessThan2(Int64 value) {
            Boolean result = _service.IsPrime(value);
            Assert.False(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrimeReturnsTrueWhenInputLessThan10(Int64 value) {
            Boolean result = _service.IsPrime(value);
            Assert.True(result);
        }
        
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrimeReturnsFalseWhenInputLessThan10(Int64 value) {
            Boolean result = _service.IsPrime(value);
            Assert.False(result);
        }
    }
}