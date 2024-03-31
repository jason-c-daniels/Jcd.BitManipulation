#region

using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable UnusedMember.Local
// ReSharper disable MemberCanBePrivate.Global

#pragma warning disable CA1822
#pragma warning disable S109

#endregion

namespace Jcd.BitManipulation.Benchmark;

public class BigEndianReadBytes
{
   private const ulong Ui64 = ulong.MaxValue   / 2;
   private const long I64 = long.MaxValue      / 2;
   private const uint Ui32 = uint.MaxValue     / 2;
   private const int I32 = int.MaxValue        / 2;
   private const ushort Ui16 = ushort.MaxValue / 2;
   private const short I16 = short.MaxValue    / 2;
   private const double Dbl = double.MaxValue  / 2;
   private const float Flt = float.MaxValue    / 2;

   #region BitConverter

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Double()
   {
      var bytes = BitConverter.GetBytes(Dbl);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Float()
   {
      var bytes = BitConverter.GetBytes(Flt);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt64()
   {
      var bytes = BitConverter.GetBytes(Ui64);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Int64()
   {
      var bytes = BitConverter.GetBytes(I64);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt32()
   {
      var bytes = BitConverter.GetBytes(Ui32);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Int32()
   {
      var bytes = BitConverter.GetBytes(I32);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt16()
   {
      var bytes = BitConverter.GetBytes(Ui16);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Int16()
   {
      var bytes = BitConverter.GetBytes(I16);
      if (BitConverter.IsLittleEndian)
         Array.Reverse(bytes);

      return bytes;
   }

   #endregion

   #region BigEndianByteIndexer

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Double()
   {
      return ((BigEndianByteIndexer) Dbl)[..];
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Float()
   {
      return ((BigEndianByteIndexer) Flt)[..];
   }

   [Benchmark(Baseline = true)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_UInt64()
   {
      return ((BigEndianByteIndexer) Ui64)[..];
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Int64()
   {
      return ((BigEndianByteIndexer) I64)[..];
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_UInt32()
   {
      return ((BigEndianByteIndexer) Ui32)[..];
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Int32()
   {
      return ((BigEndianByteIndexer) I32)[..];
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_UInt16()
   {
      return ((BigEndianByteIndexer) Ui16)[..];
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Int16()
   {
      return ((BigEndianByteIndexer) I16)[..];
   }

   #endregion

   #region Extension Methods

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Double()
   {
      return Dbl.ReadBytes(0, sizeof(ulong), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Float()
   {
      return Flt.ReadBytes(0, sizeof(float), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_UInt64()
   {
      return Ui64.ReadBytes(0, sizeof(ulong), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Int64()
   {
      return I64.ReadBytes(0, sizeof(long) / 2, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_UInt32()
   {
      return Ui32.ReadBytes(0, sizeof(uint), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Int32()
   {
      return I32.ReadBytes(0, sizeof(int) / 2, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_UInt16()
   {
      return Ui16.ReadBytes(0, sizeof(ushort), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Int16()
   {
      return I16.ReadBytes(0, sizeof(short) / 2, Endian.Big);
   }

   #endregion
}