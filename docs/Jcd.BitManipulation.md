#### [Jcd.BitManipulation](index.md 'index')

## Jcd.BitManipulation Namespace

Provides a set of extension methods and types to assist with
making bit manipulation code easier to read.

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
data = data.SetBits(0, 16)  // value is now 0b1111111111111111
///      .SetBits()///  // this is the equivalent as above
///      .ClearBits(4, 8) // value is now 0b1111000000001111
///      .ToggleBits();   // value is now 0b0000111111110000

upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
  .StoreBits(0b1011, 4, 4);/// ///   // store the value in the upper 4 bits, now upperByte is now 0b10111111

// finalData 0b0000111111110000
var beByte0     = finalData.ReadByte(0, Endian.Big);/// ///   // 00001111
var leByte0     = finalData.ReadByte(0, Endian.Little);///      // 11110000

var mutatedData = finalData
/// ///      .StoreByte(0b10111111, 0, Endian.Big)
/// ///      .StoreByte(0b01010101, 0, Endian.Little ); // lower byte is now 0b01010101
;/// /// /// /// /// /// /// /// /// ///     // mutatedData is now 0b1011111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

var leBaToUInt16Le = leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101

var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le = 0b0101010110111111
```

| Classes | |
| :--- | :--- |
| [AreAllBitsSetExtensions](Jcd.BitManipulation.AreAllBitsSetExtensions.md 'Jcd.BitManipulation.AreAllBitsSetExtensions') | Provides the ability to check if all bits from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') are set on integral integer types. |
| [AreAnyBitsSetExtensions](Jcd.BitManipulation.AreAnyBitsSetExtensions.md 'Jcd.BitManipulation.AreAnyBitsSetExtensions') | Provides the ability to check if any bits from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') are set on integral integer types. |
| [AreNoBitsSetExtensions](Jcd.BitManipulation.AreNoBitsSetExtensions.md 'Jcd.BitManipulation.AreNoBitsSetExtensions') | Provides the ability to check if no bits from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') are set on integral integer types. |
| [BitwiseConversionExtensions](Jcd.BitManipulation.BitwiseConversionExtensions.md 'Jcd.BitManipulation.BitwiseConversionExtensions') | Methods to convert bits to and from the same size integer and floating point numbers. |
| [BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions') | Extension methods to aid in converting numbers to and from arrays of bools |
| [ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions') | Extension methods to aid in converting numbers to and from arrays of bools |
| [ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions') | Extension methods to aid in clearing bits in various integer data types. |
| [ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions') | Extension methods that enable reading one or more bits from a specified offset in an integer data type. |
| [ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions') | Extension methods that aid in reading bytes from integer data types. |
| [SetBitsExtensions](Jcd.BitManipulation.SetBitsExtensions.md 'Jcd.BitManipulation.SetBitsExtensions') | Extension methods that aid in turning bits on in an integer data type. |
| [StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions') | Extension methods that aid in storing values into bit offsets within an integer data type. |
| [StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions') | Extension methods that aid in storing values into byte offsets within another integer data type. |
| [ToggleBitsExtensions](Jcd.BitManipulation.ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions') | Extension methods to aid in toggling bits. |

| Structs | |
| :--- | :--- |
| [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') | An conceptual abstraction for a bit mask. |

| Enums | |
| :--- | :--- |
| [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian') | A type indicating which endian is in use. |
