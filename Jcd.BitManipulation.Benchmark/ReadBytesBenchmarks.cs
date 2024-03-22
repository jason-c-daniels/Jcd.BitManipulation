#define REF_STRUCT
using BenchmarkDotNet.Attributes;

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable UnusedMember.Local
// ReSharper disable MemberCanBePrivate.Global
using Jcd.BitManipulation.ByteIndexers;

namespace Jcd.BitManipulation.Benchmark;

public class BigEndianReadBytesBenchmarks
{
   private const ulong  Ui64 = ulong.MaxValue  / 2;
   private const long   I64  = long.MaxValue   / 2;
   private const uint   Ui32 = uint.MaxValue   / 2;
   private const int    I32  = int.MaxValue    / 2;
   private const ushort Ui16 = ushort.MaxValue / 2;
   private const short  I16  = short.MaxValue  / 2;
   private const double Dbl  = double.MaxValue / 2;
   private const float  Flt  = float.MaxValue  / 2;

   #region BitConverter

   [Benchmark]
   public byte[] BitConverter_GetBytes_Double()
   {
      var bytes = BitConverter.GetBytes(Dbl);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Float()
   {
      var bytes = BitConverter.GetBytes(Flt);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_UInt64()
   {
      var bytes = BitConverter.GetBytes(Ui64);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Int64()
   {
      var bytes = BitConverter.GetBytes(I64);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_UInt32()
   {
      var bytes = BitConverter.GetBytes(Ui32);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Int32()
   {
      var bytes = BitConverter.GetBytes(I32);
      Array.Reverse(bytes);

      return bytes;
   }

   [Benchmark]
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

   #if !REF_STRUCT
   #region BigEndianByteIndexer

   private static readonly BigEndianByteIndexer Bebiui64 = Ui64;
   private static readonly BigEndianByteIndexer Bebii64  = I64;
   private static readonly BigEndianByteIndexer Bebiui32 = Ui32;
   private static readonly BigEndianByteIndexer Bebii32  = I32;
   private static readonly BigEndianByteIndexer Bebiui16 = Ui16;
   private static readonly BigEndianByteIndexer Bebii16  = I16;
   private static readonly BigEndianByteIndexer BebiDbl  = Dbl;
   private static readonly BigEndianByteIndexer BebiFlt  = Flt;

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Double() { return BebiDbl.Slice(0, sizeof(double)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Float() { return BebiFlt.Slice(0, sizeof(float)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_UInt64() { return Bebiui64.Slice(0, sizeof(ulong)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Int64() { return Bebii64.Slice(0, sizeof(long)); }
   
   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_UInt32() { return Bebiui32.Slice(0, sizeof(uint)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Int32() { return Bebii32.Slice(0, sizeof(int)); }
   
   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_UInt16() { return Bebiui16.Slice(0, sizeof(ushort)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Int16() { return Bebii16.Slice(0, sizeof(short)); }

   #endregion
   #endif

   #region BigEndianByteIndexer New Instance Each Call

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Double_New_Inst() { return ((BigEndianByteIndexer) Dbl).Slice(0, sizeof(double)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Float_New_Inst() { return ((BigEndianByteIndexer) Flt).Slice(0, sizeof(float)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_UInt64_New_Inst() { return ((BigEndianByteIndexer) Ui64).Slice(0, sizeof(ulong)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Int64_New_Inst() { return ((BigEndianByteIndexer) I64).Slice(0, sizeof(long)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_UInt32_New_Inst() { return ((BigEndianByteIndexer) Ui32).Slice(0, sizeof(uint)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Int32_New_Inst() { return ((BigEndianByteIndexer) I32).Slice(0, sizeof(int)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_UInt16_New_Inst() { return ((BigEndianByteIndexer) Ui16).Slice(0, sizeof(ushort)); }

   [Benchmark]
   public byte[] BigEndianByteIndexer_Slice_Int16_New_Inst() { return ((BigEndianByteIndexer) I16).Slice(0, sizeof(short)); }

   #endregion

   #region Extension Methods

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Double() { return Dbl.ReadBytes(0, sizeof(ulong), Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Float() { return Flt.ReadBytes(0, sizeof(float), Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_UInt64() { return Ui64.ReadBytes(0, sizeof(ulong), Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Int64() { return I64.ReadBytes(0, sizeof(long) / 2, Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_UInt32() { return Ui32.ReadBytes(0, sizeof(uint), Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Int32() { return I32.ReadBytes(0, sizeof(int) / 2, Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_UInt16() { return Ui16.ReadBytes(0, sizeof(ushort), Endian.Big); }

   [Benchmark]
   public byte[] ExtensionMethod_ReadBytes_Int16() { return I16.ReadBytes(0, sizeof(short) / 2, Endian.Big); }

   #endregion

   #region Type Specific ByteIndexers

   private static readonly BigEndianByteIndexerUInt64 Beui64 = Ui64;
   private static readonly BigEndianByteIndexerInt64  Bei64  = I64;
   private static readonly BigEndianByteIndexerUInt32 Beui32 = Ui32;
   private static readonly BigEndianByteIndexerInt32  Bei32  = I32;
   private static readonly BigEndianByteIndexerUInt16 Beui16 = Ui16;
   private static readonly BigEndianByteIndexerInt16  Bei16  = I16;
   private static readonly BigEndianByteIndexerDouble BeDbl  = Dbl;
   private static readonly BigEndianByteIndexerSingle BeFlt  = Flt;

   [Benchmark]
   public byte[] BigEndianByteIndexerFloat_Slice() { return BeFlt.Slice(0, sizeof(float)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerDouble_Slice() { return BeDbl.Slice(0, sizeof(double)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerUInt64_Slice() { return Beui64.Slice(0, sizeof(ulong)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerInt64_Slice() { return Bei64.Slice(0, sizeof(long)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerUInt32_Slice() { return Beui32.Slice(0, sizeof(uint)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerInt32_Slice() { return Bei32.Slice(0, sizeof(int)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerUInt16_Slice() { return Beui16.Slice(0, sizeof(ushort)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerInt16_Slice() { return Bei16.Slice(0, sizeof(short)); }

   #endregion

   #region Type Specific BigEndianByteIndexer - New Instance Each Call

   [Benchmark]
   public byte[] BigEndianByteIndexerDouble_Slice_New_Inst() { return ((BigEndianByteIndexerDouble) Dbl).Slice(0, sizeof(double)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerFloat_Slice_New_Inst() { return ((BigEndianByteIndexerSingle) Flt).Slice(0, sizeof(float)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerUInt64_Slice_New_Inst() { return ((BigEndianByteIndexerUInt64) Ui64).Slice(0, sizeof(ulong)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerInt64_Slice_New_Inst() { return ((BigEndianByteIndexerInt64) I64).Slice(0, sizeof(long)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerUInt32_Slice_New_Inst() { return ((BigEndianByteIndexerUInt32) Ui32).Slice(0, sizeof(uint)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerInt32_Slice_New_Inst() { return ((BigEndianByteIndexerInt32) I32).Slice(0, sizeof(int)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerUInt16_Slice_New_Inst() { return ((BigEndianByteIndexerUInt16) Ui16).Slice(0, sizeof(ushort)); }

   [Benchmark]
   public byte[] BigEndianByteIndexerInt16_Slice_New_Inst() { return ((BigEndianByteIndexerInt16) I16).Slice(0, sizeof(short)); }

   #endregion

   
}