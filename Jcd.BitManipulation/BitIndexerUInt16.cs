using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jcd.BitManipulation
{
    /// <summary>
    /// Provides enumeration and indexed access to the bits on a stored ushort. 
    /// </summary>
    public struct BitIndexerUInt16 : IBitIndexer
    {
        /// <summary>
        /// The number of bits this type will index
        /// </summary>
        public const int BitSize = 16;
        
        private ushort _bits;

        /// <summary>
        /// The backing store
        /// </summary>
        public ushort Bits
        {
            get => _bits;
            set => _bits = value;
        }

        /// <summary>
        /// The length of enumerated bits
        /// </summary>
        public int Length => BitSize;

        /// <summary>
        /// Gets or sets individual bits within the backing store. 
        /// </summary>
        /// <param name="index">the offset of the bit to access.</param>
        public bool this[int index]
        {
            get => _bits.ReadBit(index);
            set => _bits.StoreBit(index, value);
        }

        /// <summary>
        /// Automatically Convert from a ushort to a BitIndexerUInt16
        /// </summary>
        /// <param name="bits">the initial value for the indexer's backing store</param>
        /// <returns>A new BitIndexerUInt16</returns>
        public static implicit operator BitIndexerUInt16(ushort bits) => new BitIndexerUInt16 { Bits = bits };

        /// <summary>
        /// Automatically convert from a BitIndexerUInt16 to a ushort
        /// </summary>
        /// <param name="indexer">the indexer to convert from</param>
        /// <returns>the ushort</returns>
        public static implicit operator ushort(BitIndexerUInt16 indexer) => indexer._bits;

        /// <summary>
        /// Get an enumerator to enumerate the bits with.
        /// </summary>
        /// <returns>The enumerator</returns>
        public IEnumerator<bool> GetEnumerator()
        {
            for (var index = 0; index < BitSize; index++)
                yield return _bits.ReadBit(index);
        }

        /// <summary>
        /// Get an enumerator to enumerate the bits with.
        /// </summary>
        /// <returns>The enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Get a subset of bits given a starting offset and length.
        /// </summary>
        /// <param name="start">The starting bit offset</param>
        /// <param name="length">The number of bits to extract</param>
        /// <returns>an array of bools for the subset of bits</returns>
        public bool[] Slice(int start, int length)
        {
            var slice = new bool[length];
            for (var i = 0; i < length; i++)
            {
                slice[i] = this[i+start];
            }

            return slice;
        }

        /// <summary>
        /// Format as a bit representation
        /// </summary>
        /// <returns>the bits of the value formatted as 0b0101...1111</returns>
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
