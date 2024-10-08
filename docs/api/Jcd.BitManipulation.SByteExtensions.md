#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## SByteExtensions Class

Provides easy to read methods for bit manipulation operations on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

```csharp
public static class SByteExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SByteExtensions

### Example

```csharp
sbyte data = 0b00000000;

// turn on all the bits
data = data.SetBits(0, 8); // value is now 0b11111111

// this is the equivalent as above
data = data.SetBits();

// Clear the upper 4 bits.
data = data.ClearBits(4, 4); // value is now 0b00001111

// Toggle all the bits.
data = data.ToggleBits(); // value is now 0b11110000

// read the upper nybble as a byte
var upperNybble = data.ReadBits(4, 4); // upperNybble is now 0b00001111

// write 0b1011 into the upper nybble of data
data = data.StoreBits(0b1011, 4, 4); // data is now 0b10110000

// chaining operations, the same steps and end results
data.ClearBits();
data = data.SetBits(0, 8) // value is now 0b11111111
           .SetBits() // this is the equivalent as above
           .ClearBits(4, 4) // value is now 0b00001111
           .ToggleBits(); // value is now 0b11110000

upperNybble = data.ReadBits(4, 4) // extract the upper nybble (0b00001111)
                  .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
```

| Methods                                                                                                                                                                                                                                              |                                                                                                                                                                                                                  |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSet(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.AreAllBitsSet(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.AreAllBitsSet(this sbyte, Jcd.BitManipulation.BitMask)')                       | Tests if all of the bits from the bitmask are set on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').                                                                  |
| [AreAnyBitsSet(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.AreAnyBitsSet(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.AreAnyBitsSet(this sbyte, Jcd.BitManipulation.BitMask)')                       | Tests if any bits from the bitmask are set on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').                                                                         |
| [AreNoBitsSet(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.AreNoBitsSet(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.AreNoBitsSet(this sbyte, Jcd.BitManipulation.BitMask)')                          | Tests if none of the bits from the bitmask are set on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').                                                                 |
| [ClearBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.ClearBit(thissbyte,int) 'Jcd.BitManipulation.SByteExtensions.ClearBit(this sbyte, int)')                                                                                          | Sets the specified bit to "off" and returns the modified value.                                                                                                                                                  |
| [ClearBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.ClearBits(thissbyte,int,int) 'Jcd.BitManipulation.SByteExtensions.ClearBits(this sbyte, int, int)')                                                                         | Sets all specified bits to "off" and returns the modified value.                                                                                                                                                 |
| [ClearBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.ClearBits(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.ClearBits(this sbyte, Jcd.BitManipulation.BitMask)')                                   | Sets all bits from the provided mask to "off" and returns the modified value.                                                                                                                                    |
| [ReadBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.ReadBit(thissbyte,int) 'Jcd.BitManipulation.SByteExtensions.ReadBit(this sbyte, int)')                                                                                             | Reads a single bit from the specified position.                                                                                                                                                                  |
| [ReadBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,int) 'Jcd.BitManipulation.SByteExtensions.ReadBits(this sbyte, int, int)')                                                                            | Reads the bits specified and returns the result shifted to the right by the offset.                                                                                                                              |
| [ReadBits(this sbyte, int, BitMask)](Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.ReadBits(this sbyte, int, Jcd.BitManipulation.BitMask)')                        | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                                                                                          |
| [ReadBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.ReadBits(this sbyte, Jcd.BitManipulation.BitMask)')                                      | Extract a subset of bits specified by a bitmask.                                                                                                                                                                 |
| [SetBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.SetBit(thissbyte,int) 'Jcd.BitManipulation.SByteExtensions.SetBit(this sbyte, int)')                                                                                                | Sets the bit at the specified to 1 and returns the modified value.                                                                                                                                               |
| [SetBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,int,int) 'Jcd.BitManipulation.SByteExtensions.SetBits(this sbyte, int, int)')                                                                               | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                     |
| [SetBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.SetBits(this sbyte, Jcd.BitManipulation.BitMask)')                                         | Sets all specified bits to 1 and returns the modified value.                                                                                                                                                     |
| [StoreBit(this sbyte, bool, int)](Jcd.BitManipulation.SByteExtensions.StoreBit(thissbyte,bool,int) 'Jcd.BitManipulation.SByteExtensions.StoreBit(this sbyte, bool, int)')                                                                         | Store a single bit at the specified offset and returns the modified value.                                                                                                                                       |
| [StoreBits(this sbyte, sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,int) 'Jcd.BitManipulation.SByteExtensions.StoreBits(this sbyte, sbyte, int, int)')                                                     | Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.                                                         |
| [StoreBits(this sbyte, sbyte, int, BitMask)](Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.StoreBits(this sbyte, sbyte, int, Jcd.BitManipulation.BitMask)') | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value.                              |
| [ToBooleanArray(this sbyte)](Jcd.BitManipulation.SByteExtensions.ToBooleanArray(thissbyte) 'Jcd.BitManipulation.SByteExtensions.ToBooleanArray(this sbyte)')                                                                                      | Converts a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into an array of  values with the lease significant bit at index 0.                                           |
| [ToByteArray(this sbyte)](Jcd.BitManipulation.SByteExtensions.ToByteArray(thissbyte) 'Jcd.BitManipulation.SByteExtensions.ToByteArray(this sbyte)')                                                                                               | Converts a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.ToggleBit(thissbyte,int) 'Jcd.BitManipulation.SByteExtensions.ToggleBit(this sbyte, int)')                                                                                       | Toggles a bit at the specified offset and returns the modified value.                                                                                                                                            |
| [ToggleBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.ToggleBits(thissbyte,int,int) 'Jcd.BitManipulation.SByteExtensions.ToggleBits(this sbyte, int, int)')                                                                      | Toggles the specified range of bits and returns the modified value.                                                                                                                                              |
| [ToggleBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.ToggleBits(thissbyte,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.SByteExtensions.ToggleBits(this sbyte, Jcd.BitManipulation.BitMask)')                                | Toggle all the bits specified in the provided bit mask and returns the modified value.                                                                                                                           |
