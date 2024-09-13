#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## UInt32Extensions Class

Provides easy to read methods for bit manipulation operations on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

```csharp
public static class UInt32Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt32Extensions

### Example

```csharp
uint data = 0;

// turn on all the bits
data = data.SetBits(0, 32); // value is now 0b11111111111111111111111111111111

// this is the equivalent as above
data = data.SetBits();

// Clear the middle 4 bits.
data = data.ClearBits(4, 8); // value is now 0b11111111111111111111000000001111

// Toggle all the bits.
data = data.ToggleBits(); // value is now 0b00000000000000000000111111110000

var finalData = data;

// read the second byte
var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

// write 0b1011 into the upper nybble
secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

// chaining operations, the same steps and end results
data.ClearBits();
data = data.SetBits(0, 32) // value is now 0b11111111111111111111111111111111
           .SetBits() // this is the equivalent as above
           .ClearBits(4, 8) // value is now 01111111111111111b1111000000001111
           .ToggleBits(); // value is now 0b00000000000000000000111111110000

secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
                         .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111

// finalData is 0b00000000000000000000111111110000

var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big)
                           .StoreByte(0b01010101, 0, Endian.Little) // lower byte is now 0b01010101
;
// mutatedData is now 0b10111111000000000000111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00001111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111,
                                                   //       0b00000000, 0b10111111]

var leBaToUInt32Le = leBa.ToUInt32(Endian.Little); // leBaToUInt32Le = 0b10111111000000000000111101010101

var leBaToUInt32Be = leBa.ToUInt32(Endian.Big); // leBaToUInt32Be = 0b01010101000011110000000010111111
```

| Methods                                                                                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                            |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSet(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.AreAllBitsSet(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.AreAllBitsSet(this uint, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if all of the bits from the bitmask are set on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').                                                                         |
| [AreAnyBitsSet(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.AreAnyBitsSet(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.AreAnyBitsSet(this uint, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if any bits from the bitmask are set on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').                                                                                |
| [AreNoBitsSet(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.AreNoBitsSet(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.AreNoBitsSet(this uint, Jcd.BitManipulation.BitMask)')                                                                                                   | Tests if none of the bits from the bitmask are set on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').                                                                        |
| [BitwiseToSingle(this uint)](Jcd.BitManipulation.UInt32Extensions.BitwiseToSingle(thisuint) 'Jcd.BitManipulation.UInt32Extensions.BitwiseToSingle(this uint)')                                                                                                                                                            | Converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to the bit-wise identical [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') |
| [ClearBit(this uint, int)](Jcd.BitManipulation.UInt32Extensions.ClearBit(thisuint,int) 'Jcd.BitManipulation.UInt32Extensions.ClearBit(this uint, int)')                                                                                                                                                                   | Sets the specified bit to "off" and returns the modified value.                                                                                                                                                            |
| [ClearBits(this uint, int, int)](Jcd.BitManipulation.UInt32Extensions.ClearBits(thisuint,int,int) 'Jcd.BitManipulation.UInt32Extensions.ClearBits(this uint, int, int)')                                                                                                                                                  | Sets all specified bits to "off" and returns the modified value.                                                                                                                                                           |
| [ClearBits(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.ClearBits(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.ClearBits(this uint, Jcd.BitManipulation.BitMask)')                                                                                                            | Sets all bits from the provided mask to "off" and returns the modified value.                                                                                                                                              |
| [ReadBit(this uint, int)](Jcd.BitManipulation.UInt32Extensions.ReadBit(thisuint,int) 'Jcd.BitManipulation.UInt32Extensions.ReadBit(this uint, int)')                                                                                                                                                                      | Reads a single bit from the specified position.                                                                                                                                                                            |
| [ReadBits(this uint, int, int)](Jcd.BitManipulation.UInt32Extensions.ReadBits(thisuint,int,int) 'Jcd.BitManipulation.UInt32Extensions.ReadBits(this uint, int, int)')                                                                                                                                                     | Reads the bits specified and returns the result shifted to the right by the offset.                                                                                                                                        |
| [ReadBits(this uint, int, BitMask)](Jcd.BitManipulation.UInt32Extensions.ReadBits(thisuint,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.ReadBits(this uint, int, Jcd.BitManipulation.BitMask)')                                                                                                 | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                                                                                                    |
| [ReadBits(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.ReadBits(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.ReadBits(this uint, Jcd.BitManipulation.BitMask)')                                                                                                               | Extract a subset of bits specified by a bitmask.                                                                                                                                                                           |
| [ReadByte(this uint, int, Endian)](Jcd.BitManipulation.UInt32Extensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt32Extensions.ReadByte(this uint, int, Jcd.BitManipulation.Endian)')                                                                                                    | Reads a single byte from the value at the specified byte offset.                                                                                                                                                           |
| [ReadBytes(this uint, int, int, Endian)](Jcd.BitManipulation.UInt32Extensions.ReadBytes(thisuint,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt32Extensions.ReadBytes(this uint, int, int, Jcd.BitManipulation.Endian)')                                                                                   | Reads a set of bytes starting at the specified byte location within the value.                                                                                                                                             |
| [SetBit(this uint, int)](Jcd.BitManipulation.UInt32Extensions.SetBit(thisuint,int) 'Jcd.BitManipulation.UInt32Extensions.SetBit(this uint, int)')                                                                                                                                                                         | Sets the bit at the specified to 1 and returns the modified value.                                                                                                                                                         |
| [SetBits(this uint, int, int)](Jcd.BitManipulation.UInt32Extensions.SetBits(thisuint,int,int) 'Jcd.BitManipulation.UInt32Extensions.SetBits(this uint, int, int)')                                                                                                                                                        | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                               |
| [SetBits(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.SetBits(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.SetBits(this uint, Jcd.BitManipulation.BitMask)')                                                                                                                  | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                               |
| [StoreBit(this uint, bool, int)](Jcd.BitManipulation.UInt32Extensions.StoreBit(thisuint,bool,int) 'Jcd.BitManipulation.UInt32Extensions.StoreBit(this uint, bool, int)')                                                                                                                                                  | Store a single bit at the specified offset and returns the modified value.                                                                                                                                                 |
| [StoreBits(this uint, uint, int, int)](Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,int) 'Jcd.BitManipulation.UInt32Extensions.StoreBits(this uint, uint, int, int)')                                                                                                                                 | Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.                                                                   |
| [StoreBits(this uint, uint, int, BitMask)](Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.StoreBits(this uint, uint, int, Jcd.BitManipulation.BitMask)')                                                                             | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value.                                        |
| [StoreByte(this uint, byte, int, Endian)](Jcd.BitManipulation.UInt32Extensions.StoreByte(thisuint,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt32Extensions.StoreByte(this uint, byte, int, Jcd.BitManipulation.Endian)')                                                                                | Stores a single byte to the value at the specified byte offset and returns the modified value.                                                                                                                             |
| [StoreBytes(this uint, byte[], int, int, Endian)](Jcd.BitManipulation.UInt32Extensions.StoreBytes(thisuint,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt32Extensions.StoreBytes(this uint, byte[], int, int, Jcd.BitManipulation.Endian)')                                                         | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                                |
| [StoreBytes(this uint, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.UInt32Extensions.StoreBytes(thisuint,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt32Extensions.StoreBytes(this uint, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                                |
| [ToBooleanArray(this uint)](Jcd.BitManipulation.UInt32Extensions.ToBooleanArray(thisuint) 'Jcd.BitManipulation.UInt32Extensions.ToBooleanArray(this uint)')                                                                                                                                                               | Converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') into an array of  values with the lease significant bit at index 0.                                                  |
| [ToByteArray(this uint, Endian)](Jcd.BitManipulation.UInt32Extensions.ToByteArray(thisuint,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt32Extensions.ToByteArray(this uint, Jcd.BitManipulation.Endian)')                                                                                                         | Converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian').        |
| [ToggleBit(this uint, int)](Jcd.BitManipulation.UInt32Extensions.ToggleBit(thisuint,int) 'Jcd.BitManipulation.UInt32Extensions.ToggleBit(this uint, int)')                                                                                                                                                                | Toggles a bit at the specified offset and returns the modified value.                                                                                                                                                      |
| [ToggleBits(this uint, int, int)](Jcd.BitManipulation.UInt32Extensions.ToggleBits(thisuint,int,int) 'Jcd.BitManipulation.UInt32Extensions.ToggleBits(this uint, int, int)')                                                                                                                                               | Toggles the specified range of bits and returns the modified value.                                                                                                                                                        |
| [ToggleBits(this uint, BitMask)](Jcd.BitManipulation.UInt32Extensions.ToggleBits(thisuint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt32Extensions.ToggleBits(this uint, Jcd.BitManipulation.BitMask)')                                                                                                         | Toggle all the bits specified in the provided bit mask and returns the modified value.                                                                                                                                     |
