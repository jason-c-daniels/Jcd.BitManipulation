#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## UInt16Extensions Class

Provides easy to read methods for bit manipulation operations on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

```csharp
public static class UInt16Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt16Extensions

### Example

```csharp
ushort data = 0b0000000000000000;

// turn on all the bits
data = data.SetBits(0, 16); // value is now 0b1111111111111111

// this is the equivalent as above
data = data.SetBits();

// Clear the middle 4 bits.
data = data.ClearBits(4, 8); // value is now 0b1111000000001111

// Toggle all the bits.
data = data.ToggleBits(); // value is now 0b0000111111110000

var finalData = data;

// read the upper byte
var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111

// write 0b1011 into the upper nybble
upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

// chaining operations, the same steps and end results
data.ClearBits();
data = data.SetBits(0, 16) // value is now 0b1111111111111111
           .SetBits() // this is the equivalent as above
           .ClearBits(4, 8) // value is now 0b1111000000001111
           .ToggleBits(); // value is now 0b0000111111110000

upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
                        .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111

// finalData 0b0000111111110000
var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big) // Upper byte is now 0b10111111
                           .StoreByte(0b01010101, 0, Endian.Little); // lower byte is now 0b01010101

// mutatedData is now 0b1011111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

var leBaToUInt16Le = leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101

var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le = 0b0101010110111111
```

| Methods                                                                                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                     |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSet(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.AreAllBitsSet(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.AreAllBitsSet(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if all of the bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').                                                                  |
| [AreAnyBitsSet(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.AreAnyBitsSet(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.AreAnyBitsSet(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if any bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').                                                                         |
| [AreNoBitsSet(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.AreNoBitsSet(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.AreNoBitsSet(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                   | Tests if none of the bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').                                                                 |
| [ClearBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.ClearBit(thisushort,int) 'Jcd.BitManipulation.UInt16Extensions.ClearBit(this ushort, int)')                                                                                                                                                                   | Sets the specified bit to "off" and returns the modified value.                                                                                                                                                     |
| [ClearBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.ClearBits(thisushort,int,int) 'Jcd.BitManipulation.UInt16Extensions.ClearBits(this ushort, int, int)')                                                                                                                                                  | Sets all specified bits to "off" and returns the modified value.                                                                                                                                                    |
| [ClearBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.ClearBits(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.ClearBits(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                            | Sets all bits from the provided mask to "off" and returns the modified value.                                                                                                                                       |
| [ReadBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.ReadBit(thisushort,int) 'Jcd.BitManipulation.UInt16Extensions.ReadBit(this ushort, int)')                                                                                                                                                                      | Reads a single bit from the specified position.                                                                                                                                                                     |
| [ReadBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int) 'Jcd.BitManipulation.UInt16Extensions.ReadBits(this ushort, int, int)')                                                                                                                                                     | Reads the bits specified and returns the result shifted to the right by the offset.                                                                                                                                 |
| [ReadBits(this ushort, int, BitMask)](Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.ReadBits(this ushort, int, Jcd.BitManipulation.BitMask)')                                                                                                 | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                                                                                             |
| [ReadBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.ReadBits(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                               | Extract a subset of bits specified by a bitmask.                                                                                                                                                                    |
| [ReadByte(this ushort, int, Endian)](Jcd.BitManipulation.UInt16Extensions.ReadByte(thisushort,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt16Extensions.ReadByte(this ushort, int, Jcd.BitManipulation.Endian)')                                                                                                    | Reads a single byte from the value at the specified byte offset.                                                                                                                                                    |
| [ReadBytes(this ushort, int, int, Endian)](Jcd.BitManipulation.UInt16Extensions.ReadBytes(thisushort,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt16Extensions.ReadBytes(this ushort, int, int, Jcd.BitManipulation.Endian)')                                                                                   | Reads a set of bytes starting at the specified byte location within the value.                                                                                                                                      |
| [SetBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.SetBit(thisushort,int) 'Jcd.BitManipulation.UInt16Extensions.SetBit(this ushort, int)')                                                                                                                                                                         | Sets the bit at the specified to 1 and returns the modified value.                                                                                                                                                  |
| [SetBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.SetBits(thisushort,int,int) 'Jcd.BitManipulation.UInt16Extensions.SetBits(this ushort, int, int)')                                                                                                                                                        | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                        |
| [SetBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.SetBits(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.SetBits(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                                  | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                        |
| [StoreBit(this ushort, bool, int)](Jcd.BitManipulation.UInt16Extensions.StoreBit(thisushort,bool,int) 'Jcd.BitManipulation.UInt16Extensions.StoreBit(this ushort, bool, int)')                                                                                                                                                  | Store a single bit at the specified offset and returns the modified value.                                                                                                                                          |
| [StoreBits(this ushort, ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,int) 'Jcd.BitManipulation.UInt16Extensions.StoreBits(this ushort, ushort, int, int)')                                                                                                                           | Stores a range of bits to the value, from a source value, and returns the modified value.                                                                                                                           |
| [StoreBits(this ushort, ushort, int, BitMask)](Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.StoreBits(this ushort, ushort, int, Jcd.BitManipulation.BitMask)')                                                                       | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value.                                     |
| [StoreByte(this ushort, byte, int, Endian)](Jcd.BitManipulation.UInt16Extensions.StoreByte(thisushort,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt16Extensions.StoreByte(this ushort, byte, int, Jcd.BitManipulation.Endian)')                                                                                | Stores a single byte to the value at the specified byte offset and returns the modified value.                                                                                                                      |
| [StoreBytes(this ushort, byte[], int, int, Endian)](Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt16Extensions.StoreBytes(this ushort, byte[], int, int, Jcd.BitManipulation.Endian)')                                                         | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                         |
| [StoreBytes(this ushort, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt16Extensions.StoreBytes(this ushort, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                         |
| [ToBooleanArray(this ushort)](Jcd.BitManipulation.UInt16Extensions.ToBooleanArray(thisushort) 'Jcd.BitManipulation.UInt16Extensions.ToBooleanArray(this ushort)')                                                                                                                                                               | Converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into an array of  values with the lease significant bit at index 0.                                           |
| [ToByteArray(this ushort, Endian)](Jcd.BitManipulation.UInt16Extensions.ToByteArray(thisushort,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt16Extensions.ToByteArray(this ushort, Jcd.BitManipulation.Endian)')                                                                                                         | Converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.ToggleBit(thisushort,int) 'Jcd.BitManipulation.UInt16Extensions.ToggleBit(this ushort, int)')                                                                                                                                                                | Toggles a bit at the specified offset and returns the modified value.                                                                                                                                               |
| [ToggleBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,int,int) 'Jcd.BitManipulation.UInt16Extensions.ToggleBits(this ushort, int, int)')                                                                                                                                               | Toggles the specified range of bits and returns the modified value.                                                                                                                                                 |
| [ToggleBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt16Extensions.ToggleBits(this ushort, Jcd.BitManipulation.BitMask)')                                                                                                         | Toggle all the bits specified in the provided bit mask and returns the modified value.                                                                                                                              |
