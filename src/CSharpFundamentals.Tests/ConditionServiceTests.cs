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
