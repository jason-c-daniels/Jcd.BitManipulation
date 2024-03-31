#region

using System;
using System.Collections.Generic;

#region

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global
#pragma warning disable S4136
using Xunit;

#endregion

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class BigEndianByteIndexerTests
{
   public static IEnumerable<object[]> TypesToStrings
      => new List<object[]>
         {
            new object[] { (ulong) 0x01000000CC000001, "01 00 00 00 CC 00 00 01", false }
          , new object[] { 0x020000FE00000001, "02 00 00 FE 00 00 00 01", false }
          , new object[] { (uint) 0x01000002, "01 00 00 02", false }
          , new object[] { 0x02000001, "02 00 00 01", false }
          , new object[] { (ushort) 0x0100, "01 00", false }
          , new object[] { (short) 0x0200, "02 00", false }
          , new object[] { 0x0FFC00A0.BitwiseToSingle(), "0F FC 00 A0", false }
          , new object[] { 0xCFEFEFEF0FFC00A0.BitwiseToDouble(), "CF EF EF EF 0F FC 00 A0", false }
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

   private static BigEndianByteIndexer GetIndexer(object o, bool flag)
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
                                ? (BigEndianByteIndexer) (ReadOnlySpan<byte>) ba
                                : (BigEndianByteIndexer) ba
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