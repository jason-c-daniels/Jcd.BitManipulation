### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## Int64Extensions Class

Provides methods to perform easy to read bit and byte manipulations on an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

```csharp
public static class Int64Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int64Extensions

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.AreAllBitsSet(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.AreAllBitsSet(this long, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |
| [AreAnyBitsSet(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.AreAnyBitsSet(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.AreAnyBitsSet(this long, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |
| [AreNoBitsSet(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.AreNoBitsSet(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.AreNoBitsSet(this long, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |
| [BitwiseToDouble(this long)](Jcd.BitManipulation.Int64Extensions.BitwiseToDouble(thislong).md 'Jcd.BitManipulation.Int64Extensions.BitwiseToDouble(this long)') | Converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to the bit-wise identical [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') |
| [ClearBit(this long, int)](Jcd.BitManipulation.Int64Extensions.ClearBit(thislong,int).md 'Jcd.BitManipulation.Int64Extensions.ClearBit(this long, int)') | Sets bit to "off" and returns the modified value. |
| [ClearBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,int,int).md 'Jcd.BitManipulation.Int64Extensions.ClearBits(this long, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.ClearBits(this long, Jcd.BitManipulation.BitMask)') | Sets all bits from a provided mask to "off" and returns the modified value. |
| [ReadBit(this long, int)](Jcd.BitManipulation.Int64Extensions.ReadBit(thislong,int).md 'Jcd.BitManipulation.Int64Extensions.ReadBit(this long, int)') | Read a single bit from the specified offset. |
| [ReadBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,int).md 'Jcd.BitManipulation.Int64Extensions.ReadBits(this long, int, int)') | For a given value return the specified bits from within it, right shifted pos bits. |
| [ReadBits(this long, int, BitMask)](Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.ReadBits(this long, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.ReadBits(this long, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask. |
| [ReadByte(this long, int, Endian)](Jcd.BitManipulation.Int64Extensions.ReadByte(thislong,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int64Extensions.ReadByte(this long, int, Jcd.BitManipulation.Endian)') | Read a single byte from the value at the specified byte offset. |
| [ReadBytes(this long, int, int, Endian)](Jcd.BitManipulation.Int64Extensions.ReadBytes(thislong,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int64Extensions.ReadBytes(this long, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified byte location within the value. |
| [SetBit(this long, int)](Jcd.BitManipulation.Int64Extensions.SetBit(thislong,int).md 'Jcd.BitManipulation.Int64Extensions.SetBit(this long, int)') | Sets specified bit to "on" |
| [SetBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.SetBits(thislong,int,int).md 'Jcd.BitManipulation.Int64Extensions.SetBits(this long, int, int)') | Sets all specified bits to "on" |
| [SetBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.SetBits(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.SetBits(this long, Jcd.BitManipulation.BitMask)') | Sets all specified bits to "on" |
| [StoreBit(this long, bool, int)](Jcd.BitManipulation.Int64Extensions.StoreBit(thislong,bool,int).md 'Jcd.BitManipulation.Int64Extensions.StoreBit(this long, bool, int)') | Store a single bit at the specified offset. |
| [StoreBits(this long, long, int, int)](Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,int).md 'Jcd.BitManipulation.Int64Extensions.StoreBits(this long, long, int, int)') | Stores a value at the specified bit location within the variable. |
| [StoreBits(this long, long, int, BitMask)](Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.StoreBits(this long, long, int, Jcd.BitManipulation.BitMask)') | Store a masked set of bits from a value to an offset in the destination The mask must apply to the destination bits. |
| [StoreByte(this long, byte, int, Endian)](Jcd.BitManipulation.Int64Extensions.StoreByte(thislong,byte,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int64Extensions.StoreByte(this long, byte, int, Jcd.BitManipulation.Endian)') | Store a single byte to the value at the specified byte offset. |
| [StoreBytes(this long, byte[], int, int, Endian)](Jcd.BitManipulation.Int64Extensions.StoreBytes(thislong,byte[],int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int64Extensions.StoreBytes(this long, byte[], int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte location within the value. |
| [StoreBytes(this long, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.Int64Extensions.StoreBytes(thislong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int64Extensions.StoreBytes(this long, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte location within the value. |
| [ToBooleanArray(this long)](Jcd.BitManipulation.Int64Extensions.ToBooleanArray(thislong).md 'Jcd.BitManipulation.Int64Extensions.ToBooleanArray(this long)') | Convert a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into an array of bools |
| [ToByteArray(this long, Endian)](Jcd.BitManipulation.Int64Extensions.ToByteArray(thislong,Jcd.BitManipulation.Endian).md 'Jcd.BitManipulation.Int64Extensions.ToByteArray(this long, Jcd.BitManipulation.Endian)') | Convert a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into an array of bytes |
| [ToggleBit(this long, int)](Jcd.BitManipulation.Int64Extensions.ToggleBit(thislong,int).md 'Jcd.BitManipulation.Int64Extensions.ToggleBit(this long, int)') | Toggles a bit. |
| [ToggleBits(this long, int, int)](Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,int,int).md 'Jcd.BitManipulation.Int64Extensions.ToggleBits(this long, int, int)') | Toggles bits and size. The default values result in toggling all bits. |
| [ToggleBits(this long, BitMask)](Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.Int64Extensions.ToggleBits(this long, Jcd.BitManipulation.BitMask)') | Toggle all the bits according to the provided mask |
