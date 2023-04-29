namespace Jcd.BitManipulation.ByteIndexers;

/// <summary>
/// Some helper methods for converting to and from a ByteIndexer.
/// </summary>
public static class ByteIndexerExtensions
{
    /// <summary>
    /// Returns a ByteIndexer for a byte
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerByte with a copy of the original data</returns>
    public static ByteIndexerByte ToByteIndexer(this byte data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for an sbyte
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerSByte with a copy of the original data</returns>
    public static ByteIndexerSByte ToByteIndexer(this sbyte data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for a short
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerInt16 with a copy of the original data</returns>
    public static ByteIndexerInt16 ToByteIndexer(this short data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for a ushort
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerUInt16 with a copy of the original data</returns>
    public static ByteIndexerUInt16 ToByteIndexer(this ushort data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for an int
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerInt32 with a copy of the original data</returns>
    public static ByteIndexerInt32 ToByteIndexer(this int data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for a uint
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerUInt32 with a copy of the original data</returns>
    public static ByteIndexerUInt32 ToByteIndexer(this uint data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for a long
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerInt64 with a copy of the original data</returns>
    public static ByteIndexerInt64 ToByteIndexer(this long data)
    {
        return data;
    }

    /// <summary>
    /// Returns a ByteIndexer for a ulong
    /// </summary>
    /// <param name="data">the data to convert</param>
    /// <returns>A ByteIndexerUInt64 with a copy of the original data</returns>
    public static ByteIndexerUInt64 ToByteIndexer(this ulong data)
    {
        return data;
    }
}