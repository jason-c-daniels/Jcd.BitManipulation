#region

using System.Collections.Generic;

// ReSharper disable UnusedMemberInSuper.Global

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// The basic interface for indexing bytes within an integral data type.
/// </summary>
public interface IByteIndexer : IEnumerable<byte>
{
   /// <summary>
   /// The number of addressable bytes.
   /// </summary>
   int Length { get; }

   /// <summary>
   /// Gets or sets a bit
   /// </summary>
   /// <param name="index">the offset of the bit to get or set.</param>
   byte this[int index] { get; set; }

   /// <summary>
   /// Gets a slice of bytes from the backing store
   /// </summary>
   /// <param name="start">starting offset of the bits to retrieve</param>
   /// <param name="length">the number of bits to get</param>
   /// <returns>Array of bits extracted</returns>
   byte[] Slice(int start, int length);
}