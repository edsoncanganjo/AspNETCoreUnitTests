using GreatMathLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AspNETCoreUnitTests
{
    public class TestBasicStatistics
    {
        // mockup to simulate the data
        private class TestReader : IReaderBase
        {
            public Task<IEnumerable<int>> ReadNumbersAsync() 
                => Task.FromResult(new[] { 1, 2 }.AsEnumerable());
        }

        [Fact]
        public async Task SumValueFromReader()
        {
            // Data comming from txt file
            //var statistics = new BasicStatistics(new NumberReader());
            var statistics = new BasicStatistics(new TestReader());
            // Testing from the mockup
            var result = await statistics.SumValuesFromReader();

            Assert.Equal(3, result);

        }
    }
}

