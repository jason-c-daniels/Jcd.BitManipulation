namespace Jcd.BitManipulation;

#pragma warning disable S1118
internal static class BitSizeConstants
{
   internal const int ThreeBits = 3;
   internal const int BitsPerNybble = 4;
   internal const int BitsPerByte = 8;
   internal const int BitsPerUInt16 = 16;
   internal const int BitsPerUInt32 = 32;
   internal const int BitsPerUInt64 = 64;

   internal const int MaxStorageBitSize = BitsPerUInt64;
}
#pragma warning restore S1118