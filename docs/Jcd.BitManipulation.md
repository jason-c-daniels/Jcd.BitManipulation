#### [Jcd.BitManipulation](index.md 'index')

## Jcd.BitManipulation Namespace

Provides a set of extension methods and types to assist with
making bit manipulation code easier to read.

### Example

```csharp
ushort data = 0b0000000000000000;
// turn on all the bits
data=data.SetBits(0, 16); // value is now 0b1111111111111111

// this is the equivalent as above
data=data.SetBits();

// Clear the middle 4 bits.
data=data.ClearBits(4, 8); // value is now 0b1111000000001111

// Toggle all the bits.
data=data.ToggleBits(); // value is now 0b0000111111110000

// read the upper byte
var upperByte = (byte)data.ReadBits(8, 8); // upperByte is now 0b00001111

// write 0b1011 into the upper nybble
upperByte=upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

// chaining operations, the same steps and end results
data = 0;
data = data.SetBits(0, 16) // value is now 0b1111111111111111
    .SetBits() // this is the equivalent as above
    .ClearBits(4, 8) // value is now 0b1111000000001111
    .ToggleBits(); // value is now 0b0000111111110000

upperByte = ((byte)data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
    .StoreBits(0b1011, 4, 4);// store the value in the upper 4 bits, now upperByte is now 0b10111111
```

| Classes                                                                                                                 |                                                                                                                                                                                          |
|:------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSetExtensions](Jcd.BitManipulation.AreAllBitsSetExtensions.md 'Jcd.BitManipulation.AreAllBitsSetExtensions') | Provides the ability to check if all bits from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') are set on integral integer types.                              |
| [AreAnyBitsSetExtensions](Jcd.BitManipulation.AreAnyBitsSetExtensions.md 'Jcd.BitManipulation.AreAnyBitsSetExtensions') | Provides the ability to check if any bits from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') are set on integral integer types.                              |
| [AreNoBitsSetExtensions](Jcd.BitManipulation.AreNoBitsSetExtensions.md 'Jcd.BitManipulation.AreNoBitsSetExtensions')    | Provides the ability to check if no bits from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') are set on integral integer types.                               |
| [BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')    | A bunch of extension methods to help with converting numbers to and from arrays of bools                                                                                                 |
| [ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')             | A bunch of extension methods to help with converting numbers to and from arrays of bools                                                                                                 |
| [ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')             | Extension methods to aid in clearing bits in various integer data types.                                                                                                                 |
| [FloatingPointExtensions](Jcd.BitManipulation.FloatingPointExtensions.md 'Jcd.BitManipulation.FloatingPointExtensions') | Methods to convert to and from like sized integers and floating point numbers.                                                                                                           |
| [ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')                | Extension methods that enable reading one or more bits from a specified offset in an integer data type.                                                                                  |
| [ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')             | Extension methods that aid in storing values into byte offsets within another integer data type. The offsets are Least Significant Byte. Index 0 is the 8 least significant bits....etc. |
| [SetBitsExtensions](Jcd.BitManipulation.SetBitsExtensions.md 'Jcd.BitManipulation.SetBitsExtensions')                   | Extension methods that aid in turning bits on in an integer data type.                                                                                                                   |
| [StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')             | Extension methods that aid in storing values into bit offsets within an integer data type.                                                                                               |
| [StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')          | Extension methods that aid in storing values into byte offsets within another integer data type. Byte indexing is LSB, least significant byte, at index/offset zero.                     |
| [ToggleBitsExtensions](Jcd.BitManipulation.ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions')          | Extension methods to aid in toggling bits.                                                                                                                                               |

| Structs | |
| :--- | :--- |
| [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') | An conceptual abstraction for a bit mask. |

| Enums | |
| :--- | :--- |
| [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian') | A type indicating which endian is in use. |
