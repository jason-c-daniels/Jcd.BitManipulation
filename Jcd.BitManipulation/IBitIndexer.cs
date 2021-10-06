using System.Collections.Generic;
using System.Text;

namespace Jcd.BitManipulation
{
    public interface IBitIndexer : IEnumerable<bool>
    {
        int Length { get; }
        bool this[int index] { get; set; }
        bool[] Slice(int start, int length);
        /// <summary>
        /// Format as a bit representation
        /// </summary>
        /// <returns>the bits of the mask formatted as 0b0101...1111</returns>
        string ToString();
    }
    
}
