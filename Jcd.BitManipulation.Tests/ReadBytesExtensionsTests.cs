#region

using System.Collections.Generic;

using Jcd.BitManipulation.ByteIndexers;

using Xunit;

// ReSharper disable HeapView.ObjectAllocation.Evident

#endregion

namespace Jcd.BitManipulation.Tests;

public class ReadBytesExtensionsTests
{
   #region ReadByte Tests

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFA, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFB, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFC, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFD, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xFE, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xFF, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xF8, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xF9, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFA, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFB, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFC, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFD, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xFE, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xFF, Endian.Big)]
   public void ReadByte_On_UInt64_Returns_Expected_Value(ulong data, int offset, byte expected, Endian endian)
   {
      Assert.Equal(expected, data.ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFA, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFB, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFC, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFD, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xFE, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xFF, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xF8, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xF9, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFA, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFB, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFC, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFD, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xFE, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xFF, Endian.Big)]
   public void ReadByte_On_Int64_Returns_Expected_Value(ulong data, int offset, byte expected, Endian endian)
   {
      var ldata = (long) data;
      Assert.Equal(expected, ldata.ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xFA, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xFB, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xF8, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xF9, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xFA, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 0, 0xFB, Endian.Big)]
   public void ReadByte_On_UInt32_Returns_Expected_Value(uint data, int offset, byte expected, Endian endian)
   {
      Assert.Equal(expected, data.ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xFA, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xFB, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xF8, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xF9, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xFA, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 0, 0xFB, Endian.Big)]
   public void ReadByte_On_Int32_Returns_Expected_Value(uint data, int offset, byte expected, Endian endian)
   {
      var ldata = (int) data;
      Assert.Equal(expected, ldata.ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xF9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xF9_F8, 1, 0xF8, Endian.Big)]
   [InlineData(0xF9_F8, 0, 0xF9, Endian.Big)]
   public void ReadByte_On_UInt16_Returns_Expected_Value(ushort data, int offset, byte expected, Endian endian)
   {
      Assert.Equal(expected, data.ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xF9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xF9_F8, 1, 0xF8, Endian.Big)]
   [InlineData(0xF9_F8, 0, 0xF9, Endian.Big)]
   public void ReadByte_On_Int16_Returns_Expected_Value(ushort data, int offset, byte expected, Endian endian)
   {
      var ldata = (short) data;
      Assert.Equal(expected, ldata.ReadByte(offset, endian));
   }

   #endregion

   #region ReadBytes - Integral Data Type Tests

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_UInt64_Returns_Expected_Array(ulong data, int offset, int size)
   {
      var expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data.ReadByte(i + offset));
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_Int64_Returns_Expected_Array(ulong data, int offset, int size)
   {
      var ldata    = (long) data;
      var expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(ldata.ReadByte(i + offset));
      Assert.Equal(expected.ToArray(), ldata.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_UInt32_Returns_Expected_Array(uint data, int offset, int size)
   {
      var expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data.ReadByte(i + offset));
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_Int32_Returns_Expected_Array(uint data, int offset, int size)
   {
      var ldata    = (int) data;
      var expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(ldata.ReadByte(i + offset));
      Assert.Equal(expected.ToArray(), ldata.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_UInt16_Returns_Expected_Array(ushort data, int offset, int size)
   {
      var expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data.ReadByte(i + offset));
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_Int16_Returns_Expected_Array(ushort data, int offset, int size)
   {
      var ldata    = (short) data;
      var expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(ldata.ReadByte(i + offset));
      Assert.Equal(expected.ToArray(), ldata.ReadBytes(offset, size));
   }

   #endregion

   #region ReadBytes - LittleEndianByteIndexer Tests

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_LittleEndianByteIndexerUInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
   {
      LittleEndianByteIndexerUInt64 data     = baseData;
      var                           expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_LittleEndianByteIndexerInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
   {
      LittleEndianByteIndexerInt64 data     = (long) baseData;
      var                          expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_LittleEndianByteIndexerUInt32_Returns_Expected_Array(uint baseData, int offset, int size)
   {
      LittleEndianByteIndexerUInt32 data     = baseData;
      var                           expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_LittleEndianByteIndexerInt32_Returns_Expected_Array(uint baseData, int offset, int size)
   {
      LittleEndianByteIndexerInt32 data     = (int) baseData;
      var                          expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_LittleEndianByteIndexerUInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
   {
      LittleEndianByteIndexerUInt16 data     = baseData;
      var                           expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_LittleEndianByteIndexerInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
   {
      LittleEndianByteIndexerInt16 data     = (short) baseData;
      var                          expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   #endregion

   #region ReadBytes - BigEndianByteIndexer Tests

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_BigEndianByteIndexerUInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
   {
      BigEndianByteIndexerUInt64 data     = baseData;
      var                        expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_BigEndianByteIndexerInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
   {
      BigEndianByteIndexerInt64 data     = (long) baseData;
      var                       expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_BigEndianByteIndexerUInt32_Returns_Expected_Array(uint baseData, int offset, int size)
   {
      BigEndianByteIndexerUInt32 data     = baseData;
      var                        expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_BigEndianByteIndexerInt32_Returns_Expected_Array(uint baseData, int offset, int size)
   {
      BigEndianByteIndexerInt32 data     = (int) baseData;
      var                       expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_BigEndianByteIndexerUInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
   {
      BigEndianByteIndexerUInt16 data     = baseData;
      var                        expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_BigEndianByteIndexerInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
   {
      BigEndianByteIndexerInt16 data     = (short) baseData;
      var                       expected = new List<byte>();
      for (var i = 0; i < size; i++) expected.Add(data[i + offset]);
      Assert.Equal(expected.ToArray(), data.ReadBytes(offset, size));
   }

   #endregion
}