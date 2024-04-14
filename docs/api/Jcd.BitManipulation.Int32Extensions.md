#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## Int32Extensions Class

Provides easy to read methods for bit manipulation operations on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

```csharp
public static class Int32Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int32Extensions

### Example

```csharp
int data = 0;

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

var leBaToInt32Le = leBa.ToInt32(Endian.Little); // leBaToInt32Le = 0b10111111000000000000111101010101

var leBaToInt32Be = leBa.ToInt32(Endian.Big); // leBaToInt32Be = 0b01010101000011110000000010111111
```

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.AreAllBitsSet(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.AreAllBitsSet(this int, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [AreAnyBitsSet(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.AreAnyBitsSet(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.AreAnyBitsSet(this int, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [AreNoBitsSet(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.AreNoBitsSet(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.AreNoBitsSet(this int, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [BitwiseToSingle(this int)](Jcd.BitManipulation.Int32Extensions.BitwiseToSingle(thisint) 'Jcd.BitManipulation.Int32Extensions.BitwiseToSingle(this int)') | Converts a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to the bit-wise identical [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') |
| [ClearBit(this int, int)](Jcd.BitManipulation.Int32Extensions.ClearBit(thisint,int) 'Jcd.BitManipulation.Int32Extensions.ClearBit(this int, int)') | Sets the specified bit to "off" and returns the modified value. |
| [ClearBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.ClearBits(thisint,int,int) 'Jcd.BitManipulation.Int32Extensions.ClearBits(this int, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.ClearBits(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.ClearBits(this int, Jcd.BitManipulation.BitMask)') | Sets all bits from the provided mask to "off" and returns the modified value. |
| [ReadBit(this int, int)](Jcd.BitManipulation.Int32Extensions.ReadBit(thisint,int) 'Jcd.BitManipulation.Int32Extensions.ReadBit(this int, int)') | Reads a single bit from the specified position. |
| [ReadBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int) 'Jcd.BitManipulation.Int32Extensions.ReadBits(this int, int, int)') | Reads the bits specified and returns the result shifted to the right by the offset. |
| [ReadBits(this int, int, BitMask)](Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.ReadBits(this int, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.ReadBits(this int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask. |
| [ReadByte(this int, int, Endian)](Jcd.BitManipulation.Int32Extensions.ReadByte(thisint,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int32Extensions.ReadByte(this int, int, Jcd.BitManipulation.Endian)') | Reads a single byte from the value at the specified byte offset. |
| [ReadBytes(this int, int, int, Endian)](Jcd.BitManipulation.Int32Extensions.ReadBytes(thisint,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int32Extensions.ReadBytes(this int, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified byte location within the value. |
| [SetBit(this int, int)](Jcd.BitManipulation.Int32Extensions.SetBit(thisint,int) 'Jcd.BitManipulation.Int32Extensions.SetBit(this int, int)') | Sets the bit at the specified to 1 and returns the modified value. |
| [SetBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.SetBits(thisint,int,int) 'Jcd.BitManipulation.Int32Extensions.SetBits(this int, int, int)') | Sets all specified bits to 1 and returns the modified value. |
| [SetBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.SetBits(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.SetBits(this int, Jcd.BitManipulation.BitMask)') | Sets all specified bits to 1 and returns the modified value. |
| [StoreBit(this int, bool, int)](Jcd.BitManipulation.Int32Extensions.StoreBit(thisint,bool,int) 'Jcd.BitManipulation.Int32Extensions.StoreBit(this int, bool, int)') | Store a single bit at the specified offset and returns the modified value. |
| [StoreBits(this int, int, int, int)](Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int) 'Jcd.BitManipulation.Int32Extensions.StoreBits(this int, int, int, int)') | Stores a range of bits to the value, from a source value, and returns the modified value. |
| [StoreBits(this int, int, int, BitMask)](Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.StoreBits(this int, int, int, Jcd.BitManipulation.BitMask)') | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value. |
| [StoreByte(this int, byte, int, Endian)](Jcd.BitManipulation.Int32Extensions.StoreByte(thisint,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int32Extensions.StoreByte(this int, byte, int, Jcd.BitManipulation.Endian)') | Stores a single byte to the value at the specified byte offset and returns the modified value. |
| [StoreBytes(this int, byte[], int, int, Endian)](Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int32Extensions.StoreBytes(this int, byte[], int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value. |
| [StoreBytes(this int, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int32Extensions.StoreBytes(this int, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value. |
| [ToBooleanArray(this int)](Jcd.BitManipulation.Int32Extensions.ToBooleanArray(thisint) 'Jcd.BitManipulation.Int32Extensions.ToBooleanArray(this int)') | Converts a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') into an array of  values with the lease significant bit at index 0. |
| [ToByteArray(this int, Endian)](Jcd.BitManipulation.Int32Extensions.ToByteArray(thisint,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int32Extensions.ToByteArray(this int, Jcd.BitManipulation.Endian)') | Converts a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this int, int)](Jcd.BitManipulation.Int32Extensions.ToggleBit(thisint,int) 'Jcd.BitManipulation.Int32Extensions.ToggleBit(this int, int)') | Toggles a bit at the specified offset and returns the modified value. |
| [ToggleBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.ToggleBits(thisint,int,int) 'Jcd.BitManipulation.Int32Extensions.ToggleBits(this int, int, int)') | Toggles the specified range of bits and returns the modified value. |
| [ToggleBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.ToggleBits(thisint,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int32Extensions.ToggleBits(this int, Jcd.BitManipulation.BitMask)') | Toggle all the bits specified in the provided bit mask and returns the modified value. |
