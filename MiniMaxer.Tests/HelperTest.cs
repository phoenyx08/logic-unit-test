using System;
using Xunit;
using MiniMaxer.Library;
using System.Collections.Generic;

namespace MiniMaxer.Tests
{
    public class HelperTest
    {
        [Theory]
        [InlineData("a,2,3,4,5,6")]
        [InlineData("1, 2147483648, 3, 4, 5, 6")]
        [InlineData("")]
        [InlineData("1,2,3,4,5,2147483647")]
        [InlineData("1, 2, 3, 4, 5, 2147483647")]
        [InlineData("1,  2,  3,  4,  5, 2147483647, ")]
        public void TestHelperNormalizeInputAlwaysReturnsListInt(string value)
        {
            var realResult = Helper.NormalizeInput(value);
            Assert.IsType(Type.GetType("System.Collections.Generic.List`1[System.Int32]"), realResult);
        }

        [Theory]
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
        }
    }
}
