using CSharpFundamentals.Loops;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpFundamentals.Tests
{
    public class LoopServiceTests
    {
        private readonly ILoopService _service;

        public LoopServiceTests()
        {
            _service = new LoopService();
        }

        #region GetSum Tests

        [Fact]
        public void GetSum_WhenExceptionThrew()
        {
            int number = 0;
            Assert.Throws<ArgumentException>(() => _service.GetSum(number));
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 10)]
        [InlineData(5, 15)]
        public void GetSum_ShouldValidateCorrectly(int number, int expectedSum)
        {
            int actualSum = _service.GetSum(number);
            Assert.Equal(expectedSum, actualSum);
        }

        #endregion

        #region GetAverage Tests

        [Fact]
        public void GetAverage_WhenExceptionThrew()
        {
            double[] arr = new double[] { };
            Assert.Throws<ArgumentException>(() => _service.GetAverage(arr));
        }

        [Theory]
        [InlineData(new double[] { -1.5, -1.2, 0, 5, 12.7 }, 3.00000)]
        [InlineData(new double[] { -5, 1, 9 }, 1.66667)]
        public void GetAverage_ShouldValidateCorrectly(double[] arr, double expectedAverage)
        {
            double actualAverage = _service.GetAverage(arr);
            Assert.Equal(expectedAverage, actualAverage);
        }

        #endregion

    }
}
