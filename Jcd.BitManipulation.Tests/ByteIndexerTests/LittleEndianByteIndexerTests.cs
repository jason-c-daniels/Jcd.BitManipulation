﻿#region

using System;
using System.Collections.Generic;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class LittleEndianByteIndexerTests
{
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

   private LittleEndianByteIndexer GetIndexer(object o, bool flag)
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

   [Theory]
   [MemberData(nameof(TypesToStrings))]
   public void Implicit_Cast_ToString_Returns_Expected_String(object item, string expectedString, bool arrayAsSpan)
   {
      var sut = GetIndexer(item, arrayAsSpan);
      Assert.Equal(expectedString, sut.ToString());
   }
}