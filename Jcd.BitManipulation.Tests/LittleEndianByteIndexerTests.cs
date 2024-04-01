#region

using System;
using System.Collections.Generic;

using Xunit;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global

#pragma warning disable S4136

#endregion

namespace Jcd.BitManipulation.Tests;

public class LittleEndianByteIndexerTests
{
   [Theory]
   [MemberData(nameof(TypesToStrings))]
   public void Implicit_Cast_ToString_Returns_Expected_String(object item, string expectedString, bool arrayAsSpan)
   {
      var sut = GetIndexer(item, arrayAsSpan);
      Assert.Equal(expectedString, sut.ToString());
   }

   [Theory]
   [InlineData(1ul)]
   [InlineData(ulong.MaxValue)]
   [InlineData(ulong.MinValue + 3)]
   public void Conversion_From_BigEndianByteIndexer_Gives_Expected_Result(ulong data)
   {
      BigEndianByteIndexer leData = data;
      var sut = (LittleEndianByteIndexer) leData;
      Assert.Equal(data, (ulong) sut);
   }

   [Theory]
   [InlineData(1ul)]
   [InlineData(ulong.MaxValue)]
   [InlineData(ulong.MinValue + 3)]
   public void CopyConstructor_Gives_Expected_Result(ulong data)
   {
      LittleEndianByteIndexer beData = data;
      var sut = beData;
      Assert.Equal(data, (ulong) sut);
   }

   [Theory]
   [InlineData(1)]
   [InlineData(uint.MaxValue)]
   [InlineData(uint.MinValue + 3)]
   public void Conversion_To_Single_Gives_Expected_Result(uint data)
   {
      var expected = data.BitwiseToSingle();
      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected, (float) sut);
   }

   [Theory]
   [InlineData(1ul)]
   [InlineData(ulong.MaxValue)]
   [InlineData(ulong.MinValue + 3)]
   public void Conversion_To_Double_Gives_Expected_Result(ulong data)
   {
      var expected = data.BitwiseToDouble();
      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected, (double) sut);
   }

   [Theory]
   [InlineData(0x0D0C0B0A, new byte[] { 0x0A, 0x0B, 0x0C, 0x0D })]
   [InlineData(0xD0C0B0A0, new byte[] { 0xA0, 0xB0, 0xC0, 0xD0 })]
   public void Conversion_To_Byte_Array_Gives_Expected_Result(uint data, byte[] expected)
   {
      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected, (byte[]) sut);
   }

   [Theory]
   [InlineData(0x0D0C0B0A, new byte[] { 0x0A, 0x0B, 0x0C, 0x0D })]
   [InlineData(0xD0C0B0A0, new byte[] { 0xA0, 0xB0, 0xC0, 0xD0 })]
   public void Conversion_To_ReadOnlySpan_Gives_Expected_Result(uint data, byte[] bytes)
   {
      LittleEndianByteIndexer sut = data;
      ReadOnlySpan<byte> expected = bytes;
      var result = (ReadOnlySpan<byte>) sut;
      Assert.Equal(expected.ToArray(), result.ToArray());
   }

   #region Indexer Get Tests

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xF8)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xF9)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFA)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFB)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFC)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFD)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xFE)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xFF)]
   public void Indexer_Get_On_Double_Returns_Expected_Value(ulong data, int offset, byte expected)
   {
      Assert.Equal(expected, ((LittleEndianByteIndexer) data.BitwiseToDouble())[offset]);
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 0xF8)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xF9)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xFA)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xFB)]
   public void Indexer_Get_On_Single_Returns_Expected_Value(uint data, int offset, byte expected)
   {
      Assert.Equal(expected, ((LittleEndianByteIndexer) data.BitwiseToSingle())[offset]);
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xF8)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xF9)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFA)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFB)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFC)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFD)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xFE)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xFF)]
   public void Indexer_Get_On_UInt64_Returns_Expected_Value(ulong data, int offset, byte expected)
   {
      Assert.Equal(expected, ((LittleEndianByteIndexer) data)[offset]);
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xF8)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xF9)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFA)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFB)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFC)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFD)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xFE)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xFF)]
   public void Indexer_Get_On_Int64_Returns_Expected_Value(ulong data, int offset, byte expected)
   {
      var ldata = (long) data;
      Assert.Equal(expected, ((LittleEndianByteIndexer) ldata)[offset]);
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 0xF8)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xF9)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xFA)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xFB)]
   public void Indexer_Get_On_UInt32_Returns_Expected_Value(uint data, int offset, byte expected)
   {
      Assert.Equal(expected, ((LittleEndianByteIndexer) data)[offset]);
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 0xF8)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xF9)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xFA)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xFB)]
   public void Indexer_Get_On_Int32_Returns_Expected_Value(uint data, int offset, byte expected)
   {
      var ldata = (int) data;
      Assert.Equal(expected, ((LittleEndianByteIndexer) ldata)[offset]);
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 0xF8)]
   [InlineData(0xF9_F8, 1, 0xF9)]
   public void Indexer_Get_On_UInt16_Returns_Expected_Value(ushort data, int offset, byte expected)
   {
      Assert.Equal(expected, ((LittleEndianByteIndexer) data)[offset]);
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 0xF8)]
   [InlineData(0xF9_F8, 1, 0xF9)]
   public void Indexer_Get_On_Int16_Returns_Expected_Value(ushort data, int offset, byte expected)
   {
      var ldata = (short) data;
      Assert.Equal(expected, ((LittleEndianByteIndexer) ldata)[offset]);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(10)]
   public void Indexer_Get_Throws_ArgumentOutOfRangeException_When_Given_Invalid_Index(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = 0xFF_FE_FD_FC_FA_F9_F8_F7;
                                                    _ = sut[index];
                                                 }
                                                );
   }

   #endregion

   #region Indexer Set Tests

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_00_00_00_00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_00_00_00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_00_00_00_FF_00_00)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_00_FE_00_00_00)]
   [InlineData(0, (byte) 0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
   [InlineData(0, (byte) 0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
   [InlineData(0, (byte) 0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
   [InlineData(0, (byte) 0xFA, 7, 0xFA_00_00_00_00_00_00_00)]
   public void Indexer_Set_On_UInt64_Returns_Expected_Value(ulong rawValue, byte data, int offset, ulong expected)
   {
      LittleEndianByteIndexer value = rawValue;
      value[offset] = data;
      Assert.Equal(expected, (ulong) value);
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
   public void Indexer_Set_On_Int64_Returns_Expected_Value(long rawValue, byte data, int offset, long expected)
   {
      LittleEndianByteIndexer value = rawValue;
      value[offset] = data;
      Assert.Equal(expected, (long) value);
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00)]
   [InlineData(0, (byte) 0xFE, 3, 0xFE_00_00_00)]
   public void Indexer_Set_On_UInt32_Returns_Expected_Value(uint rawValue, byte data, int offset, uint expected)
   {
      LittleEndianByteIndexer value = rawValue;
      value[offset] = data;
      Assert.Equal(expected, (uint) value);
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00)]
   [InlineData(0, (byte) 0x0E, 3, 0x0E_00_00_00)]
   public void Indexer_Set_On_Int32_Returns_Expected_Value(int rawValue, byte data, int offset, int expected)
   {
      LittleEndianByteIndexer value = rawValue;
      value[offset] = data;
      Assert.Equal(expected, (int) value);
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_01)]
   [InlineData(0, (byte) 0x02, 1, 0x02_00)]
   public void Indexer_Set_On_UInt16_Returns_Expected_Value(ushort rawValue, byte data, int offset, ushort expected)
   {
      LittleEndianByteIndexer value = rawValue;
      value[offset] = data;
      Assert.Equal(expected, (ushort) value);
   }

   [Theory]
   [InlineData((short) 0, (byte) 0x01, 0, (short) 0x00_01)]
   [InlineData((short) 0, (byte) 0x02, 1, (short) 0x02_00)]
   public void Indexer_Set_On_Int16_Returns_Expected_Value(short rawValue, byte data, int offset, short expected)
   {
      LittleEndianByteIndexer value = rawValue;
      value[offset] = data;
      Assert.Equal(expected, (short) value);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(10)]
   public void Indexer_Set_Throws_ArgumentOutOfRangeException_When_Given_Invalid_Index(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = 0xFF_FE_FD_FC_FA_F9_F8_F7;
                                                    sut[index] = 0;
                                                 }
                                                );
   }

   #endregion

   #region ReadBytes Tests

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_UInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
   {
      LittleEndianByteIndexer data = baseData;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data[i + offset]);
      }

      Assert.Equal(expected.ToArray(), data.Slice(offset, size));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_Int64_Returns_Expected_Array(ulong baseData, int offset, int size)
   {
      LittleEndianByteIndexer data = (long) baseData;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data[i + offset]);
      }

      Assert.Equal(expected.ToArray(), data.Slice(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_UInt32_Returns_Expected_Array(uint baseData, int offset, int size)
   {
      LittleEndianByteIndexer data = baseData;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data[i + offset]);
      }

      Assert.Equal(expected.ToArray(), data.Slice(offset, size));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4)]
   [InlineData(0xFB_FA_F9_F8, 1, 3)]
   [InlineData(0xFB_FA_F9_F8, 2, 2)]
   [InlineData(0xFB_FA_F9_F8, 0, 3)]
   public void ReadBytes_On_Int32_Returns_Expected_Array(uint baseData, int offset, int size)
   {
      LittleEndianByteIndexer data = (int) baseData;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data[i + offset]);
      }

      Assert.Equal(expected.ToArray(), data.Slice(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_UInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
   {
      LittleEndianByteIndexer data = baseData;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data[i + offset]);
      }

      Assert.Equal(expected.ToArray(), data.Slice(offset, size));
   }

   [Theory]
   [InlineData(0xF9_F8, 0, 2)]
   [InlineData(0xFB_FA, 1, 1)]
   public void ReadBytes_On_Int16_Returns_Expected_Array(ushort baseData, int offset, int size)
   {
      LittleEndianByteIndexer data = (short) baseData;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data[i + offset]);
      }

      Assert.Equal(expected.ToArray(), data.Slice(offset, size));
   }

   #endregion

   #region StoreBytes From Byte Array Tests

   [Theory]
   [MemberData(nameof(UInt64StoreBytes))]
   public void StoreBytes_On_UInt64_Given_Byte_Array_Expected_Value(ulong rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal((ulong) expected, (ulong) actual);
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytes))]
   public void StoreBytes_On_Int64_Given_Byte_Array_Expected_Value(long rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(long); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal((ulong) expected, (ulong) actual);
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytes))]
   public void StoreBytes_On_UInt32_Given_Byte_Array_Expected_Value(uint rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal((uint) expected, (uint) actual);
   }

   [Theory]
   [MemberData(nameof(Int32StoreBytes))]
   public void StoreBytes_On_Int32_Given_Byte_Array_Expected_Value(int rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(int); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal((int) expected, (int) actual);
   }

   [Theory]
   [MemberData(nameof(UInt16StoreBytes))]
   public void StoreBytes_On_UInt16_Given_Byte_Array_Expected_Value(ushort rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal((ushort) expected, (ushort) actual);
   }

   [Theory]
   [MemberData(nameof(Int16StoreBytes))]
   public void StoreBytes_On_Int16_Given_Byte_Array_Expected_Value(short rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(short); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal((short) expected, (short) actual);
   }

   [Theory]
   [MemberData(nameof(ByteStoreBytes))]
   public void StoreBytes_On_Byte_Given_Byte_Array_Expected_Value(byte rawData, int offset, int size, byte[] bytes)
   {
      LittleEndianByteIndexer data = rawData;
      var expected = bytes[0];
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, (byte) actual);
   }

   [Theory]
   [MemberData(nameof(SByteStoreBytes))]
   public void StoreBytes_On_SByte_Given_Byte_Array_Expected_Value(sbyte rawData, int offset, int size, byte[] bytes)
   {
      LittleEndianByteIndexer data = rawData;
      var expected = (sbyte) bytes[0];
      var actual = data.StoreBytes(bytes, offset, size);
      Assert.Equal(expected, (sbyte) actual);
   }

   [Fact]
   public void StoreBytes_Throws_Argument_Null_Exception_When_Given_Null_Array()
   {
      Assert.Throws<ArgumentNullException>(() =>
                                           {
                                              LittleEndianByteIndexer data = 0ul;
                                              data.StoreBytes(null, 0);
                                           }
                                          );
   }

   #endregion

   #region StoreBytes From ReadOnlySpan of Bytes Tests

   [Theory]
   [MemberData(nameof(UInt64StoreBytes))]
   public void StoreBytes_On_UInt64_Given_ReadOnlySpan_Of_Bytes_Expected_Value(ulong rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal((ulong) expected, (ulong) actual);
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytes))]
   public void StoreBytes_On_Int64_Given_ReadOnlySpan_Of_Bytes_Expected_Value(long rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(long); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal((ulong) expected, (ulong) actual);
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytes))]
   public void StoreBytes_On_UInt32_Given_ReadOnlySpan_Of_Bytes_Expected_Value(uint rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal((uint) expected, (uint) actual);
   }

   [Theory]
   [MemberData(nameof(Int32StoreBytes))]
   public void StoreBytes_On_Int32_Given_ReadOnlySpan_Of_Bytes_Expected_Value(int rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(int); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal((int) expected, (int) actual);
   }

   [Theory]
   [MemberData(nameof(UInt16StoreBytes))]
   public void StoreBytes_On_UInt16_Given_ReadOnlySpan_Of_Bytes_Expected_Value(ushort rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal((ushort) expected, (ushort) actual);
   }

   [Theory]
   [MemberData(nameof(Int16StoreBytes))]
   public void StoreBytes_On_Int16_Given_ReadOnlySpan_Of_Bytes_Expected_Value(short rawData, int offset, int size, byte[] bytes)
   {
      var rawExpected = rawData;
      LittleEndianByteIndexer data = rawData;

      for (var i = 0; i < size && i + offset < sizeof(short); i++)
      {
         rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
      }

      LittleEndianByteIndexer expected = rawExpected;
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal((short) expected, (short) actual);
   }

   [Theory]
   [MemberData(nameof(ByteStoreBytes))]
   public void StoreBytes_On_Byte_Given_ReadOnlySpan_Of_Bytes_Expected_Value(byte rawData, int offset, int size, byte[] bytes)
   {
      LittleEndianByteIndexer data = rawData;
      var expected = bytes[0];
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal(expected, (byte) actual);
   }

   [Theory]
   [MemberData(nameof(SByteStoreBytes))]
   public void StoreBytes_On_SByte_Given_ReadOnlySpan_Of_Bytes_Expected_Value(sbyte rawData, int offset, int size, byte[] bytes)
   {
      LittleEndianByteIndexer data = rawData;
      var expected = (sbyte) bytes[0];
      ReadOnlySpan<byte> span = bytes;
      var actual = data.StoreBytes(span, offset, size);
      Assert.Equal(expected, (sbyte) actual);
   }

   #endregion

   #region DataMember Data Providers and Helpers

   public static IEnumerable<object[]> UInt64StoreBytes
      => new List<object[]>
         {
            new object[] { 0xFC_00_00_00_00_00_00_00, 0, 1, new byte[] { 0xFF } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 3, new byte[] { 0xFF, 0xFE, 0xFD } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 4, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 5, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 6, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 7, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 } }
          , new object[] { 0xFC_00_00_00_00_00_00_00, 0, 8, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9, 0xF8 } }
          , new object[] { 0xFE_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 0, 8, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D, 0x07, 0x06 } }
         };

   public static IEnumerable<object[]> Int64StoreBytes
      => new List<object[]>
         {
            new object[] { 0x0C_00_00_00_00_00_00_00, 0, 1, new byte[] { 0xFF } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 3, new byte[] { 0xFF, 0xFE, 0xFD } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 4, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 5, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 6, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 7, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 } }
          , new object[] { 0x0C_00_00_00_00_00_00_00, 0, 8, new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9, 0xF8 } }
          , new object[] { 0x0E_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x7E_00_00_00_00_00_00_01, 0, 8, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D, 0x07, 0x06 } }
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

   public static IEnumerable<object[]> TypesToStrings
      => new List<object[]>
         {
            new object[] { (ulong) 0x01000000CC000001, "01 00 00 CC 00 00 00 01", false }
          , new object[] { 0x020000FE00000001, "01 00 00 00 FE 00 00 02", false }
          , new object[] { (uint) 0x01000002, "02 00 00 01", false }
          , new object[] { 0x02000001, "01 00 00 02", false }
          , new object[] { (ushort) 0x0100, "00 01", false }
          , new object[] { (short) 0x0200, "00 02", false }
          , new object[] { 0x0FFC00A0.BitwiseToSingle(), "A0 00 FC 0F", false }
          , new object[] { 0xCFEFEFEF0FFC00A0.BitwiseToDouble(), "A0 00 FC 0F EF EF EF CF", false }
          , new object[] { new byte[] { 0xFF }, "FF", false }
          , new object[] { new byte[] { 0xF2 }, "F2", true }
          , new object[] { new byte[] { 0xFF, 0xFC }, "FF FC", false }
          , new object[] { new byte[] { 0xFF, 0xFB }, "FF FB", true }
          , new object[] { new byte[] { 0xFF, 0xFC, 0xFD }, "FF FC FD 00", false }
          , new object[] { new byte[] { 0xFF, 0xFA, 0xFD }, "FF FA FD 00", true }
          , new object[] { new byte[] { 0xFF, 0xFC, 0xF1, 0xFE, 0xFA }, "FF FC F1 FE FA 00 00 00", false }
          , new object[] { new byte[] { 0xFF, 0xF0, 0xFD, 0xFE, 0xFA }, "FF F0 FD FE FA 00 00 00", true }
          , new object[] { new byte[] { 0xFF, 0xEF, 0xEF, 0xEF, 0x0F, 0xFC, 0x00, 0xA0 }, "FF EF EF EF 0F FC 00 A0", false }
          , new object[] { new byte[] { 0xAF, 0xEF, 0xEF, 0xEF, 0x0F, 0xFC, 0x00, 0xA0 }, "AF EF EF EF 0F FC 00 A0", true }
         };

   public static IEnumerable<object[]> SByteStoreBytes
      => new List<object[]> { new object[] { (sbyte) 0x0F, 0, 1, new byte[] { 0xFF } }, new object[] { (sbyte) 0x0E, 0, 1, new byte[] { 0xFE } } };

   public static IEnumerable<object[]> ByteStoreBytes
      => new List<object[]> { new object[] { (byte) 0xFF, 0, 1, new byte[] { 0xFF } }, new object[] { (byte) 0xFE, 0, 1, new byte[] { 0xFE } } };

   private static LittleEndianByteIndexer GetIndexer(object o, bool flag)
   {
      return o switch
             {
                ulong ul  => ul
              , long l    => l
              , uint ui   => ui
              , int i     => i
              , ushort us => us
              , short us  => us
              , sbyte sb  => sb
              , byte b    => b
              , float f   => f
              , double d  => d
              , byte[] ba => flag
                                ? (LittleEndianByteIndexer) (ReadOnlySpan<byte>) ba
                                : (LittleEndianByteIndexer) ba
              , _ => 0xDEADBEEFFA17C0DEul
             };
   }

   #endregion
}