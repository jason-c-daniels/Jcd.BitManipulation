#region

using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable UnusedMember.Local
// ReSharper disable MemberCanBePrivate.Global

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
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Float()
   {
      var bytes = BitConverter.GetBytes(Flt);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt64()
   {
      var bytes = BitConverter.GetBytes(Ui64);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Int64()
   {
      var bytes = BitConverter.GetBytes(I64);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt32()
   {
      var bytes = BitConverter.GetBytes(Ui32);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Int32()
   {
      var bytes = BitConverter.GetBytes(I32);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt16()
   {
      var bytes = BitConverter.GetBytes(Ui16);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark(Baseline = true)]
   public byte[] BitConverter_GetBytes_Int16()
   {
      var bytes = BitConverter.GetBytes(I16);
      Array.Reverse(bytes);

      return bytes;
   }

   #endregion

   #region BigEndianByteIndexer

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Double()
   {
      return ((BigEndianByteIndexer) Dbl).Slice(0, sizeof(double));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Float()
   {
      return ((BigEndianByteIndexer) Flt).Slice(0, sizeof(float));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_UInt64()
   {
      return ((BigEndianByteIndexer) Ui64).Slice(0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Int64()
   {
      return ((BigEndianByteIndexer) I64).Slice(0, sizeof(long));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_UInt32()
   {
      return ((BigEndianByteIndexer) Ui32).Slice(0, sizeof(uint));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Int32()
   {
      return ((BigEndianByteIndexer) I32).Slice(0, sizeof(int));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_UInt16()
   {
      return ((BigEndianByteIndexer) Ui16).Slice(0, sizeof(ushort));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BigEndianByteIndexer_Slice_Int16()
   {
      return ((BigEndianByteIndexer) I16).Slice(0, sizeof(short));
   }

   #endregion

   #region Extension Methods

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_Double()
   {
      return Dbl.ReadBytes(0, sizeof(ulong), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_Float()
   {
      return Flt.ReadBytes(0, sizeof(float), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_UInt64()
   {
      return Ui64.ReadBytes(0, sizeof(ulong), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_Int64()
   {
      return I64.ReadBytes(0, sizeof(long) / 2, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_UInt32()
   {
      return Ui32.ReadBytes(0, sizeof(uint), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_Int32()
   {
      return I32.ReadBytes(0, sizeof(int) / 2, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_UInt16()
   {
      return Ui16.ReadBytes(0, sizeof(ushort), Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_Int16()
   {
      return I16.ReadBytes(0, sizeof(short) / 2, Endian.Big);
   }

   #endregion
}