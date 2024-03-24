### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## Int16Extensions Class

Provides methods to perform easy to read bit and byte manipulations on an [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

```csharp
public static class Int16Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int16Extensions

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.AreAllBitsSet(thisshort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.AreAllBitsSet(this short, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |
| [AreAnyBitsSet(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(thisshort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(this short, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |
| [AreNoBitsSet(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.AreNoBitsSet(thisshort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.AreNoBitsSet(this short, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |
| [ClearBit(this short, int)](Jcd.BitManipulation.Int16Extensions.ClearBit(thisshort,int).md 'Jcd.BitManipulation.Int16Extensions.ClearBit(this short, int)') | Sets bit to "off" and returns the modified value. |
| [ClearBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.ClearBits(thisshort,int,int).md 'Jcd.BitManipulation.Int16Extensions.ClearBits(this short, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.ClearBits(thisshort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.ClearBits(this short, Jcd.BitManipulation.BitMask)') | Sets all bits from a provided mask to "off" and returns the modified value. |
| [ReadBit(this short, int)](Jcd.BitManipulation.Int16Extensions.ReadBit(thisshort,int).md 'Jcd.BitManipulation.Int16Extensions.ReadBit(this short, int)') | Read a single bit from the specified offset. |
| [ReadBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,int).md 'Jcd.BitManipulation.Int16Extensions.ReadBits(this short, int, int)') | For a given value return the specified bits from within it, right shifted pos bits. |
| [ReadBits(this short, int, BitMask)](Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.ReadBits(this short, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadByte(this short, int, Endian)](Jcd.BitManipulation.Int16Extensions.ReadByte(thisshort,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int16Extensions.ReadByte(this short, int, Jcd.BitManipulation.Endian)') | Read a single byte from the value at the specified byte offset. |
| [ReadBytes(this short, int, int, Endian)](Jcd.BitManipulation.Int16Extensions.ReadBytes(thisshort,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int16Extensions.ReadBytes(this short, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified offset within the value. |
| [SetBit(this short, int)](Jcd.BitManipulation.Int16Extensions.SetBit(thisshort,int).md 'Jcd.BitManipulation.Int16Extensions.SetBit(this short, int)') | Sets specified bit to "on" |
| [SetBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.SetBits(thisshort,int,int).md 'Jcd.BitManipulation.Int16Extensions.SetBits(this short, int, int)') | Sets all specified bits to "on" |
| [SetBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.SetBits(thisshort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.SetBits(this short, Jcd.BitManipulation.BitMask)') | Sets all specified bits to "on" |
| [StoreBit(this short, bool, int)](Jcd.BitManipulation.Int16Extensions.StoreBit(thisshort,bool,int).md 'Jcd.BitManipulation.Int16Extensions.StoreBit(this short, bool, int)') | Store a single bit at the specified offset. |
| [StoreBits(this short, short, int, int)](Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,int).md 'Jcd.BitManipulation.Int16Extensions.StoreBits(this short, short, int, int)') | Stores a value at the specified bit location within the variable. |
| [StoreBits(this short, short, int, BitMask)](Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.StoreBits(this short, short, int, Jcd.BitManipulation.BitMask)') | Store a masked set of bits from a value to an offset in the destination The mask must apply to the destination bits. |
| [StoreByte(this short, byte, int, Endian)](Jcd.BitManipulation.Int16Extensions.StoreByte(thisshort,byte,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int16Extensions.StoreByte(this short, byte, int, Jcd.BitManipulation.Endian)') | Store a single byte to the value at the specified byte offset. |
| [StoreBytes(this short, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int16Extensions.StoreBytes(this short, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte location within the value. |
| [ToBooleanArray(this short)](Jcd.BitManipulation.Int16Extensions.ToBooleanArray(thisshort).md 'Jcd.BitManipulation.Int16Extensions.ToBooleanArray(this short)') | Convert a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') into an array of bools |
| [ToByteArray(this short, Endian)](Jcd.BitManipulation.Int16Extensions.ToByteArray(thisshort,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int16Extensions.ToByteArray(this short, Jcd.BitManipulation.Endian)') | Convert a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') into an array of bytes |
| [ToggleBit(this short, int)](Jcd.BitManipulation.Int16Extensions.ToggleBit(thisshort,int).md 'Jcd.BitManipulation.Int16Extensions.ToggleBit(this short, int)') | Toggles a bit. |
| [ToggleBits(this short, int, int)](Jcd.BitManipulation.Int16Extensions.ToggleBits(thisshort,int,int).md 'Jcd.BitManipulation.Int16Extensions.ToggleBits(this short, int, int)') | Toggles bits and size. The default values result in toggling all bits. |
| [ToggleBits(this short, BitMask)](Jcd.BitManipulation.Int16Extensions.ToggleBits(thisshort,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int16Extensions.ToggleBits(this short, Jcd.BitManipulation.BitMask)') | Toggle all the bits according to the provided mask |