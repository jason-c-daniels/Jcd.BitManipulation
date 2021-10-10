using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jcd.BitManipulation
{
    /// <summary>
    /// Provides enumeration and indexed access to the bits on a stored ulong. 
    /// </summary>
    public struct BitIndexerUInt64 : IBitIndexer
    {
        /// <summary>
        /// The number of bits this type will index
        /// </summary>
        public const int BitSize = 64;

        private ulong _bits;

        /// <summary>
        /// The backing store
        /// </summary>
        public ulong Bits
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
        /// Automatically Convert from a ulong to a BitIndexerUInt64
        /// </summary>
        /// <param name="bits">the initial value for the indexer's backing store</param>
        /// <returns>A new BitIndexerUInt64</returns>
        public static implicit operator BitIndexerUInt64(ulong bits) => new BitIndexerUInt64 { Bits = bits };

        /// <summary>
        /// Automatically convert from a BitIndexerUInt64 to a ulong
        /// </summary>
        /// <param name="indexer">the indexer to convert from</param>
        /// <returns>the ulong</returns>
        public static implicit operator ulong(BitIndexerUInt64 indexer) => indexer._bits;

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