#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## Int16Extensions Class

Provides easy to read methods for bit manipulation operations on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

```csharp
public static class Int16Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int16Extensions

### Example

```csharp
short data = 0b0000000000000000;

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

var leBaToInt16Le = (BitMask) leBa.ToInt16(Endian.Little); // leBaToInt16Le = 0b1011111101010101

var leBaToInt16Be = (BitMask) leBa.ToInt16(Endian.Big); // leBaToInt16Le = 0b0101010110111111
```

| Methods                                                                                                                                                                                                                                                                                                                       |                                                                                                                                                                                                                  |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSet(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.AreAllBitsSet(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.AreAllBitsSet(this short, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if all of the bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').                                                                  |
| [AreAnyBitsSet(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(this short, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if any bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').                                                                         |
| [AreNoBitsSet(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.AreNoBitsSet(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.AreNoBitsSet(this short, Jcd.BitManipulation.BitMask)')                                                                                                   | Tests if none of the bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').                                                                 |
| [ClearBit(this short, int)](Jcd.BitManipulation.Int16Extensions.ClearBit(thisshort,int) 'Jcd.BitManipulation.Int16Extensions.ClearBit(this short, int)')                                                                                                                                                                   | Sets the specified bit to "off" and returns the modified value.                                                                                                                                                  |
| [ClearBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.ClearBits(thisshort,int,int) 'Jcd.BitManipulation.Int16Extensions.ClearBits(this short, int, int)')                                                                                                                                                  | Sets all specified bits to "off" and returns the modified value.                                                                                                                                                 |
| [ClearBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.ClearBits(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.ClearBits(this short, Jcd.BitManipulation.BitMask)')                                                                                                            | Sets all bits from the provided mask to "off" and returns the modified value.                                                                                                                                    |
| [ReadBit(this short, int)](Jcd.BitManipulation.Int16Extensions.ReadBit(thisshort,int) 'Jcd.BitManipulation.Int16Extensions.ReadBit(this short, int)')                                                                                                                                                                      | Reads a single bit from the specified position.                                                                                                                                                                  |
| [ReadBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,int) 'Jcd.BitManipulation.Int16Extensions.ReadBits(this short, int, int)')                                                                                                                                                     | Reads the bits specified and returns the result shifted to the right by the offset.                                                                                                                              |
| [ReadBits(this short, int, BitMask)](Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.ReadBits(this short, int, Jcd.BitManipulation.BitMask)')                                                                                                 | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                                                                                          |
| [ReadBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.ReadBits(this short, Jcd.BitManipulation.BitMask)')                                                                                                               | Extract a subset of bits specified by a bitmask.                                                                                                                                                                 |
| [ReadByte(this short, int, Endian)](Jcd.BitManipulation.Int16Extensions.ReadByte(thisshort,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int16Extensions.ReadByte(this short, int, Jcd.BitManipulation.Endian)')                                                                                                    | Reads a single byte from the value at the specified byte offset.                                                                                                                                                 |
| [ReadBytes(this short, int, int, Endian)](Jcd.BitManipulation.Int16Extensions.ReadBytes(thisshort,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int16Extensions.ReadBytes(this short, int, int, Jcd.BitManipulation.Endian)')                                                                                   | Reads a set of bytes starting at the specified offset within the value.                                                                                                                                          |
| [SetBit(this short, int)](Jcd.BitManipulation.Int16Extensions.SetBit(thisshort,int) 'Jcd.BitManipulation.Int16Extensions.SetBit(this short, int)')                                                                                                                                                                         | Sets the bit at the specified to 1 and returns the modified value.                                                                                                                                               |
| [SetBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.SetBits(thisshort,int,int) 'Jcd.BitManipulation.Int16Extensions.SetBits(this short, int, int)')                                                                                                                                                        | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                     |
| [SetBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.SetBits(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.SetBits(this short, Jcd.BitManipulation.BitMask)')                                                                                                                  | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                     |
| [StoreBit(this short, bool, int)](Jcd.BitManipulation.Int16Extensions.StoreBit(thisshort,bool,int) 'Jcd.BitManipulation.Int16Extensions.StoreBit(this short, bool, int)')                                                                                                                                                  | Store a single bit at the specified offset and returns the modified value.                                                                                                                                       |
| [StoreBits(this short, short, int, int)](Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,int) 'Jcd.BitManipulation.Int16Extensions.StoreBits(this short, short, int, int)')                                                                                                                              | Stores a range of bits to the value, from a source value, and returns the modified value.                                                                                                                        |
| [StoreBits(this short, short, int, BitMask)](Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.StoreBits(this short, short, int, Jcd.BitManipulation.BitMask)')                                                                          | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value.                                  |
| [StoreByte(this short, byte, int, Endian)](Jcd.BitManipulation.Int16Extensions.StoreByte(thisshort,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int16Extensions.StoreByte(this short, byte, int, Jcd.BitManipulation.Endian)')                                                                                | Stores a single byte to the value at the specified byte offset and returns the modified value.                                                                                                                   |
| [StoreBytes(this short, byte[], int, int, Endian)](Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int16Extensions.StoreBytes(this short, byte[], int, int, Jcd.BitManipulation.Endian)')                                                         | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                      |
| [StoreBytes(this short, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int16Extensions.StoreBytes(this short, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                      |
| [ToBooleanArray(this short)](Jcd.BitManipulation.Int16Extensions.ToBooleanArray(thisshort) 'Jcd.BitManipulation.Int16Extensions.ToBooleanArray(this short)')                                                                                                                                                               | Converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') into an array of  values with the lease significant bit at index 0.                                           |
| [ToByteArray(this short, Endian)](Jcd.BitManipulation.Int16Extensions.ToByteArray(thisshort,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int16Extensions.ToByteArray(this short, Jcd.BitManipulation.Endian)')                                                                                                         | Converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this short, int)](Jcd.BitManipulation.Int16Extensions.ToggleBit(thisshort,int) 'Jcd.BitManipulation.Int16Extensions.ToggleBit(this short, int)')                                                                                                                                                                | Toggles a bit at the specified offset and returns the modified value.                                                                                                                                            |
| [ToggleBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.ToggleBits(thisshort,int,int) 'Jcd.BitManipulation.Int16Extensions.ToggleBits(this short, int, int)')                                                                                                                                               | Toggles the specified range of bits and returns the modified value.                                                                                                                                              |
| [ToggleBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.ToggleBits(thisshort,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int16Extensions.ToggleBits(this short, Jcd.BitManipulation.BitMask)')                                                                                                         | Toggle all the bits specified in the provided bit mask and returns the modified value.                                                                                                                           |
