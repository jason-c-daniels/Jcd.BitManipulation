namespace Jcd.BitManipulation;

#pragma warning disable S1118
internal static class BitSizeConstants
   #pragma warning restore S1118
{
   internal const int ShiftOneByte = 3;
   internal const int BitsPerByte = 8;
   internal const int MaxBitSize = sizeof(ulong) * BitsPerByte;
}