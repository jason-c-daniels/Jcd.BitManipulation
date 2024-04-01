#region

using System.Runtime.CompilerServices;

using BenchmarkDotNet.Attributes;

// ReSharper disable UnusedType.Global
// ReSharper disable RedundantTypeDeclarationBody
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable MemberCanBeMadeStatic
#pragma warning disable CA1822
#pragma warning disable S109

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
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Double()
   {
      var bytes = BitConverter.GetBytes(Dbl);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Float()
   {
      var bytes = BitConverter.GetBytes(Flt);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt64()
   {
      var bytes = BitConverter.GetBytes(Ui64);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Int64()
   {
      var bytes = BitConverter.GetBytes(I64);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt32()
   {
      var bytes = BitConverter.GetBytes(Ui32);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_Int32()
   {
      var bytes = BitConverter.GetBytes(I32);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] BitConverter_GetBytes_UInt16()
   {
      var bytes = BitConverter.GetBytes(Ui16);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   [Benchmark]
   public byte[] BitConverter_GetBytes_Int16()
   {
      var bytes = BitConverter.GetBytes(I16);

      if (!BitConverter.IsLittleEndian)
      {
         Array.Reverse(bytes);
      }

      return bytes;
   }

   #endregion

   #region LittleEndianByteIndexer

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_Double()
   {
      return ((LittleEndianByteIndexer) Dbl).Slice(0, sizeof(double));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_Float()
   {
      return ((LittleEndianByteIndexer) Flt).Slice(0, sizeof(float));
   }

   [Benchmark(Baseline = true)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_UInt64()
   {
      return ((LittleEndianByteIndexer) Ui64).Slice(0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_Int64()
   {
      return ((LittleEndianByteIndexer) I64).Slice(0, sizeof(long));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_UInt32()
   {
      return ((LittleEndianByteIndexer) Ui32).Slice(0, sizeof(uint));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_Int32()
   {
      return ((LittleEndianByteIndexer) I32).Slice(0, sizeof(int));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_UInt16()
   {
      return ((LittleEndianByteIndexer) Ui16).Slice(0, sizeof(ushort));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] LittleEndianByteIndexer_Slice_Int16()
   {
      return ((LittleEndianByteIndexer) I16).Slice(0, sizeof(short));
   }

   #endregion

   #region Extension Methods

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Double()
   {
      return Dbl.ReadBytes(0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Float()
   {
      return Flt.ReadBytes(0, sizeof(float));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_UInt64()
   {
      return Ui64.ReadBytes(0, sizeof(ulong));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Int64()
   {
      return I64.ReadBytes(0, sizeof(long) / 2);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_UInt32()
   {
      return Ui32.ReadBytes(0, sizeof(uint));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Int32()
   {
      return I32.ReadBytes(0, sizeof(int) / 2);
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_UInt16()
   {
      return Ui16.ReadBytes(0, sizeof(ushort));
   }

   [Benchmark]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public byte[] ExtensionMethod_ReadBytes_On_A_Int16()
   {
      return I16.ReadBytes(0, sizeof(short) / 2);
   }

   #endregion
}