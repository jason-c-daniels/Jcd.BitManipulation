using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jcd.BitManipulation
{
    /// <summary>
    /// Provides enumeration and indexed access to the bits on a stored int. 
    /// </summary>
    public struct BitIndexerInt32 : IBitIndexer
    {
        /// <summary>
        /// The number of bits this type will index
        /// </summary>
        public const int BitSize = 32;
        private int bits;

        /// <summary>
        /// The backing store
        /// </summary>
        public int Bits
        {
            get => bits;
            set => bits = value;
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
            get => bits.ReadBit(index);
            set => bits.StoreBit(index, value);
        }

        /// <summary>
        /// Automatically Convert from an int to a BitIndexerInt32
        /// </summary>
        /// <param name="bits">the initial value for the indexer's backing store</param>
        /// <returns>A new BitIndexerInt32</returns>
        public static implicit operator BitIndexerInt32(int bits) => new BitIndexerInt32 { Bits = bits };

        /// <summary>
        /// Automatically convert from a BitIndexerInt32 to an int
        /// </summary>
        /// <param name="indexer">the indexer to convert from</param>
        /// <returns>the int</returns>
        public static implicit operator int(BitIndexerInt32 indexer) => indexer.bits;

        /// <summary>
        /// Get an enumerator to enumerate the bits with.
        /// </summary>
        /// <returns>The enumerator</returns>
        public IEnumerator<bool> GetEnumerator()
        {
            for (var index = 0; index < BitSize; index++)
                yield return bits.ReadBit(index);
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
            for (int i = 0; i < length; i++)
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