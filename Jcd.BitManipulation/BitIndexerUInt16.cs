using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Jcd.BitManipulation
{
    public struct BitIndexerUInt16 : IEnumerable<bool>, IBitIndexer
    {
        private ushort bits;

        public ushort Bits
        {
            get => bits;
            set => bits = value;
        }

        public int Length => BitSize;

        public bool this[int index]
        {
            get => bits.ReadBit(index);
            set => bits.StoreBit(index, value);
        }

        public static implicit operator BitIndexerUInt16(ushort bits) => new BitIndexerUInt16 { Bits = bits };
        public static implicit operator ushort(BitIndexerUInt16 indexer) => indexer.bits;

        public IEnumerator<bool> GetEnumerator()
        {
            for (var index = 0; index < BitSize; index++)
                yield return bits.ReadBit(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public const int BitSize = 16;
        public bool[] Slice(int start, int length)
        {
            var slice = new bool[length];
            for (int i = 0; i < start+length; i++)
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
            foreach (var value in this)
            {
                sb.Append(value ? '1':'0');
            }
            return sb.ToString();

        }

    }
}
