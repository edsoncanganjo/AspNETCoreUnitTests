using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatMathLibrary
{
    public class BasicStatistics
    {
        private readonly IReaderBase reader;

        public BasicStatistics(IReaderBase reader)
        {
            this.reader = reader;
        }

        public async Task<int> SumValuesFromReader()
        {
            //var reader = new NumberReader(); // remove and add as injection
            var numbers = await this.reader.ReadNumbersAsync();

            return numbers.Sum();
        }
    }
}
