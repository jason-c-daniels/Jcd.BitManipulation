### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## Int32Extensions Class

Provides methods to perform easy to read bit and byte manipulations on an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

```csharp
public static class Int32Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int32Extensions

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.AreAllBitsSet(thisint,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.AreAllBitsSet(this int, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [AreAnyBitsSet(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.AreAnyBitsSet(thisint,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.AreAnyBitsSet(this int, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [AreNoBitsSet(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.AreNoBitsSet(thisint,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.AreNoBitsSet(this int, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [BitwiseToSingle(this int)](Jcd.BitManipulation.Int32Extensions.BitwiseToSingle(thisint).md 'Jcd.BitManipulation.Int32Extensions.BitwiseToSingle(this int)') | Converts a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to the bit-wise identical [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') |
| [ClearBit(this int, int)](Jcd.BitManipulation.Int32Extensions.ClearBit(thisint,int).md 'Jcd.BitManipulation.Int32Extensions.ClearBit(this int, int)') | Sets bit to "off" and returns the modified value. |
| [ClearBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.ClearBits(thisint,int,int).md 'Jcd.BitManipulation.Int32Extensions.ClearBits(this int, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.ClearBits(thisint,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.ClearBits(this int, Jcd.BitManipulation.BitMask)') | Sets all bits from a provided mask to "off" and returns the modified value. |
| [ReadBit(this int, int)](Jcd.BitManipulation.Int32Extensions.ReadBit(thisint,int).md 'Jcd.BitManipulation.Int32Extensions.ReadBit(this int, int)') | Read a single bit from the specified offset. |
| [ReadBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).md 'Jcd.BitManipulation.Int32Extensions.ReadBits(this int, int, int)') | For a given value return the specified bits from within it, right shifted pos bits. |
| [ReadBits(this int, int, BitMask)](Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.ReadBits(this int, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadByte(this int, int, Endian)](Jcd.BitManipulation.Int32Extensions.ReadByte(thisint,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int32Extensions.ReadByte(this int, int, Jcd.BitManipulation.Endian)') | Read a single byte from the value at the specified byte offset. |
| [ReadBytes(this int, int, int, Endian)](Jcd.BitManipulation.Int32Extensions.ReadBytes(thisint,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int32Extensions.ReadBytes(this int, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified byte location within the value. |
| [SetBit(this int, int)](Jcd.BitManipulation.Int32Extensions.SetBit(thisint,int).md 'Jcd.BitManipulation.Int32Extensions.SetBit(this int, int)') | Sets specified bit to "on" |
| [SetBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.SetBits(thisint,int,int).md 'Jcd.BitManipulation.Int32Extensions.SetBits(this int, int, int)') | Sets all specified bits to "on" |
| [SetBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.SetBits(thisint,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.SetBits(this int, Jcd.BitManipulation.BitMask)') | Sets all specified bits to "on" |
| [StoreBit(this int, bool, int)](Jcd.BitManipulation.Int32Extensions.StoreBit(thisint,bool,int).md 'Jcd.BitManipulation.Int32Extensions.StoreBit(this int, bool, int)') | Store a single bit at the specified offset. |
| [StoreBits(this int, int, int, int)](Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int).md 'Jcd.BitManipulation.Int32Extensions.StoreBits(this int, int, int, int)') | Stores a value at the specified bit location within the variable. |
| [StoreBits(this int, int, int, BitMask)](Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.StoreBits(this int, int, int, Jcd.BitManipulation.BitMask)') | Store a masked set of bits from a value to an offset in the destination The mask must apply to the destination bits. |
| [StoreByte(this int, byte, int, Endian)](Jcd.BitManipulation.Int32Extensions.StoreByte(thisint,byte,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int32Extensions.StoreByte(this int, byte, int, Jcd.BitManipulation.Endian)') | Store a single byte to the value at the specified byte offset. |
| [StoreBytes(this int, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int32Extensions.StoreBytes(this int, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte location within the value. |
| [ToBooleanArray(this int)](Jcd.BitManipulation.Int32Extensions.ToBooleanArray(thisint).md 'Jcd.BitManipulation.Int32Extensions.ToBooleanArray(this int)') | Convert an int into an array of bools |
| [ToByteArray(this int, Endian)](Jcd.BitManipulation.Int32Extensions.ToByteArray(thisint,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int32Extensions.ToByteArray(this int, Jcd.BitManipulation.Endian)') | Convert an int into an array of bytes |
| [ToggleBit(this int, int)](Jcd.BitManipulation.Int32Extensions.ToggleBit(thisint,int).md 'Jcd.BitManipulation.Int32Extensions.ToggleBit(this int, int)') | Toggles a bit. |
| [ToggleBits(this int, int, int)](Jcd.BitManipulation.Int32Extensions.ToggleBits(thisint,int,int).md 'Jcd.BitManipulation.Int32Extensions.ToggleBits(this int, int, int)') | Toggles bits and size. The default values result in toggling all bits. |
| [ToggleBits(this int, BitMask)](Jcd.BitManipulation.Int32Extensions.ToggleBits(thisint,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int32Extensions.ToggleBits(this int, Jcd.BitManipulation.BitMask)') | Toggle all the bits according to the provided mask |