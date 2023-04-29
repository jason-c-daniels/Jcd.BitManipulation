using System;

namespace Jcd.BitManipulation.Examples.NumericToByteArrayConversions;

public static class BigEndianConversions
{
    #region ToBigEndianByteArray

    public static byte[] ToBigEndianByteArray(this ulong value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this long value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this uint value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this int value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this ushort value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this short value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this float value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToBigEndianByteArray(this double value)
    {
        // Value in bytes... in your system's endianness (let's say: little endian)
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    #endregion

    #region Ints from Big Endian Byte Array

    public static ulong UInt64FromBigEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToUInt64(bytes, 0);
    }

    public static long Int64FromBigEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToInt64(bytes, 0);
    }

    public static uint UInt32FromBigEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToUInt32(bytes, 0);
    }

    public static int Int32FromBigEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToInt32(bytes, 0);
    }

    public static ushort UInt16FromBigEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToUInt16(bytes, 0);
    }

    public static short Int16FromBigEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToInt16(bytes, 0);
    }

    #endregion
}