#region

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides indexer style access to the bits on a copied value.
/// </summary>
/// <example>
/// <para>
/// Examples:
/// <code>
/// ushort ui16 = 0b1011110001010101;
/// BitIndexer bi = ui16;
/// Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010101
/// 
/// if (bi[0])
///    Console.WriteLine("Index 0 is set/true!"); // this will write to the output.
/// 
/// if (bi[1])
///    Console.WriteLine("Index 1 is set/true!"); // this will not write to the output.
/// 
/// if (bi[10])
///    Console.WriteLine("Index 10 is set/true!");
/// 
/// bi[1] = true; // bi is now 0b1011110001010111
/// if (bi[1])
///    Console.WriteLine("Index 1 is set/true!"); // this will write to the output.
/// 
/// Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010111
/// 
/// var flags = bi[0..^0]; // flags = [true, true, true, false, true, false, true, false, false, false, true, true, true, true, false, true];
/// Array.Reverse(flags);
/// var ui16Reversed=flags.ToUInt16(); // ui16Reversed = 0b1110101000111101;
/// BitIndexer biReversed = ui16Reversed;
/// 
/// Console.WriteLine(biReversed.ToString()); // outputs: 0b1110101000111101
/// </code>
/// </para>
/// </example>
public ref struct BitIndexer
{
   #region Constructors

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(ulong bits, int bitSize = 64)
   {
      Length = bitSize;
      this.bits = bits;
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(long bits)
      : this((ulong) bits)
   {
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(uint bits)
      : this(bits, 32)
   {
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(int bits)
      : this((uint) bits, 32)
   {
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(ushort bits)
      : this(bits, 16)
   {
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(short bits)
      : this((ushort) bits, 16)
   {
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(byte bits)
      : this(bits, 8)
   {
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BitIndexer(sbyte bits)
      : this((byte) bits, 8)
   {
   }
   

   private BitIndexer(IReadOnlyList<bool> array)
      : this(array, GetIntegerBitSize(array))
   {
   }

   private BitIndexer(IReadOnlyList<bool> array, int bitSize)
   {
      Length = bitSize;
      bits = 0;

      for (var i = 0; i < array.Count && i < Length; i++)
         this[i] = array[i];
   }

   private static int GetIntegerBitSize(IReadOnlyCollection<bool> array)
   {
      return (array.Count >> 3) switch
             {
                <= sizeof(byte)   => sizeof(byte)   << 3
              , <= sizeof(ushort) => sizeof(ushort) << 3
              , <= sizeof(uint)   => sizeof(uint)   << 3
              , _                 => sizeof(ulong)  << 3
             };
   }

   #endregion

   /// <summary>
   /// The number of bits indexable by this <see cref="BitIndexer" /> instance.
   /// </summary>
   public int Length { get; } = 64;

   /// <summary>
   /// The backing store
   /// </summary>
   /// <exclude />
   private ulong bits;

   /// <summary>
   /// Gets or sets individual bits within the backing store.
   /// </summary>
   /// <param name="index">the offset of the bit to access.</param>
   public bool this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      readonly get => index < Length && bits.ReadBit(index);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index >= Length)
            return;

         bits = bits.StoreBit(value, index);
      }
   }

   /// <summary>
   /// Gets a subset of bits given a starting offset and length.
   /// </summary>
   /// <param name="start">The starting bit offset</param>
   /// <param name="length">The number of bits to extract</param>
   /// <returns>a array of bools for the subset of bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]

   // ReSharper disable once ReturnTypeCanBeEnumerable.Global
   public readonly bool[] Slice(int start, int length)
   {
      var len = length + start > Length
                   ? Length - start
                   : length;
      var slice = new bool[len];
      var j = start;
      for (var i = 0; i < len; i++, j++)
         slice[i] = bits.ReadBit(j);

      return slice;
   }

   #region Conversion Operators

   /// <summary>
   /// Automatically Convert from a <see cref="ulong" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(ulong bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a BitIndexer to a <see cref="ulong" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The bits converted to a <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(BitIndexer indexer)
   {
      return indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="long" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(long bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a BitIndexer to a <see cref="long" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The bits converted to a <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(BitIndexer indexer)
   {
      return (long) indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="uint" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(uint bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a BitIndexer to a <see cref="uint" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The lower 32 bits converted to a <see cref="uint" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(BitIndexer indexer)
   {
      return (uint) indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="int" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(int bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a BitIndexer to a <see cref="int" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The lower 32 bits converted to a <see cref="int" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(BitIndexer indexer)
   {
      return (int) (uint) indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="ushort" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(ushort bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a BitIndexer to a <see cref="ushort" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The lower 16 bits converted to a <see cref="ushort" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(BitIndexer indexer)
   {
      return (ushort) indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="short" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(short bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a <see cref="BitIndexer" /> to a <see cref="short" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The lower 16 bits converted to a <see cref="short" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(BitIndexer indexer)
   {
      return (short) (ushort) indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="sbyte" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(sbyte bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a <see cref="BitIndexer" /> to a <see cref="sbyte" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The lower 8 bits converted to a <see cref="sbyte" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(BitIndexer indexer)
   {
      return (sbyte) indexer.bits;
   }

   /// <summary>
   /// Automatically Convert from a <see cref="byte" /> to a <see cref="BitIndexer" />
   /// </summary>
   /// <param name="bits">The initial value for the indexed bits.</param>
   /// <returns>A new <see cref="BitIndexer" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(byte bits)
   {
      return new BitIndexer(bits);
   }

   /// <summary>
   /// Automatically convert from a <see cref="BitIndexer" /> to a <see cref="byte" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>The lower 8 bits converted to a <see cref="byte" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(BitIndexer indexer)
   {
      return (byte) (sbyte) indexer.bits;
   }

   /// <summary>
   /// Automatically convert from a <see cref="BitIndexer" /> to a array of <see cref="bool" />
   /// </summary>
   /// <param name="indexer">The indexer to convert from.</param>
   /// <returns>An array of bools for each bit with The Least Significant Bit is at index 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator bool[](BitIndexer indexer)
   {
      // ReSharper disable RedundantRangeBound -- false positive
      return indexer[0..^0];

      // ReSharper enable RedundantRangeBound -- false positive
   }

   /// <summary>
   /// Automatically convert from a <see cref="BitIndexer" /> to a array of <see cref="bool" />
   /// </summary>
   /// <param name="array">The indexer to convert from.</param>
   /// <returns>The lower 8 bits converted to a <see cref="byte" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexer(bool[] array)
   {
      return new BitIndexer(array);
   }

   #endregion

   /// <summary>
   /// Format as a bit representation
   /// </summary>
   /// <returns>the bits of the value formatted as 0b0101...1111</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly override string ToString()
   {
      var sb = new StringBuilder();
      sb.Append("0b");

      for (var i = Length - 1; i >= 0; i--)
         sb.Append(bits.ReadBits(i, 1));

      return sb.ToString();
   }
}