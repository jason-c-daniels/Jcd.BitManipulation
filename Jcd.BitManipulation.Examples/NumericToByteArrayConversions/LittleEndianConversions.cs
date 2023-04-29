using System;

namespace Jcd.BitManipulation.Examples.NumericToByteArrayConversions;

public static class LittleEndianConversions
{
    #region ToLittleEndianByteArray

    public static byte[] ToLittleEndianByteArray(this ulong value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this long value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this uint value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this int value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this ushort value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this short value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this float value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    public static byte[] ToLittleEndianByteArray(this double value)
    {
        // Value in bytes... in your system's endianness
        var bytes = BitConverter.GetBytes(value);

        // If it was little endian, reverse it
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return bytes;
    }

    #endregion

    #region Ints from Little Endian Arrays

    public static ulong UInt64FromLittleEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToUInt64(bytes, 0);
    }

    public static long Int64FromLittleEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToInt64(bytes, 0);
    }

    public static uint UInt32FromLittleEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToUInt32(bytes, 0);
    }

    public static int Int32FromLittleEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToInt32(bytes, 0);
    }

    public static ushort UInt16FromLittleEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToUInt16(bytes, 0);
    }

    public static short Int16FromLittleEndianByteArray(this byte[] bytes)
    {
        // If the system architecture is little-endian (that is, little end first),
        // reverse the byte array.
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(bytes);

        return BitConverter.ToInt16(bytes, 0);
    }

    #endregion
}