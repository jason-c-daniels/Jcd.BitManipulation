namespace Jcd.BitManipulation;

#pragma warning disable S1118
internal static class BitSizeConstants
{
   internal const int ThreeBits = 3;
   internal const int BitsPerByte = 8;
   internal const int MaxStorageBitSize = sizeof(ulong) * BitsPerByte;
}
#pragma warning restore S1118