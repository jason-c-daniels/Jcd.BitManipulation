#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## Int64Extensions Class

Provides easy to read methods for bit manipulation operations on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

```csharp
public static class Int64Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int64Extensions

### Example

```csharp
long data = 0;

// turn on all the bits
data = data.SetBits(0, 64); // value is now
// 0b1111111111111111111111111111111111111111111111111111111111111111
// this is the equivalent as above
data = data.SetBits();

// Clear the middle 4 bits.
data = data.ClearBits(4, 8); // value is now 0b1111111111111111111111111111111111111111111111111111000000001111

// Toggle all the bits.
data = data.ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

var finalData = data;

// read the second byte
var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

// write 0b1011 into the upper nybble
secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

// chaining operations, the same steps and end results
data.ClearBits();
data = data.SetBits(0, 64) // value is now 0b1111111111111111111111111111111111111111111111111111111111111111
           .SetBits() // this is the equivalent as above
           .ClearBits(4, 8) // value is now 0b1111111111111111111111111111111111111111111111111111000000001111
           .ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
                         .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111

// finalData is 0b0000000000000000000000000000000000000000000000000000111111110000
var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big)
                           .StoreByte(0b01010101, 0, Endian.Little)
;
// mutatedData is now 0b1011111100000000000000000000000000000000000000000000111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00000000, 0b00000000,
                                                //       0b00000000, 0b00000000, 0b00001111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b00000000,
                                                   //       0b00000000, 0b00000000, 0b00000000, 0b10111111]

var leBaToInt64Le = leBa.ToInt64(Endian.Little); // leBaToInt64Le = 0b1011111100000000000000000000000000000000000000000000111101010101

var leBaToInt64Be = leBa.ToInt64(Endian.Big); // leBaToInt64Be = 0b0101010100001111000000000000000000000000000000000000000010111111
```

| Methods                                                                                                                                                                                                                                                                                                                    |                                                                                                                                                                                                                         |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSet(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.AreAllBitsSet(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.AreAllBitsSet(this long, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if all of the bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').                                                                         |
| [AreAnyBitsSet(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.AreAnyBitsSet(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.AreAnyBitsSet(this long, Jcd.BitManipulation.BitMask)')                                                                                                | Tests if any bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').                                                                                |
| [AreNoBitsSet(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.AreNoBitsSet(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.AreNoBitsSet(this long, Jcd.BitManipulation.BitMask)')                                                                                                   | Tests if none of the bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').                                                                        |
| [BitwiseToDouble(this long)](Jcd.BitManipulation.Int64Extensions.BitwiseToDouble(thislong) 'Jcd.BitManipulation.Int64Extensions.BitwiseToDouble(this long)')                                                                                                                                                            | Converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to the bit-wise identical [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') |
| [ClearBit(this long, int)](Jcd.BitManipulation.Int64Extensions.ClearBit(thislong,int) 'Jcd.BitManipulation.Int64Extensions.ClearBit(this long, int)')                                                                                                                                                                   | Sets the specified bit to "off" and returns the modified value.                                                                                                                                                         |
| [ClearBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,int,int) 'Jcd.BitManipulation.Int64Extensions.ClearBits(this long, int, int)')                                                                                                                                                  | Sets all specified bits to "off" and returns the modified value.                                                                                                                                                        |
| [ClearBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.ClearBits(this long, Jcd.BitManipulation.BitMask)')                                                                                                            | Sets all bits from the provided mask to "off" and returns the modified value.                                                                                                                                           |
| [ReadBit(this long, int)](Jcd.BitManipulation.Int64Extensions.ReadBit(thislong,int) 'Jcd.BitManipulation.Int64Extensions.ReadBit(this long, int)')                                                                                                                                                                      | Reads a single bit from the specified position.                                                                                                                                                                         |
| [ReadBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,int) 'Jcd.BitManipulation.Int64Extensions.ReadBits(this long, int, int)')                                                                                                                                                     | Reads the bits specified and returns the result shifted to the right by the offset.                                                                                                                                     |
| [ReadBits(this long, int, BitMask)](Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.ReadBits(this long, int, Jcd.BitManipulation.BitMask)')                                                                                                 | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                                                                                                 |
| [ReadBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.ReadBits(this long, Jcd.BitManipulation.BitMask)')                                                                                                               | Extract a subset of bits specified by a bitmask.                                                                                                                                                                        |
| [ReadByte(this long, int, Endian)](Jcd.BitManipulation.Int64Extensions.ReadByte(thislong,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int64Extensions.ReadByte(this long, int, Jcd.BitManipulation.Endian)')                                                                                                    | Reads a single byte from the value at the specified byte offset.                                                                                                                                                        |
| [ReadBytes(this long, int, int, Endian)](Jcd.BitManipulation.Int64Extensions.ReadBytes(thislong,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int64Extensions.ReadBytes(this long, int, int, Jcd.BitManipulation.Endian)')                                                                                   | Reads a set of bytes starting at the specified byte location within the value.                                                                                                                                          |
| [SetBit(this long, int)](Jcd.BitManipulation.Int64Extensions.SetBit(thislong,int) 'Jcd.BitManipulation.Int64Extensions.SetBit(this long, int)')                                                                                                                                                                         | Sets the bit at the specified to 1 and returns the modified value.                                                                                                                                                      |
| [SetBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.SetBits(thislong,int,int) 'Jcd.BitManipulation.Int64Extensions.SetBits(this long, int, int)')                                                                                                                                                        | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                            |
| [SetBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.SetBits(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.SetBits(this long, Jcd.BitManipulation.BitMask)')                                                                                                                  | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                            |
| [StoreBit(this long, bool, int)](Jcd.BitManipulation.Int64Extensions.StoreBit(thislong,bool,int) 'Jcd.BitManipulation.Int64Extensions.StoreBit(this long, bool, int)')                                                                                                                                                  | Store a single bit at the specified offset and returns the modified value.                                                                                                                                              |
| [StoreBits(this long, long, int, int)](Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,int) 'Jcd.BitManipulation.Int64Extensions.StoreBits(this long, long, int, int)')                                                                                                                                 | Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.                                                                |
| [StoreBits(this long, long, int, BitMask)](Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.StoreBits(this long, long, int, Jcd.BitManipulation.BitMask)')                                                                             | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value.                                     |
| [StoreByte(this long, byte, int, Endian)](Jcd.BitManipulation.Int64Extensions.StoreByte(thislong,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int64Extensions.StoreByte(this long, byte, int, Jcd.BitManipulation.Endian)')                                                                                | Stores a single byte to the value at the specified byte offset and returns the modified value.                                                                                                                          |
| [StoreBytes(this long, byte[], int, int, Endian)](Jcd.BitManipulation.Int64Extensions.StoreBytes(thislong,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int64Extensions.StoreBytes(this long, byte[], int, int, Jcd.BitManipulation.Endian)')                                                         | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                             |
| [StoreBytes(this long, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.Int64Extensions.StoreBytes(thislong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int64Extensions.StoreBytes(this long, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value.                                                                                                                             |
| [ToBooleanArray(this long)](Jcd.BitManipulation.Int64Extensions.ToBooleanArray(thislong) 'Jcd.BitManipulation.Int64Extensions.ToBooleanArray(this long)')                                                                                                                                                               | Converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into an array of  values with the lease significant bit at index 0.                                                  |
| [ToByteArray(this long, Endian)](Jcd.BitManipulation.Int64Extensions.ToByteArray(thislong,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.Int64Extensions.ToByteArray(this long, Jcd.BitManipulation.Endian)')                                                                                                         | Converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian').        |
| [ToggleBit(this long, int)](Jcd.BitManipulation.Int64Extensions.ToggleBit(thislong,int) 'Jcd.BitManipulation.Int64Extensions.ToggleBit(this long, int)')                                                                                                                                                                | Toggles a bit at the specified offset and returns the modified value.                                                                                                                                                   |
| [ToggleBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,int,int) 'Jcd.BitManipulation.Int64Extensions.ToggleBits(this long, int, int)')                                                                                                                                               | Toggles the specified range of bits and returns the modified value.                                                                                                                                                     |
| [ToggleBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.Int64Extensions.ToggleBits(this long, Jcd.BitManipulation.BitMask)')                                                                                                         | Toggle all the bits specified in the provided bit mask and returns the modified value.                                                                                                                                  |
