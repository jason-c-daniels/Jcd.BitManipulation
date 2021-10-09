using System.Linq;

namespace Jcd.BitManipulation
{
    /// <summary>
    /// Some helper methods for converting to and from a BitIndexer.
    /// </summary>
    public static class BitIndexerExtensions
    {
        /// <summary>
        /// Returns a BitIndexer for a byte
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerByte with a copy of the original data</returns>
        public static BitIndexerByte ToBitIndexer(this byte data) => data;

        /// <summary>
        /// Returns a BitIndexer for an sbyte
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerSByte with a copy of the original data</returns>
        public static BitIndexerSByte ToBitIndexer(this sbyte data) => data;

        /// <summary>
        /// Returns a BitIndexer for a short
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerInt16 with a copy of the original data</returns>
        public static BitIndexerInt16 ToBitIndexer(this short data) => data;

        /// <summary>
        /// Returns a BitIndexer for a ushort
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerUInt16 with a copy of the original data</returns>
        public static BitIndexerUInt16 ToBitIndexer(this ushort data) => data;
        
        /// <summary>
        /// Returns a BitIndexer for an int
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerInt32 with a copy of the original data</returns>
        public static BitIndexerInt32 ToBitIndexer(this int data) => data;

        /// <summary>
        /// Returns a BitIndexer for a uint
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerUInt32 with a copy of the original data</returns>
        public static BitIndexerUInt32 ToBitIndexer(this uint data) => data;
        
        /// <summary>
        /// Returns a BitIndexer for a long
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerInt64 with a copy of the original data</returns>
        public static BitIndexerInt64 ToBitIndexer(this long data) => data;

        /// <summary>
        /// Returns a BitIndexer for a ulong
        /// </summary>
        /// <param name="data">the data to convert</param>
        /// <returns>A BitIndexerUInt64 with a copy of the original data</returns>
        public static BitIndexerUInt64 ToBitIndexer(this ulong data) => data;

        //TODO: Improve the performance of these methods. This is stupidly slow.
 
        /// <summary>
        /// Convert an IBitIndexer into a byte
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static byte ToByte(this IBitIndexer indexer)
            => indexer.ToArray().ToByte();

        /// <summary>
        /// Convert an IBitIndexer into an sbyte
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static sbyte ToSByte(this IBitIndexer indexer)
            => indexer.ToArray().ToSByte();

        /// <summary>
        /// Convert an IBitIndexer into a short
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static short ToInt16(this IBitIndexer indexer)
            => indexer.ToArray().ToInt16();

        /// <summary>
        /// Convert an IBitIndexer into a ushort
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static ushort ToUInt16(this IBitIndexer indexer)
            => indexer.ToArray().ToUInt16();
        
        /// <summary>
        /// Convert an IBitIndexer into an int
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static int ToInt32(this IBitIndexer indexer)
            => indexer.ToArray().ToInt32();

        /// <summary>
        /// Convert an IBitIndexer into a uint
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static uint ToUInt32(this IBitIndexer indexer)
            => indexer.ToArray().ToUInt32();
        
        /// <summary>
        /// Convert an IBitIndexer into a long
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static long ToInt64(this IBitIndexer indexer)
            => indexer.ToArray().ToInt64();

        /// <summary>
        /// Convert an IBitIndexer into a ulong
        /// </summary>
        /// <param name="indexer">the indexer to convert</param>
        /// <returns>the converted value</returns>
        public static ulong ToUInt64(this IBitIndexer indexer)
            => indexer.ToArray().ToUInt64();
        
    }
}