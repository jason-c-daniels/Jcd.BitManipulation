using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jcd.BitManipulation
{
    public struct BitIndexerInt16 : IEnumerable<bool>, IBitIndexer
    {
        public const int BitSize = 16;
        private short bits;
        
        public short Bits { get => bits; set => bits = value; }

        public int Length => BitSize;

        public bool this[int index]
        {
            get => bits.ReadBit(index);
            set => bits.StoreBit(index, value);
        }
        
        public static implicit operator BitIndexerInt16(short bits) => new BitIndexerInt16 { Bits = bits };
        public static implicit operator short(BitIndexerInt16 indexer) => indexer.bits;
        public IEnumerator<bool> GetEnumerator()
        {
            for (var index=0;index < BitSize;index++)
                yield return bits.ReadBit(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public bool[] Slice(int start, int length)
        {
            var slice = new bool[length];
            for (int i = 0; i < length; i++)
            {
                slice[i] = this[i+start];
            }

            return slice;
        }

        /// <summary>
        /// Format as a bit representation
        /// </summary>
        /// <returns>the bits of the mask formatted as 0b0101...1111</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("0b");
            foreach (var value in this.Reverse())
            {
                sb.Append(value ? '1':'0');
            }
            return sb.ToString();
        }
    }
}