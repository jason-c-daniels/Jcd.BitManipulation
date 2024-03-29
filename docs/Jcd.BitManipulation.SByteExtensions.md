### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## SByteExtensions Class

Provides methods to perform easy to read bit manipulations on an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

```csharp
public static class SByteExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SByteExtensions

| Methods                                                                                                                                                                                                                                              |                                                                                                                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------|
| [AreAllBitsSet(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.AreAllBitsSet(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.AreAllBitsSet(this sbyte, Jcd.BitManipulation.BitMask)')                       | Tests if all of the bits from the bitmask are set on an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').  |
| [AreAnyBitsSet(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.AreAnyBitsSet(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.AreAnyBitsSet(this sbyte, Jcd.BitManipulation.BitMask)')                       | Tests if any bits from the bitmask are set on an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').         |
| [AreNoBitsSet(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.AreNoBitsSet(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.AreNoBitsSet(this sbyte, Jcd.BitManipulation.BitMask)')                          | Tests if none of the bits from the bitmask are set on an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'). |
| [ClearBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.ClearBit(thissbyte,int).md 'Jcd.BitManipulation.SByteExtensions.ClearBit(this sbyte, int)')                                                                                          | Sets bit to "off" and returns the modified value.                                                                                                 |
| [ClearBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.ClearBits(thissbyte,int,int).md 'Jcd.BitManipulation.SByteExtensions.ClearBits(this sbyte, int, int)')                                                                         | Sets all specified bits to "off" and returns the modified value.                                                                                  |
| [ClearBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.ClearBits(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.ClearBits(this sbyte, Jcd.BitManipulation.BitMask)')                                   | Sets all bits from a provided mask to "off" and returns the modified value.                                                                       |
| [ReadBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.ReadBit(thissbyte,int).md 'Jcd.BitManipulation.SByteExtensions.ReadBit(this sbyte, int)')                                                                                             | Read a single bit from the specified offset.                                                                                                      |
| [ReadBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,int).md 'Jcd.BitManipulation.SByteExtensions.ReadBits(this sbyte, int, int)')                                                                            | For a given value return the specified bits from within it, right shifted pos bits.                                                               |
| [ReadBits(this sbyte, int, BitMask)](Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.ReadBits(this sbyte, int, Jcd.BitManipulation.BitMask)')                        | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                           |
| [ReadBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.ReadBits(this sbyte, Jcd.BitManipulation.BitMask)')                                      | Extract a subset of bits specified by a bitmask and right align the bits by the offset.                                                           |
| [SetBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.SetBit(thissbyte,int).md 'Jcd.BitManipulation.SByteExtensions.SetBit(this sbyte, int)')                                                                                                | Sets specified bit to "on"                                                                                                                        |
| [SetBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,int,int).md 'Jcd.BitManipulation.SByteExtensions.SetBits(this sbyte, int, int)')                                                                               | Sets all specified bits to "on"                                                                                                                   |
| [SetBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.SetBits(this sbyte, Jcd.BitManipulation.BitMask)')                                         | Sets all specified bits to "on"                                                                                                                   |
| [StoreBit(this sbyte, bool, int)](Jcd.BitManipulation.SByteExtensions.StoreBit(thissbyte,bool,int).md 'Jcd.BitManipulation.SByteExtensions.StoreBit(this sbyte, bool, int)')                                                                         | Store a single bit at the specified offset.                                                                                                       |
| [StoreBits(this sbyte, sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,int).md 'Jcd.BitManipulation.SByteExtensions.StoreBits(this sbyte, sbyte, int, int)')                                                     | Stores a value at the specified bit location within the variable.                                                                                 |
| [StoreBits(this sbyte, sbyte, int, BitMask)](Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.StoreBits(this sbyte, sbyte, int, Jcd.BitManipulation.BitMask)') | Store a masked set of bits from a value to an offset in the destination The mask must apply to the destination bits.                          |
| [ToBooleanArray(this sbyte)](Jcd.BitManipulation.SByteExtensions.ToBooleanArray(thissbyte).md 'Jcd.BitManipulation.SByteExtensions.ToBooleanArray(this sbyte)')                                                                                      | Convert an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into an array of bools                         |
| [ToByteArray(this sbyte)](Jcd.BitManipulation.SByteExtensions.ToByteArray(thissbyte).md 'Jcd.BitManipulation.SByteExtensions.ToByteArray(this sbyte)')                                                                                               | Convert an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into an array of bytes                         |
| [ToggleBit(this sbyte, int)](Jcd.BitManipulation.SByteExtensions.ToggleBit(thissbyte,int).md 'Jcd.BitManipulation.SByteExtensions.ToggleBit(this sbyte, int)')                                                                                       | Toggles a bit.                                                                                                                                    |
| [ToggleBits(this sbyte, int, int)](Jcd.BitManipulation.SByteExtensions.ToggleBits(thissbyte,int,int).md 'Jcd.BitManipulation.SByteExtensions.ToggleBits(this sbyte, int, int)')                                                                      | Toggles bits and size. The default values result in toggling all bits.                                                                        |
| [ToggleBits(this sbyte, BitMask)](Jcd.BitManipulation.SByteExtensions.ToggleBits(thissbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.SByteExtensions.ToggleBits(this sbyte, Jcd.BitManipulation.BitMask)')                                | Toggle all the bits according to the provided mask                                                                                                |
