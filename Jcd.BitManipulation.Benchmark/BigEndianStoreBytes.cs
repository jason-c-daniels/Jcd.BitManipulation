#region

using BenchmarkDotNet.Attributes;

#endregion

namespace Jcd.BitManipulation.Benchmark;

public class BigEndianStoreBytes
{
   private const ulong Ui64 = ulong.MaxValue   / 2;
   private const long I64 = long.MaxValue      / 2;
   private const uint Ui32 = uint.MaxValue     / 2;
   private const int I32 = int.MaxValue        / 2;
   private const ushort Ui16 = ushort.MaxValue / 2;
   private const short I16 = short.MaxValue    / 2;
   private const double Dbl = double.MaxValue  / 2;
   private const float Flt = float.MaxValue    / 2;

   private static readonly byte[] Bytes = [0, 1, 2, 3, 4, 5, 6, 7];

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
   public double BitConverter_ToDouble()
   {
      Array.Reverse(DblBytes);

      return BitConverter.ToDouble(DblBytes, 0);
   }

   [Benchmark]
   public float BitConverter_ToFloat()
   {
      Array.Reverse(FltBytes);

      return BitConverter.ToSingle(FltBytes, 0);
   }

   [Benchmark]
   public ulong BitConverter_ToUInt64()
   {
      Array.Reverse(Ui64Bytes);

      return BitConverter.ToUInt64(Ui64Bytes, 0);
   }

   [Benchmark]
   public long BitConverter_ToInt64()
   {
      Array.Reverse(I64Bytes);

      return BitConverter.ToInt64(Ui64Bytes, 0);
   }

   [Benchmark]
   public uint BitConverter_ToUInt32()
   {
      Array.Reverse(Ui32Bytes);

      return BitConverter.ToUInt32(Ui32Bytes, 0);
   }

   [Benchmark]
   public int BitConverter_ToInt32()
   {
      Array.Reverse(Ui32Bytes);

      return BitConverter.ToInt32(I32Bytes, 0);
   }

   [Benchmark]
   public ushort BitConverter_ToUInt16()
   {
      Array.Reverse(Ui16Bytes);

      return BitConverter.ToUInt16(Ui16Bytes, 0);
   }

   [Benchmark(Baseline = true)]
   public short BitConverter_ToInt16()
   {
      Array.Reverse(I16Bytes);

      return BitConverter.ToInt16(I16Bytes, 0);
   }

   #endregion

   #region Extension Methods

   [Benchmark]
   public double ExtensionMethod_Double()
   {
      return Dbl.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public float ExtensionMethod_Float()
   {
      return Flt.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public ulong ExtensionMethod_UInt64()
   {
      return Ui64.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public long ExtensionMethod_Int64()
   {
      return I64.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public uint ExtensionMethod_UInt32()
   {
      return Ui32.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public int ExtensionMethod_Int32()
   {
      return I32.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public ushort ExtensionMethod_UInt16()
   {
      return Ui16.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   [Benchmark]
   public short ExtensionMethod_Int16()
   {
      return I16.StoreBytes(Bytes, 0, endian: Endian.Big);
   }

   #endregion

   #region ByteIndexer

   [Benchmark]
   public double ByteIndexer_Double()
   {
      return ((BigEndianByteIndexer) Dbl).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public float ByteIndexer_Float()
   {
      return ((BigEndianByteIndexer) Flt).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public ulong ByteIndexer_UInt64()
   {
      return ((BigEndianByteIndexer) Ui64).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public long ByteIndexer_Int64()
   {
      return ((BigEndianByteIndexer) I64).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public uint ByteIndexer_UInt32()
   {
      return ((BigEndianByteIndexer) Ui32).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public int ByteIndexer_Int32()
   {
      return ((BigEndianByteIndexer) I32).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public ushort ByteIndexer_UInt16()
   {
      return ((BigEndianByteIndexer) Ui16).StoreBytes(Bytes, 0);
   }

   [Benchmark]
   public short ByteIndexer_Int16()
   {
      return ((BigEndianByteIndexer) I16).StoreBytes(Bytes, 0);
   }

   #endregion
}