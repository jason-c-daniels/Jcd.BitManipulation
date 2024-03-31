#region

using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;

// ReSharper disable UnusedType.Global
// ReSharper disable RedundantTypeDeclarationBody
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822
#pragma warning disable S109

#endregion

namespace Jcd.BitManipulation.Benchmark;

public class BigEndianStoreByte
{
   private const ulong Ui64 = ulong.MaxValue   / 2;
   private const long I64 = long.MaxValue      / 2;
   private const uint Ui32 = uint.MaxValue     / 2;
   private const int I32 = int.MaxValue        / 2;
   private const ushort Ui16 = ushort.MaxValue / 2;
   private const short I16 = short.MaxValue    / 2;
   private const double Dbl = double.MaxValue  / 2;
   private const float Flt = float.MaxValue    / 2;

   #region Extension Methods

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double ExtensionMethod_On_A_Double()
   {
      return Dbl.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float ExtensionMethod_On_A_Float()
   {
      return Flt.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong ExtensionMethod_On_A_UInt64()
   {
      return Ui64.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long ExtensionMethod_On_A_Int64()
   {
      return I64.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint ExtensionMethod_On_A_UInt32()
   {
      return Ui32.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int ExtensionMethod_On_A_Int32()
   {
      return I32.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort ExtensionMethod_On_A_UInt16()
   {
      return Ui16.StoreByte(0xDD, 0, Endian.Big);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public short ExtensionMethod_On_A_Int16()
   {
      return I16.StoreByte(0xDD, 0, Endian.Big);
   }

   #endregion

   #region ByteIndexer

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public double ByteIndexer_From_A_Double()
   {
      return ((BigEndianByteIndexer) Dbl).StoreByte(0xDD, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public float ByteIndexer_From_A_Float()
   {
      return ((BigEndianByteIndexer) Flt).StoreByte(0xDD, 0);
   }

   [Benchmark(Baseline = true)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ulong ByteIndexer_From_A_UInt64()
   {
      return ((BigEndianByteIndexer) Ui64).StoreByte(0xDD, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public long ByteIndexer_From_A_Int64()
   {
      return ((BigEndianByteIndexer) I64).StoreByte(0xDD, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public uint ByteIndexer_From_A_UInt32()
   {
      return ((BigEndianByteIndexer) Ui32).StoreByte(0xDD, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public int ByteIndexer_From_A_Int32()
   {
      return ((BigEndianByteIndexer) I32).StoreByte(0xDD, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public ushort ByteIndexer_From_A_UInt16()
   {
      return ((BigEndianByteIndexer) Ui16).StoreByte(0xDD, 0);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public short ByteIndexer_From_A_Int16()
   {
      return ((BigEndianByteIndexer) I16).StoreByte(0xDD, 0);
   }

   #endregion
}