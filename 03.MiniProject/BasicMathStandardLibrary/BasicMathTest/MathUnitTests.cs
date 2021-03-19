using System;
using Xunit;
using BasicMathStandardLibrary;

namespace BasicMathTest
{
	public class MathUnitTest
	{
		[Theory]
        [InlineData(4, 2, 6)]
        [InlineData(6, 2, 8)]
        [InlineData(2, -2, 0)]
        [InlineData(100, -101, -1)]
        public void Test_AddMethod(double num1, double num2, double expected)
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Add(num1, num2);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(40, 2, 38)]
        [InlineData(1, 2, -1)]
        [InlineData(-4, 2, -6)]

        public void Test_SubstractMethod(double num1, double num2, double expected)
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Substract(num1, num2);
            Assert.Equal(expected, actual); ;
        }

        [Theory]
        [InlineData(40, 2, 20)]
        [InlineData(0, 0, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(4, 0, 0)]  // need implementation because of infinitive number returned by this operation
        public void Test_DivideMethod(double num1, double num2, double expected)
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Divide(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(1, 1, 1)]
        [InlineData(40, 1, 40)]
        [InlineData(3, 3, 9)]
        public void Test_MultiplyMethod(double num1, double num2, double expected)
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}
