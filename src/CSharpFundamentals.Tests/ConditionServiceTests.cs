using CSharpFundamentals.Conditions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Tests
{
    public class ConditionServiceTests
    {
        private readonly IConditionService _service;

        public ConditionServiceTests()
        {
            _service = new ConditionService();
        }

        [Fact]
        public void GetMonthName_WhenExceptionThrew()
        {
            int monthNumber = 13;
            Assert.Throws<ArgumentException>(() => _service.GetMonthName(monthNumber));
        }

        [Theory]
        [InlineData(1, "January")]
        [InlineData(2, "February")]
        [InlineData(12, "December")]
        public void GetMonthName_ShouldValidateCorrectly(int monthNumber, string expectedMonthName)
        {
           string actualMonthName = _service.GetMonthName(monthNumber);
            Assert.Equal(expectedMonthName, actualMonthName);
        }

        [Fact]
        public void IsNumberPositive_WhenNumberIsFive_ReturnsTrue()
        {
            double number = 5;

            bool result = _service.IsNumberPositive(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(-5, false)]
        [InlineData(0, false)]
        [InlineData(0.1, true)]
        public void IsNumberPositive_ShouldValidateCorrectly(double number, bool expected)
        {
            var result = _service.IsNumberPositive(number);
            Assert.Equal(expected, result);
        } 

    }
}
