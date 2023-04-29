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

| Classes | |
| :--- | :--- |
| [BitIndexerExtensions](Jcd.BitManipulation.BitIndexerExtensions.md 'Jcd.BitManipulation.BitIndexerExtensions') | Some helper methods for converting to and from a BitIndexer. |
| [BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions') | A bunch of extension methods to help with converting numbers to and from arrays of bools |
| [ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions') | Extension methods to aid in clearing bits in various integer data types. |
| [ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions') | Extension methods that enable reading one or more bits from a specified offset in an integer data type. |
| [SetBitsExtensions](Jcd.BitManipulation.SetBitsExtensions.md 'Jcd.BitManipulation.SetBitsExtensions') | Extension methods that aid in turning bits on in an integer data type. |
| [StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions') | Extension methods that aid in storing values into bit offsets within an integer data type. |
| [ToggleBitsExtensions](Jcd.BitManipulation.ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions') | Extension methods to aid in toggling bits. |

| Structs | |
| :--- | :--- |
| [BitIndexerByte](Jcd.BitManipulation.BitIndexerByte.md 'Jcd.BitManipulation.BitIndexerByte') | Provides enumeration and indexed access to the bits on a stored byte. |
| [BitIndexerInt16](Jcd.BitManipulation.BitIndexerInt16.md 'Jcd.BitManipulation.BitIndexerInt16') | Provides enumeration and indexed access to the bits on a stored short. |
| [BitIndexerInt32](Jcd.BitManipulation.BitIndexerInt32.md 'Jcd.BitManipulation.BitIndexerInt32') | Provides enumeration and indexed access to the bits on a stored int. |
| [BitIndexerInt64](Jcd.BitManipulation.BitIndexerInt64.md 'Jcd.BitManipulation.BitIndexerInt64') | Provides enumeration and indexed access to the bits on a stored long. |
| [BitIndexerSByte](Jcd.BitManipulation.BitIndexerSByte.md 'Jcd.BitManipulation.BitIndexerSByte') | Provides enumeration and indexed access to the bits on a stored sbyte. |
| [BitIndexerUInt16](Jcd.BitManipulation.BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexerUInt16') | Provides enumeration and indexed access to the bits on a stored ushort. |
| [BitIndexerUInt32](Jcd.BitManipulation.BitIndexerUInt32.md 'Jcd.BitManipulation.BitIndexerUInt32') | Provides enumeration and indexed access to the bits on a stored uint. |
| [BitIndexerUInt64](Jcd.BitManipulation.BitIndexerUInt64.md 'Jcd.BitManipulation.BitIndexerUInt64') | Provides enumeration and indexed access to the bits on a stored ulong. |
| [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') | An conceptual abstraction for a bit mask. |

| Interfaces | |
| :--- | :--- |
| [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer') | The basic interface for indexing bits within an integer data type. |
