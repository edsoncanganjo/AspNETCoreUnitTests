using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatMathLibrary
{
    //public abstract class ReaderBase
    //{
    //    public abstract Task<IEnumerable<int>> ReadNumbersAsync();
    //}     
    
    public interface IReaderBase
    {
        Task<IEnumerable<int>> ReadNumbersAsync();
    } 

    internal class NumberReader : IReaderBase
    {
        public async Task<IEnumerable<int>> ReadNumbersAsync()
        {
            var fileContent = await File.ReadAllTextAsync("numbers.txt");

            return fileContent.Split(",").Select(valueText => int.Parse(valueText));
        }
    }
}
