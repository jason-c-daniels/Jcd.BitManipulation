#region

using System.Collections.Generic;

using Xunit;

// ReSharper disable HeapView.ObjectAllocation.Evident

#endregion

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable ArrangeTrailingCommaInMultilineLists

namespace Jcd.BitManipulation.Tests;

public class StoreBytesExtensionsTests
{
   #region StoreByte - Intrinsic Data Types Tests

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_00_00_00_00_01, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_00_00_00_00_02_00, Endian.Little)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_00_00_00_FF_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_00_FE_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFD, 4, 0x00_00_00_FD_00_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFC, 5, 0x00_00_FC_00_00_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFB, 6, 0x00_FB_00_00_00_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFA, 7, 0xFA_00_00_00_00_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0x01, 7, 0x00_00_00_00_00_00_00_01, Endian.Big)]
   [InlineData(0, (byte) 0x02, 6, 0x00_00_00_00_00_00_02_00, Endian.Big)]
   [InlineData(0, (byte) 0xFF, 5, 0x00_00_00_00_00_FF_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFE, 4, 0x00_00_00_00_FE_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFD, 3, 0x00_00_00_FD_00_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFC, 2, 0x00_00_FC_00_00_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFB, 1, 0x00_FB_00_00_00_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFA, 0, 0xFA_00_00_00_00_00_00_00, Endian.Big)]
   public void StoreByte_On_UInt64_Returns_Expected_Value(ulong value, byte data, int offset, ulong expected, Endian endian)
   {
      Assert.Equal(expected, value.StoreByte(data, offset, endian));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_00_00_00_00_01L, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_00_00_00_00_02_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_00_00_00_FF_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_00_FE_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFD, 4, 0x00_00_00_FD_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFC, 5, 0x00_00_FC_00_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFB, 6, 0x00_FB_00_00_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFA, 7, 0xFA_00_00_00_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0x01, 7, 0x00_00_00_00_00_00_00_01L, Endian.Big)]
   [InlineData(0, (byte) 0x02, 6, 0x00_00_00_00_00_00_02_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFF, 5, 0x00_00_00_00_00_FF_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFE, 4, 0x00_00_00_00_FE_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFD, 3, 0x00_00_00_FD_00_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFC, 2, 0x00_00_FC_00_00_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFB, 1, 0x00_FB_00_00_00_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFA, 0, 0xFA_00_00_00_00_00_00_00L, Endian.Big)]
   public void StoreByte_On_Int64_Returns_Expected_Value(long value, byte data, int offset, ulong expected, Endian endian)
   {
      Assert.Equal((long) expected, value.StoreByte(data, offset, endian));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00, Endian.Little)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFE, 3, 0xFE_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0x01, 0, 0x01_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0x02, 1, 0x00_02_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_FF_00, Endian.Big)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_FE, Endian.Big)]
   public void StoreByte_On_UInt32_Returns_Expected_Value(uint value, byte data, int offset, uint expected, Endian endian)
   {
      Assert.Equal(expected, value.StoreByte(data, offset, endian));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00, Endian.Little)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFE, 3, 0xFE_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0x01, 0, 0x01_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0x02, 1, 0x00_02_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_FF_00, Endian.Big)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_FE, Endian.Big)]
   public void StoreByte_On_Int32_Returns_Expected_Value(int value, byte data, int offset, uint expected, Endian endian)
   {
      Assert.Equal((int) expected, value.StoreByte(data, offset, endian));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_01, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x02_00, Endian.Little)]
   [InlineData(0, (byte) 0x01, 0, 0x01_00, Endian.Big)]
   [InlineData(0, (byte) 0x02, 1, 0x00_02, Endian.Big)]
   public void StoreByte_On_UInt16_Returns_Expected_Value(ushort value, byte data, int offset, ushort expected, Endian endian)
   {
      Assert.Equal(expected, value.StoreByte(data, offset, endian));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, (short) 0x00_01, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, (short) 0x02_00, Endian.Little)]
   [InlineData(0, (byte) 0x01, 0, (short) 0x01_00, Endian.Big)]
   [InlineData(0, (byte) 0x02, 1, (short) 0x00_02, Endian.Big)]
   public void StoreByte_On_Int16_Returns_Expected_Value(short value, byte data, int offset, short expected, Endian endian)
   {
      Assert.Equal(expected, value.StoreByte(data, offset, endian));
   }

   #endregion

   #region StoreByte BigEndianIndexer Tests

   [Theory]
   [InlineData(0, (byte) 0x01, 7, 0x00_00_00_00_00_00_00_01)]
   [InlineData(0, (byte) 0x02, 6, 0x00_00_00_00_00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 5, 0x00_00_00_00_00_FF_00_00)]
   [InlineData(0, (byte) 0xFE, 4, 0x00_00_00_00_FE_00_00_00)]
   [InlineData(0, (byte) 0xFD, 3, 0x00_00_00_FD_00_00_00_00)]
   [InlineData(0, (byte) 0xFC, 2, 0x00_00_FC_00_00_00_00_00)]
   [InlineData(0, (byte) 0xFB, 1, 0x00_FB_00_00_00_00_00_00)]
   [InlineData(0, (byte) 0xFA, 0, 0xFA_00_00_00_00_00_00_00)]
   public void StoreByte_On_BigEndianByteIndexerUInt64_Returns_Expected_Value(ulong rawValue, byte data, int offset, ulong rawExpected)
   {
      BigEndianByteIndexerUInt64 expected = rawExpected;
      BigEndianByteIndexerUInt64 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData((long) 0, (byte) 0x01, 7, (long) 0x00_00_00_00_00_00_00_01)]
   [InlineData((long) 0, (byte) 0x02, 6, (long) 0x00_00_00_00_00_00_02_00)]
   [InlineData((long) 0, (byte) 0xFF, 5, (long) 0x00_00_00_00_00_FF_00_00)]
   [InlineData((long) 0, (byte) 0xFE, 4, (long) 0x00_00_00_00_FE_00_00_00)]
   [InlineData((long) 0, (byte) 0xFD, 3, 0x00_00_00_FD_00_00_00_00)]
   [InlineData((long) 0, (byte) 0xFC, 2, 0x00_00_FC_00_00_00_00_00)]
   [InlineData((long) 0, (byte) 0xFB, 1, 0x00_FB_00_00_00_00_00_00)]
   [InlineData((long) 0, (byte) 0x0A, 0, 0x0A_00_00_00_00_00_00_00)]
   public void StoreByte_On_BigEndianByteIndexerInt64_Returns_Expected_Value(long rawValue, byte data, int offset, long rawExpected)
   {
      BigEndianByteIndexerInt64 expected = rawExpected;
      BigEndianByteIndexerInt64 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 3, 0x00_00_00_01)]
   [InlineData(0, (byte) 0x02, 2, 0x00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 1, 0x00_FF_00_00)]
   [InlineData(0, (byte) 0xFE, 0, 0xFE_00_00_00)]
   public void StoreByte_On_BigEndianByteIndexerUInt32_Returns_Expected_Value(uint rawValue, byte data, int offset, uint rawExpected)
   {
      BigEndianByteIndexerUInt32 expected = rawExpected;
      BigEndianByteIndexerUInt32 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 3, 0x00_00_00_01)]
   [InlineData(0, (byte) 0x02, 2, 0x00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 1, 0x00_FF_00_00)]
   [InlineData(0, (byte) 0x0E, 0, 0x0E_00_00_00)]
   public void StoreByte_On_BigEndianByteIndexerInt32_Returns_Expected_Value(int rawValue, byte data, int offset, int rawExpected)
   {
      BigEndianByteIndexerInt32 expected = rawExpected;
      BigEndianByteIndexerInt32 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 1, 0x00_01)]
   [InlineData(0, (byte) 0x02, 0, 0x02_00)]
   public void StoreByte_On_BigEndianByteIndexerUInt16_Returns_Expected_Value(ushort rawValue, byte data, int offset, ushort rawExpected)
   {
      BigEndianByteIndexerUInt16 expected = rawExpected;
      BigEndianByteIndexerUInt16 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData((short) 0, (byte) 0x01, 1, (short) 0x00_01)]
   [InlineData((short) 0, (byte) 0x02, 0, (short) 0x02_00)]
   public void StoreByte_On_BigEndianByteIndexerInt16_Returns_Expected_Value(short rawValue, byte data, int offset, short rawExpected)
   {
      BigEndianByteIndexerInt16 expected = rawExpected;
      BigEndianByteIndexerInt16 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   #endregion

   #region StoreByte LittleEndianIndexer Tests

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_00_00_00_00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_00_00_00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_00_00_00_FF_00_00)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_00_FE_00_00_00)]
   [InlineData(0, (byte) 0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
   [InlineData(0, (byte) 0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
   [InlineData(0, (byte) 0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
   [InlineData(0, (byte) 0xFA, 7, 0xFA_00_00_00_00_00_00_00)]
   public void StoreByte_On_LittleEndianByteIndexerUInt64_Returns_Expected_Value(ulong rawValue, byte data, int offset, ulong rawExpected)
   {
      LittleEndianByteIndexerUInt64 expected = rawExpected;
      LittleEndianByteIndexerUInt64 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData((long) 0, (byte) 0x01, 0, (long) 0x00_00_00_00_00_00_00_01)]
   [InlineData((long) 0, (byte) 0x02, 1, (long) 0x00_00_00_00_00_00_02_00)]
   [InlineData((long) 0, (byte) 0xFF, 2, (long) 0x00_00_00_00_00_FF_00_00)]
   [InlineData((long) 0, (byte) 0xFE, 3, (long) 0x00_00_00_00_FE_00_00_00)]
   [InlineData((long) 0, (byte) 0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
   [InlineData((long) 0, (byte) 0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
   [InlineData((long) 0, (byte) 0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
   [InlineData((long) 0, (byte) 0x0A, 7, 0x0A_00_00_00_00_00_00_00)]
   public void StoreByte_On_LittleEndianByteIndexerInt64_Returns_Expected_Value(long rawValue, byte data, int offset, long rawExpected)
   {
      LittleEndianByteIndexerInt64 expected = rawExpected;
      LittleEndianByteIndexerInt64 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00)]
   [InlineData(0, (byte) 0xFE, 3, 0xFE_00_00_00)]
   public void StoreByte_On_LittleEndianByteIndexerUInt32_Returns_Expected_Value(uint rawValue, byte data, int offset, uint rawExpected)
   {
      LittleEndianByteIndexerUInt32 expected = rawExpected;
      LittleEndianByteIndexerUInt32 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00)]
   [InlineData(0, (byte) 0x0E, 3, 0x0E_00_00_00)]
   public void StoreByte_On_LittleEndianByteIndexerInt32_Returns_Expected_Value(int rawValue, byte data, int offset, int rawExpected)
   {
      LittleEndianByteIndexerInt32 expected = rawExpected;
      LittleEndianByteIndexerInt32 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x02_00)]
   public void StoreByte_On_LittleEndianByteIndexerUInt16_Returns_Expected_Value(ushort rawValue, byte data, int offset, ushort rawExpected)
   {
      LittleEndianByteIndexerUInt16 expected = rawExpected;
      LittleEndianByteIndexerUInt16 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   [Theory]
   [InlineData((short) 0, (byte) 0x01, 0, (short) 0x00_01)]
   [InlineData((short) 0, (byte) 0x02, 1, (short) 0x02_00)]
   public void StoreByte_On_LittleEndianByteIndexerInt16_Returns_Expected_Value(short rawValue, byte data, int offset, short rawExpected)
   {
      LittleEndianByteIndexerInt16 expected = rawExpected;
      LittleEndianByteIndexerInt16 value = rawValue;
      Assert.Equal(expected, value.StoreByte(data, offset));
   }

   #endregion

   #region StoreBytes - Integral Data Type Tests

   [Theory]
   [MemberData(nameof(UInt64StoreBytes))]
   public void StoreBytes_On_UInt64_Returns_Expected_Value(ulong data, int offset, int size, byte[] bytes)
   {
      var expected = data;
      for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
         expected = expected.StoreByte(bytes[i], offset + i);
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytes))]
   public void StoreBytes_On_Int64_Returns_Expected_Value(long data, int offset, int size, byte[] bytes)
   {
      var expected = data;
      for (var i = 0; i < size && i + offset < sizeof(long); i++)
         expected = expected.StoreByte(bytes[i], offset + i);
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytes))]
   public void StoreBytes_On_UInt32_Returns_Expected_Value(uint data, int offset, int size, byte[] bytes)
   {
      var expected = data;
      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
         expected = expected.StoreByte(bytes[i], offset + i);
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int32StoreBytes))]
   public void StoreBytes_On_Int32_Returns_Expected_Value(int data, int offset, int size, byte[] bytes)
   {
      var expected = data;
      for (var i = 0; i < size && i + offset < sizeof(int); i++)
         expected = expected.StoreByte(bytes[i], offset + i);
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt16StoreBytes))]
   public void StoreBytes_On_UInt16_Returns_Expected_Value(ushort data, int offset, int size, byte[] bytes)
   {
      var expected = data;
      for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
         expected = expected.StoreByte(bytes[i], offset + i);
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int16StoreBytes))]
   public void StoreBytes_On_Int16_Returns_Expected_Value(short data, int offset, int size, byte[] bytes)
   {
      var expected = data;
      for (var i = 0; i < size && i + offset < sizeof(short); i++)
         expected = expected.StoreByte(bytes[i], offset + i);
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   #endregion

   #region StoreBytes - ByteIndexer Tests

   [Theory]
   [MemberData(nameof(UInt64StoreBytes))]
   public void StoreBytes_On_LittleEndianByteIndexerUInt64_Returns_Expected_Value(ulong rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexerUInt64 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      LittleEndianByteIndexerUInt64 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytes))]
   public void StoreBytes_On_LittleEndianByteIndexerInt64_Returns_Expected_Value(long rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexerInt64 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(long); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      LittleEndianByteIndexerInt64 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytes))]
   public void StoreBytes_On_LittleEndianByteIndexerUInt32_Returns_Expected_Value(uint rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexerUInt32 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      LittleEndianByteIndexerUInt32 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int32StoreBytes))]
   public void StoreBytes_On_LittleEndianByteIndexerInt32_Returns_Expected_Value(int rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexerInt32 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(int); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      LittleEndianByteIndexerInt32 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt16StoreBytes))]
   public void StoreBytes_On_LittleEndianByteIndexerUInt16_Returns_Expected_Value(ushort rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexerUInt16 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      LittleEndianByteIndexerUInt16 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int16StoreBytes))]
   public void StoreBytes_On_LittleEndianByteIndexerInt16_Returns_Expected_Value(short rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexerInt16 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(short); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      LittleEndianByteIndexerInt16 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   #endregion

   #region StoreBytes - ByteIndexer Tests

   [Theory]
   [MemberData(nameof(UInt64StoreBytes))]
   public void StoreBytes_On_BigEndianByteIndexerUInt64_Returns_Expected_Value(ulong rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      BigEndianByteIndexerUInt64 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], sizeof(ulong) - (offset + i) - 1);
      BigEndianByteIndexerUInt64 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytes))]
   public void StoreBytes_On_BigEndianByteIndexerInt64_Returns_Expected_Value(long rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      BigEndianByteIndexerInt64 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(long); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], sizeof(long) - (offset + i) - 1);
      BigEndianByteIndexerInt64 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytes))]
   public void StoreBytes_On_BigEndianByteIndexerUInt32_Returns_Expected_Value(uint rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      BigEndianByteIndexerUInt32 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], sizeof(uint) - (offset + i) - 1);
      BigEndianByteIndexerUInt32 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int32StoreBytes))]
   public void StoreBytes_On_BigEndianByteIndexerInt32_Returns_Expected_Value(int rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      BigEndianByteIndexerInt32 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(int); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], sizeof(int) - (offset + i) - 1);
      BigEndianByteIndexerInt32 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt16StoreBytes))]
   public void StoreBytes_On_BigEndianByteIndexerUInt16_Returns_Expected_Value(ushort rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      BigEndianByteIndexerUInt16 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], sizeof(ushort) - (offset + i) - 1);
      BigEndianByteIndexerUInt16 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int16StoreBytes))]
   public void StoreBytes_On_BigEndianByteIndexerInt16_Returns_Expected_Value(short rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      BigEndianByteIndexerInt16 data = rawData;
      for (var i = 0; i < size && i + offset < sizeof(short); i++)
         rawExpected = rawExpected.StoreByte(bytes[i], sizeof(short) - (offset + i) - 1);
      BigEndianByteIndexerInt16 expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, actual);
   }

   #endregion

   #region DataMember Data Providers

   public static IEnumerable<object[]> UInt64StoreBytes
      => new List<object[]>
         {
            new object[] { 0xFF_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0xFE_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> Int64StoreBytes
      => new List<object[]>
         {
            new object[] { 0x0F_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0x0E_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> UInt32StoreBytes
      => new List<object[]>
         {
            new object[] { 0xFF_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0xFE_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> Int32StoreBytes
      => new List<object[]>
         {
            new object[] { 0x0F_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0x0E_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> UInt16StoreBytes
      => new List<object[]>
         {
            new object[] { (ushort) 0xFF_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { (ushort) 0xFE_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (ushort) 0xFE_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (ushort) 0xFE_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
         };

   public static IEnumerable<object[]> Int16StoreBytes
      => new List<object[]>
         {
            new object[] { (short) 0x0F_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { (short) 0x0E_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (short) 0x0E_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (short) 0x0E_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
         };

   #endregion
}