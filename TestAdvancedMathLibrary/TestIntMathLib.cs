
using Xunit;
using AdvancedMathLibrary;

namespace TestAdvancedMathLibrary {
    public class TestIntMathLib {
        //[] means an attribute. modifies method test1
        //fact is a type of test that xunit will do, results to true or false
        //theory lets you run multiple tests

        [Fact]
        public void TestDivideByZero() {
            System.Action ZeroDenominator = () => Math.Divide(1, 0);
            Assert.Throws<System.DivideByZeroException>
                (ZeroDenominator);
        }

        [Theory]
        [InlineData(10, 13, 3)]
        [InlineData(0, 5, 5)]
        [InlineData(5, 10, 5)]
        public void TestSubtract(int answer, int a, int b) {
            Assert.Equal(answer, Math.Subtract(a, b));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(-10 , 0, -10)]
        public void TestAdd(int answer, int a, int b) {
            Assert.Equal(answer, Math.Add(a, b));
        } 


        [Theory]
        [InlineData(-3, 3)]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        public void TestAbsoluteValue(int input, int expected) {
            Assert.Equal(expected, Math.AbsoluteValue(input));
        }
        //[Fact]
        //public void TestZeroConstant() {
        //    Assert.Equal(0, Math.Zero);
        //}
    }   

}
