#region

using System.Collections.Generic;

#endregion

// ReSharper disable UnusedMemberInSuper.Global

namespace Jcd.BitManipulation;

/// <summary>
/// The basic interface for indexing bits within an integer data type.
/// </summary>
public interface IBitIndexer : IEnumerable<bool>
{
   /// <summary>
   /// The number of addressable bits
   /// </summary>
   int Length { get; }

   /// <summary>
   /// Gets or sets a bit
   /// </summary>
   /// <param name="index">the offset of the bit to get or set.</param>
   bool this[int index] { get; set; }

   /// <summary>
   /// Gets a slice of bits from the backing store
   /// </summary>
   /// <param name="start">starting offset of the bits to retrieve</param>
   /// <param name="length">the number of bits to get</param>
   /// <returns>Array of bits extracted</returns>
   bool[] Slice(int start, int length);

   /// <summary>
   /// Format as a bit representation
   /// </summary>
   /// <returns>the bits of the value formatted as 0b0101...1111</returns>
   string ToString();
}