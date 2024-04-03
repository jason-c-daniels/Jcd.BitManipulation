#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## ByteExtensions Class

Provides easy to read methods for bit manipulation operations on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

```csharp
public static class ByteExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ByteExtensions

### Example

```csharp
byte data = 0b00000000;

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

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.AreAllBitsSet(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.AreAllBitsSet(this byte, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [AreAnyBitsSet(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.AreAnyBitsSet(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.AreAnyBitsSet(this byte, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [AreNoBitsSet(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.AreNoBitsSet(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.AreNoBitsSet(this byte, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [ClearBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.ClearBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.ClearBit(this byte, int)') | Sets the specified bit to "off" and returns the modified value. |
| [ClearBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.ClearBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.ClearBits(this byte, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.ClearBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ClearBits(this byte, Jcd.BitManipulation.BitMask)') | Sets all bits from the provided mask to "off" and returns the modified value. |
| [ReadBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.ReadBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.ReadBit(this byte, int)') | Reads a single bit from the specified position. |
| [ReadBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.ReadBits(this byte, int, int)') | Reads the bits specified and returns the result shifted to the right by the offset. |
| [ReadBits(this byte, int, BitMask)](Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ReadBits(this byte, int, Jcd.BitManipulation.BitMask)') | Reads the bits specified by a mask and right shifts it . |
| [ReadBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ReadBits(this byte, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [SetBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.SetBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.SetBit(this byte, int)') | Sets the bit at the specified to "on" and returns the modified value. |
| [SetBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.SetBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.SetBits(this byte, int, int)') | Sets all specified bits to "on" and returns the modified value. |
| [SetBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.SetBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.SetBits(this byte, Jcd.BitManipulation.BitMask)') | Sets all specified bits to "on" and returns the modified value. |
| [StoreBit(this byte, bool, int)](Jcd.BitManipulation.ByteExtensions.StoreBit(thisbyte,bool,int).md 'Jcd.BitManipulation.ByteExtensions.StoreBit(this byte, bool, int)') | Store a single bit at the specified offset and returns the modified value. |
| [StoreBits(this byte, byte, int, int)](Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,int).md 'Jcd.BitManipulation.ByteExtensions.StoreBits(this byte, byte, int, int)') | Stores a range of bits to the value, from a source value, and returns the modified value. |
| [StoreBits(this byte, byte, int, BitMask)](Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.StoreBits(this byte, byte, int, Jcd.BitManipulation.BitMask)') | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value. |
| [ToBooleanArray(this byte)](Jcd.BitManipulation.ByteExtensions.ToBooleanArray(thisbyte).md 'Jcd.BitManipulation.ByteExtensions.ToBooleanArray(this byte)') | Converts a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') into an array of  values with the lease significant bit at index 0. |
| [ToByteArray(this byte)](Jcd.BitManipulation.ByteExtensions.ToByteArray(thisbyte).md 'Jcd.BitManipulation.ByteExtensions.ToByteArray(this byte)') | Converts a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.ToggleBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.ToggleBit(this byte, int)') | Toggles a bit at the specified offset and returns the modified value. |
| [ToggleBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.ToggleBits(this byte, int, int)') | Toggles the specified range of bits and returns the modified value. |
| [ToggleBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ToggleBits(this byte, Jcd.BitManipulation.BitMask)') | Toggle all the bits specified in the provided bit mask and returns the modified value. |
