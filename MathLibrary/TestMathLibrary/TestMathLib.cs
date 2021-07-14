using System;
using Xunit;

namespace TestMathLibrary
{
    public class TestMathLib
    {

        [Fact]
        public void TestZero()
        {
            Assert.Equal(0, MathLibrary.MathIntLibrary.Zero());
        }

        [Theory]
        [InlineData(1,2,3)]
        public void TestAdd(int a, int b, int sum)
        {
            Assert.Equal(sum, MathLibrary.MathIntLibrary.Add(a, b));
        }

        [Theory]
        [InlineData(5,2,1)]
        [InlineData(6,2,0)]
        [InlineData(7,2,1)]
        public void TestModulus(int a, int b, int modulus)
        {
            Assert.Equal(modulus, MathLibrary.MathIntLibrary.Modulus(a, b));
        }

        [Theory]
        [InlineData(6,2,4)]
        [InlineData(7,1,6)]
        public void TestSubtract(int a, int b, int difference)
        {
            Assert.Equal(difference, MathLibrary.MathIntLibrary.Subtract(a, b));
        }



    }
}
