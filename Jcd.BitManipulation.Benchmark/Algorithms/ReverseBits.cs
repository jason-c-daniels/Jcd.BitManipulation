#region

using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

#endregion

namespace Jcd.BitManipulation.Benchmark.Algorithms;

public class ReverseBits
{


   [Benchmark]
   [Arguments(0x75)]
   [Arguments(0x74)]
   public byte On_Byte(byte b)
   {
      return b.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x75)]
   [Arguments(0x74)]
   public sbyte On_SByte(sbyte sb)
   {
      return sb.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x7575)]
   [Arguments(0x7474)]
   public ushort On_UInt16(ushort us)
   {
      return us.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x7575)]
   [Arguments(0x7474)]
   public short On_Int16(short s)
   {
      return s.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x75757575)]
   [Arguments(0x74747474)]
   public uint On_UInt32(uint ui)
   {
      return ui.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x75757575)]
   [Arguments(0x74747474)]
   public int On_Int32(int i)
   {
      return i.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x7575757575757575)]
   [Arguments(0x7474747474747474)]
   public ulong On_UInt64(ulong ul)
   {
      return ul.ReverseBits();
   }

   [Benchmark]
   [Arguments(0x7575757575757575)]
   [Arguments(0x7474747474747474)]
   public long On_Int64(long l)
   {
      return l.ReverseBits();
   }
}