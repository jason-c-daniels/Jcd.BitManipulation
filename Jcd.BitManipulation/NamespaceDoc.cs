// ReSharper disable UnusedType.Global

namespace Jcd.BitManipulation;

/// <summary>
/// Provides a set of extension methods and types to assist with
/// making bit manipulation code easier to read.
/// </summary>
/// <example>
/// <code>
/// ushort data = 0b0000000000000000;
/// 
/// // turn on all the bits
/// data = data.SetBits(0, 16); // value is now 0b1111111111111111
/// 
/// // this is the equivalent as above
/// data = data.SetBits();
/// 
/// // Clear the middle 4 bits.
/// data = data.ClearBits(4, 8); // value is now 0b1111000000001111
/// 
/// // Toggle all the bits.
/// data = data.ToggleBits(); // value is now 0b0000111111110000
/// 
/// var finalData = data;
/// // read the upper byte
/// var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111
/// 
/// // write 0b1011 into the upper nybble
/// upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111
/// 
/// // chaining operations, the same steps and end results
/// data.ClearBits();
/// data = data.SetBits(0, 16)  // value is now 0b1111111111111111
/// ///      .SetBits()///  // this is the equivalent as above
/// ///      .ClearBits(4, 8) // value is now 0b1111000000001111
/// ///      .ToggleBits();   // value is now 0b0000111111110000
/// 
/// upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
///   .StoreBits(0b1011, 4, 4);/// ///   // store the value in the upper 4 bits, now upperByte is now 0b10111111
/// 
/// // finalData 0b0000111111110000
/// var beByte0     = finalData.ReadByte(0, Endian.Big);/// ///   // 00001111
/// var leByte0     = finalData.ReadByte(0, Endian.Little);///      // 11110000
/// 
/// var mutatedData = finalData
/// /// ///      .StoreByte(0b10111111, 0, Endian.Big)
/// /// ///      .StoreByte(0b01010101, 0, Endian.Little ); // lower byte is now 0b01010101
/// ;/// /// /// /// /// /// /// /// /// ///     // mutatedData is now 0b1011111101010101
/// 
/// var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]
/// 
/// var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]
/// 
/// var leBaToUInt16Le = leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101
/// 
/// var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le = 0b0101010110111111
/// </code>
/// </example>
internal class NamespaceDoc;