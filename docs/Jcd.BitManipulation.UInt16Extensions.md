### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## UInt16Extensions Class

Provides methods to perform easy to read bit and byte manipulations on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

```csharp
public static class UInt16Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt16Extensions

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.AreAllBitsSet(thisushort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.AreAllBitsSet(this ushort, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |
| [AreAnyBitsSet(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.AreAnyBitsSet(thisushort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.AreAnyBitsSet(this ushort, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |
| [AreNoBitsSet(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.AreNoBitsSet(thisushort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.AreNoBitsSet(this ushort, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |
| [ClearBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.ClearBit(thisushort,int).md 'Jcd.BitManipulation.UInt16Extensions.ClearBit(this ushort, int)') | Sets bit to "off" and returns the modified value. |
| [ClearBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.ClearBits(thisushort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.ClearBits(this ushort, Jcd.BitManipulation.BitMask)') | Sets all bits from a provided mask to "off" and returns the modified value. |
| [ReadBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.ReadBit(thisushort,int).md 'Jcd.BitManipulation.UInt16Extensions.ReadBit(this ushort, int)') | Read a single bit from the specified offset. |
| [ReadBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).md 'Jcd.BitManipulation.UInt16Extensions.ReadBits(this ushort, int, int)') | For a given value return the specified bits from within it, right shifted pos bits. |
| [ReadBits(this ushort, int, BitMask)](Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.ReadBits(this ushort, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadByte(this ushort, int, Endian)](Jcd.BitManipulation.UInt16Extensions.ReadByte(thisushort,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.UInt16Extensions.ReadByte(this ushort, int, Jcd.BitManipulation.Endian)') | Read a single byte from the value at the specified byte offset. |
| [ReadBytes(this ushort, int, int, Endian)](Jcd.BitManipulation.UInt16Extensions.ReadBytes(thisushort,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.UInt16Extensions.ReadBytes(this ushort, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified byte location within the value. |
| [SetBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.SetBit(thisushort,int).md 'Jcd.BitManipulation.UInt16Extensions.SetBit(this ushort, int)') | Sets specified bit to "on" |
| [SetBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.SetBits(thisushort,int,int).md 'Jcd.BitManipulation.UInt16Extensions.SetBits(this ushort, int, int)') | Sets all specified bits to "on" |
| [SetBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.SetBits(thisushort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.SetBits(this ushort, Jcd.BitManipulation.BitMask)') | Sets all specified bits to "on" |
| [StoreBit(this ushort, bool, int)](Jcd.BitManipulation.UInt16Extensions.StoreBit(thisushort,bool,int).md 'Jcd.BitManipulation.UInt16Extensions.StoreBit(this ushort, bool, int)') | Store a single bit at the specified offset. |
| [StoreBits(this ushort, ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,int).md 'Jcd.BitManipulation.UInt16Extensions.StoreBits(this ushort, ushort, int, int)') | Stores a value at the specified bit location within the variable. |
| [StoreBits(this ushort, ushort, int, BitMask)](Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.StoreBits(this ushort, ushort, int, Jcd.BitManipulation.BitMask)') | Store a masked set of bits from a value to an offset in the destination The mask must apply to the destination bits. |
| [ToBooleanArray(this ushort)](Jcd.BitManipulation.UInt16Extensions.ToBooleanArray(thisushort).md 'Jcd.BitManipulation.UInt16Extensions.ToBooleanArray(this ushort)') | Convert a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into an array of bools |
| [ToByteArray(this ushort, Endian)](Jcd.BitManipulation.UInt16Extensions.ToByteArray(thisushort,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.UInt16Extensions.ToByteArray(this ushort, Jcd.BitManipulation.Endian)') | Convert a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into an array of bytes |
| [ToggleBit(this ushort, int)](Jcd.BitManipulation.UInt16Extensions.ToggleBit(thisushort,int).md 'Jcd.BitManipulation.UInt16Extensions.ToggleBit(this ushort, int)') | Toggles a bit. |
| [ToggleBits(this ushort, int, int)](Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,int,int).md 'Jcd.BitManipulation.UInt16Extensions.ToggleBits(this ushort, int, int)') | Toggles bits and size. The default values result in toggling all bits. |
| [ToggleBits(this ushort, BitMask)](Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.UInt16Extensions.ToggleBits(this ushort, Jcd.BitManipulation.BitMask)') | Toggle all the bits according to the provided mask |