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
/// 
/// // read the upper byte
/// var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111
/// 
/// // write 0b1011 into the upper nybble
/// upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111
/// 
/// // chaining operations, the same steps and end results
/// data.ClearBits();
/// data = data.SetBits(0, 16)  // value is now 0b1111111111111111
///            .SetBits()       // this is the equivalent as above
///            .ClearBits(4, 8) // value is now 0b1111000000001111
///            .ToggleBits();   // value is now 0b0000111111110000
/// 
/// upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
///   .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111
/// 
/// // finalData 0b0000111111110000
/// var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
/// var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000
/// 
/// var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big)     // Upper byte is now 0b10111111 
///                            .StoreByte(0b01010101, 0, Endian.Little); // lower byte is now 0b01010101
/// 
/// // mutatedData is now 0b1011111101010101                                                                                                          
/// 
/// var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]
/// 
/// var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]
/// 
/// var leBaToUInt16Le = (BitMask) leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101
/// 
/// var leBaToUInt16Be = (BitMask) leBa.ToUInt16(Endian.Big);   // leBaToUInt16Le  = 0b0101010110111111
/// 
/// // ByteIndexers on 64 bit values
/// BigEndianByteIndexer bebi = 0xDECAFFC0FFEEC0DE;
/// LittleEndianByteIndexer lebi = 0xDECAFFC0FFEEC0DE;
/// 
/// Console.WriteLine(bebi.ToString()); // outputs: "DE CA FF C0 FF EE C0 DE"
/// Console.WriteLine(lebi.ToString()); // outputs: "DE C0 EE FF C0 FF CA DE"
/// 
/// var bebib1 = bebi[1]; // bebib1 = 0xCA 
/// var lebib1 = lebi[1]; // lebib1 = 0xC0
/// 
/// bebi[0] = 0x0A;
/// lebi[0] = 0x0B;
/// 
/// Console.WriteLine(bebi.ToString()); // outputs: "0A CA FF C0 FF EE C0 DE"
/// Console.WriteLine(lebi.ToString()); // outputs: "0B C0 EE FF C0 FF CA DE"
/// 
/// // ByteIndexers on 32 bit values
/// bebi = 0x600DC0DE;
/// lebi = 0x600DC0DE;
/// 
/// Console.WriteLine(bebi.ToString()); // outputs: "60 0D C0 DE"
/// Console.WriteLine(lebi.ToString()); // outputs: "DE C0 0D 60"
/// 
/// bebib1 = bebi[1]; // bebib1 = 0x0D
/// lebib1 = lebi[1]; // lebib1 = 0xC0
/// 
/// bebi[0] = 0x0A;
/// lebi[0] = 0x0B;
/// 
/// Console.WriteLine(bebi.ToString()); // outputs: "0A 0D C0 DE"
/// Console.WriteLine(lebi.ToString()); // outputs: "0B C0 0D 60"
/// </code>
/// </example>
internal class NamespaceDoc;