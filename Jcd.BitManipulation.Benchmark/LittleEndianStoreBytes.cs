﻿#region

using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;

// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable MemberCanBeMadeStatic
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#pragma warning disable CA1822
#pragma warning disable S109

#endregion

namespace Jcd.BitManipulation.Benchmark;

public class LittleEndianStoreBytes
{
   private const ulong Ui64 = ulong.MaxValue   / 2;
   private const long I64 = long.MaxValue      / 2;
   private const uint Ui32 = uint.MaxValue     / 2;
   private const int I32 = int.MaxValue        / 2;
   private const ushort Ui16 = ushort.MaxValue / 2;
   private const short I16 = short.MaxValue    / 2;
   private const double Dbl = double.MaxValue  / 2;
   private const float Flt = float.MaxValue    / 2;

   private static readonly byte[] DblBytes = [0, 1, 2, 3, 4, 5, 6, 7];
   private static readonly byte[] FltBytes = [4, 5, 6, 7];
   private static readonly byte[] Ui64Bytes = [0, 1, 2, 3, 4, 5, 6, 7];
   private static readonly byte[] Ui32Bytes = [0, 1, 2, 3];
   private static readonly byte[] Ui16Bytes = [0, 1];
   private static readonly byte[] I64Bytes = [0, 1, 2, 3, 4, 5, 6, 7];
   private static readonly byte[] I32Bytes = [4, 5, 6, 7];
   private static readonly byte[] I16Bytes = [6, 7];

   #region BitConverter

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double BitConverter_ToDouble()
   {
      return BitConverter.ToDouble(DblBytes, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float BitConverter_ToFloat()
   {
      return BitConverter.ToSingle(FltBytes, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong BitConverter_ToUInt64()
   {
      return BitConverter.ToUInt64(Ui64Bytes, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long BitConverter_ToInt64()
   {
      return BitConverter.ToInt64(I64Bytes, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint BitConverter_ToUInt32()
   {
      return BitConverter.ToUInt32(Ui32Bytes, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int BitConverter_ToInt32()
   {
      return BitConverter.ToInt32(I32Bytes, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort BitConverter_ToUInt16()
   {
      return BitConverter.ToUInt16(Ui16Bytes, 0);
   }

   [Benchmark]
   public short BitConverter_ToInt16()
   {
      return BitConverter.ToInt16(I16Bytes, 0);
   }

   #endregion

   #region ByteIndexer

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double ByteIndexer_From_A_Double()
   {
      return ((LittleEndianByteIndexer) Dbl).StoreBytes(DblBytes, 0, sizeof(double));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float ByteIndexer_From_A_Float()
   {
      return ((LittleEndianByteIndexer) Flt).StoreBytes(FltBytes, 0, sizeof(float));
   }

   [Benchmark(Baseline = true)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong ByteIndexer_From_A_UInt64()
   {
      return ((LittleEndianByteIndexer) Ui64).StoreBytes(Ui64Bytes, 0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long ByteIndexer_From_A_Int64()
   {
      return ((LittleEndianByteIndexer) I64).StoreBytes(I64Bytes, 0, sizeof(long));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint ByteIndexer_From_A_UInt32()
   {
      return ((LittleEndianByteIndexer) Ui32).StoreBytes(Ui32Bytes, 0, sizeof(uint));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int ByteIndexer_From_A_Int32()
   {
      return ((LittleEndianByteIndexer) I32).StoreBytes(I32Bytes, 0, sizeof(int));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort ByteIndexer_From_A_UInt16()
   {
      return ((LittleEndianByteIndexer) Ui16).StoreBytes(Ui16Bytes, 0, sizeof(ushort));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public short ByteIndexer_From_A_Int16()
   {
      return ((LittleEndianByteIndexer) I16).StoreBytes(I16Bytes, 0, sizeof(short));
   }

   #endregion

   #region ByteIndexer on ReadOnlySpan

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double ByteIndexer_On_ReadOnlySpan_Double()
   {
      return ((LittleEndianByteIndexer) Dbl).StoreBytes((ReadOnlySpan<byte>) DblBytes, 0, sizeof(double));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float ByteIndexer_On_ReadOnlySpan_Float()
   {
      return ((LittleEndianByteIndexer) Flt).StoreBytes((ReadOnlySpan<byte>) FltBytes, 0, sizeof(float));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong ByteIndexer_On_ReadOnlySpan_UInt64()
   {
      return ((LittleEndianByteIndexer) Ui64).StoreBytes((ReadOnlySpan<byte>) Ui64Bytes, 0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long ByteIndexer_On_ReadOnlySpan_Int64()
   {
      return ((LittleEndianByteIndexer) I64).StoreBytes((ReadOnlySpan<byte>) I64Bytes, 0, sizeof(long));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint ByteIndexer_On_ReadOnlySpan_UInt32()
   {
      return ((LittleEndianByteIndexer) Ui32).StoreBytes((ReadOnlySpan<byte>) Ui32Bytes, 0, sizeof(uint));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int ByteIndexer_On_ReadOnlySpan_Int32()
   {
      return ((LittleEndianByteIndexer) I32).StoreBytes((ReadOnlySpan<byte>) I32Bytes, 0, sizeof(int));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort ByteIndexer_On_ReadOnlySpan_UInt16()
   {
      return ((LittleEndianByteIndexer) Ui16).StoreBytes((ReadOnlySpan<byte>) Ui16Bytes, 0, sizeof(ushort));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public short ByteIndexer_On_ReadOnlySpan_Int16()
   {
      return ((LittleEndianByteIndexer) I16).StoreBytes((ReadOnlySpan<byte>) I16Bytes, 0, sizeof(short));
   }

   #endregion

   #region Extension Methods

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double ExtensionMethod_On_A_Double()
   {
      return Dbl.StoreBytes(DblBytes, 0, sizeof(double));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float ExtensionMethod_On_A_Float()
   {
      return Flt.StoreBytes(FltBytes, 0, sizeof(float));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong ExtensionMethod_On_A_UInt64()
   {
      return Ui64.StoreBytes(Ui64Bytes, 0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long ExtensionMethod_On_A_Int64()
   {
      return I64.StoreBytes(I64Bytes, 0, sizeof(long));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint ExtensionMethod_On_A_UInt32()
   {
      return Ui32.StoreBytes(Ui32Bytes, 0, sizeof(uint));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int ExtensionMethod_On_A_Int32()
   {
      return I32.StoreBytes(I32Bytes, 0, sizeof(int));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort ExtensionMethod_On_A_UInt16()
   {
      return Ui16.StoreBytes(Ui16Bytes, 0, sizeof(ushort));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public short ExtensionMethod_On_A_Int16()
   {
      return I16.StoreBytes(I16Bytes, 0, sizeof(short));
   }

   #endregion

   #region To<int-type> Extension Methods

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double ExtensionMethod_On_A_Byte_Array_ToDouble()
   {
      return DblBytes.ToDouble(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float ExtensionMethod_On_A_Byte_Array_ToFloat()
   {
      return FltBytes.ToSingle(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong ExtensionMethod_On_A_Byte_Array_ToUInt64()
   {
      return Ui64Bytes.ToUInt64(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long ExtensionMethod_On_A_Byte_Array_ToInt64()
   {
      return I64Bytes.ToInt64(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint ExtensionMethod_On_A_Byte_Array_ToUInt32()
   {
      return Ui32Bytes.ToUInt32(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int ExtensionMethod_On_A_Byte_Array_ToInt32()
   {
      return I32Bytes.ToInt32(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort ExtensionMethod_On_A_Byte_Array_ToUInt16()
   {
      return Ui16Bytes.ToUInt16(Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public short ExtensionMethod_On_A_Byte_Array_ToInt16()
   {
      return I16Bytes.ToInt16(Endian.Big);
   }

   #endregion
}