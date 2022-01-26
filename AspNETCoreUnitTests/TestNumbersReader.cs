using GreatMathLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AspNETCoreUnitTests
{
    public class TestNumbersReader
    {
        /// <summary>
        /// Teste the basic logic.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task TestReaderNumbers()
        {
            var reader = new NumberReader();
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, await reader.ReadNumbersAsync());
        }
    }
}

