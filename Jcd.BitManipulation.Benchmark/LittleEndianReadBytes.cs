#region

using BenchmarkDotNet.Attributes;

#endregion

namespace Jcd.BitManipulation.Benchmark;

public class LittleEndianReadBytes
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
   public byte[] BitConverter_GetBytes_Double()
   {
      var bytes = BitConverter.GetBytes(Dbl);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Float()
   {
      var bytes = BitConverter.GetBytes(Flt);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_UInt64()
   {
      var bytes = BitConverter.GetBytes(Ui64);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Int64()
   {
      var bytes = BitConverter.GetBytes(I64);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_UInt32()
   {
      var bytes = BitConverter.GetBytes(Ui32);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Int32()
   {
      var bytes = BitConverter.GetBytes(I32);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_UInt16()
   {
      var bytes = BitConverter.GetBytes(Ui16);

      return bytes;
   }

   [Benchmark(Baseline = true)]
   public byte[] BitConverter_GetBytes_Int16()
   {
      var bytes = BitConverter.GetBytes(I16);

      return bytes;
   }

   #endregion

   #region LittleEndianByteIndexer

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_Double()
   {
      return ((LittleEndianByteIndexer) Dbl).Slice(0, sizeof(double));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_Float()
   {
      return ((LittleEndianByteIndexer) Flt).Slice(0, sizeof(float));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_UInt64()
   {
      return ((LittleEndianByteIndexer) Ui64).Slice(0, sizeof(ulong));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_Int64()
   {
      return ((LittleEndianByteIndexer) I64).Slice(0, sizeof(long));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_UInt32()
   {
      return ((LittleEndianByteIndexer) Ui32).Slice(0, sizeof(uint));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_Int32()
   {
      return ((LittleEndianByteIndexer) I32).Slice(0, sizeof(int));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_UInt16()
   {
      return ((LittleEndianByteIndexer) Ui16).Slice(0, sizeof(ushort));
   }

   [Benchmark]
   public byte[] LittleEndianByteIndexer_Slice_Int16()
   {
      return ((LittleEndianByteIndexer) I16).Slice(0, sizeof(short));
   }

   #endregion

   #region Extension Methods

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Double()
   {
      return Dbl.ReadBytes(0, sizeof(ulong));
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Float()
   {
      return Flt.ReadBytes(0, sizeof(float));
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_UInt64()
   {
      return Ui64.ReadBytes(0, sizeof(ulong));
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Int64()
   {
      return I64.ReadBytes(0, sizeof(long) / 2);
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_UInt32()
   {
      return Ui32.ReadBytes(0, sizeof(uint));
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Int32()
   {
      return I32.ReadBytes(0, sizeof(int) / 2);
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_UInt16()
   {
      return Ui16.ReadBytes(0, sizeof(ushort));
   }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Int16()
   {
      return I16.ReadBytes(0, sizeof(short) / 2);
   }

   #endregion
}