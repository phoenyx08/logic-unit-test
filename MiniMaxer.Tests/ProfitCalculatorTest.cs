using System;
using Xunit;
using MiniMaxer.Library;
using System.Collections.Generic;

namespace MiniMaxer.Tests
{
    public class ProfitCalculatorTest
    {

        [Fact]
        public void TestNoProfitSequenceReturnsFalse()
        {
            ProfitCalculator calculator = new ProfitCalculator();
            bool realResult = calculator.Process(new int[]{10,9,8,7});
            Assert.False(realResult);
        }

        [Theory]
        [InlineData(new int[]{4,2,8,6,7,12,3,25,21,30,1}, 2, 30, 28)]
        [InlineData(new int[]{45,56,5,7,3,57,23,24,12,2,40}, 3, 57, 54)]
        public void TestResultFitsTaskConditions(
            int[] source, 
            int buyPrice, 
            int sellPrice, 
            int maxProfit 
        )
        {
            ProfitCalculator calculator = new ProfitCalculator();
            bool result = calculator.Process(source);
            Assert.Equal(calculator.GetBuyPrice(), buyPrice);
            Assert.Equal(calculator.GetSellPrice(), sellPrice);
            Assert.Equal(calculator.GetMaxProfit(), maxProfit);
            Assert.True(result);
        }

        /*[Theory]
        [InlineData("1,2,3,4,5,2147483647")]
        [InlineData("1, 2, 3, 4, 5, 2147483647")]
        [InlineData("1,  2,  3,  4,  5, 2147483647, ")]
        public void TestHelperNormalizeInputReturnsExpectedResult(string value)
        {
            var expectedResult = new List<int>() {1, 2, 3, 4, 5, 2147483647};
            var realResult = Helper.NormalizeInput(value);
            Assert.Equal(expectedResult, realResult);
        }

        [Theory]
        [InlineData("a,2,3,4,5,6")]
        [InlineData("1, 2147483648, 3, 4, 5, 6")]
        [InlineData("")]
        public void TestHelperNormalizeInputReturnsEmptyListOnError(string value)
        {
            var realResult = Helper.NormalizeInput(value);
            Assert.Empty(realResult);
        }*/
    }
}
