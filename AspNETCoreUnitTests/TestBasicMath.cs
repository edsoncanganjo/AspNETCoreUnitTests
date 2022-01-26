using GreatMathLibrary;
using Xunit;

namespace AspNETCoreUnitTests
{
    public class TestBasicMath
    {
        [Fact]
        public void AddTest()
        {
            var result = BasicMath.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1000, 2000, 3000)]
        public void AddTheoryTest(int x, int y, int expectedResult)
        {
            var result = BasicMath.Add(x, y);

            Assert.Equal(expectedResult, result);
        }
    }
}

