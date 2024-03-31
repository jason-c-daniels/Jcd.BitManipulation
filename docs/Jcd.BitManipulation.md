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
| [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer') | Provides byte level indexing operations (set, get) on the bytes of a copied value. It provides indexer-style access to the bytes of the value. Index zero is the most significant byte. |
| [BigEndianByteIndexerInt16](Jcd.BitManipulation.BigEndianByteIndexerInt16.md 'Jcd.BitManipulation.BigEndianByteIndexerInt16') | Provides byte level indexing operations (set, get) on an [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). Zero is the most significant byte. |
| [BigEndianByteIndexerInt32](Jcd.BitManipulation.BigEndianByteIndexerInt32.md 'Jcd.BitManipulation.BigEndianByteIndexerInt32') | Provides byte level indexing operations (set, get) on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). Zero is the most significant byte. |
| [BigEndianByteIndexerInt64](Jcd.BitManipulation.BigEndianByteIndexerInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64') | Provides byte level indexing operations (set, get) on an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). Zero is the most significant byte. |
| [BigEndianByteIndexerUInt16](Jcd.BitManipulation.BigEndianByteIndexerUInt16.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16') | Provides byte level indexing operations (set, get) on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). Zero is the most significant byte. |
| [BigEndianByteIndexerUInt32](Jcd.BitManipulation.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt32') | Provides byte level indexing operations (set, get) on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). Zero is the most significant byte. |
| [BigEndianByteIndexerUInt64](Jcd.BitManipulation.BigEndianByteIndexerUInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64') | Provides byte level indexing operations (set, get) on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). Zero is the most significant byte. |
| [BitIndexerByte](Jcd.BitManipulation.BitIndexerByte.md 'Jcd.BitManipulation.BitIndexerByte') | Provides enumeration and indexed access to the bits on a stored [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [BitIndexerInt16](Jcd.BitManipulation.BitIndexerInt16.md 'Jcd.BitManipulation.BitIndexerInt16') | Provides enumeration and indexed access to the bits on a stored [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |
| [BitIndexerInt32](Jcd.BitManipulation.BitIndexerInt32.md 'Jcd.BitManipulation.BitIndexerInt32') | Provides enumeration and indexed access to the bits on a stored [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [BitIndexerInt64](Jcd.BitManipulation.BitIndexerInt64.md 'Jcd.BitManipulation.BitIndexerInt64') | Provides enumeration and indexed access to the bits on a stored [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |
| [BitIndexerSByte](Jcd.BitManipulation.BitIndexerSByte.md 'Jcd.BitManipulation.BitIndexerSByte') | Provides enumeration and indexed access to the bits on a stored [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'). |
| [BitIndexerUInt16](Jcd.BitManipulation.BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexerUInt16') | Provides enumeration and indexed access to the bits on a stored [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |
| [BitIndexerUInt32](Jcd.BitManipulation.BitIndexerUInt32.md 'Jcd.BitManipulation.BitIndexerUInt32') | Provides enumeration and indexed access to the bits on a stored [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). |
| [BitIndexerUInt64](Jcd.BitManipulation.BitIndexerUInt64.md 'Jcd.BitManipulation.BitIndexerUInt64') | Provides enumeration and indexed access to the bits on a stored [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') | An conceptual abstraction for a bit mask. |
| [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') | Provides byte level indexing operations (set, get) on the bytes of a copied value. It provides indexer-style access to the bytes of the value. Index zero is the least significant byte. |
| [LittleEndianByteIndexerInt16](Jcd.BitManipulation.LittleEndianByteIndexerInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16') | Provides byte level indexing operations (set, get) on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). Zero is the least significant byte. |
| [LittleEndianByteIndexerInt32](Jcd.BitManipulation.LittleEndianByteIndexerInt32.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt32') | Provides byte level indexing operations (set, get) on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). Zero is the least significant byte. |
| [LittleEndianByteIndexerInt64](Jcd.BitManipulation.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt64') | Provides byte level indexing operations (set, get) on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). Zero is the least significant byte. |
| [LittleEndianByteIndexerUInt16](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16') | Provides byte level indexing operations (set, get) on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). Zero is the least significant byte. |
| [LittleEndianByteIndexerUInt32](Jcd.BitManipulation.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt32') | Provides byte level indexing operations (set, get) on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). Zero is the least significant byte. |
| [LittleEndianByteIndexerUInt64](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64') | Provides byte level indexing operations (set, get) on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). Zero is the least significant byte. |

| Interfaces | |
| :--- | :--- |
| [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer') | The basic interface for indexing bits within an integer data type. |
| [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer') | The basic interface for indexing bytes within an integral data type. |

| Enums | |
| :--- | :--- |
| [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian') | A type indicating which endian is in use. |
