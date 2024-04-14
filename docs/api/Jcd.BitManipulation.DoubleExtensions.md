#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## DoubleExtensions Class

Provides easy to read methods for bit manipulation operations on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

```csharp
public static class DoubleExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DoubleExtensions

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.AreAllBitsSet(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.AreAllBitsSet(this double, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |
| [AreAnyBitsSet(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.AreAnyBitsSet(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.AreAnyBitsSet(this double, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |
| [AreNoBitsSet(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.AreNoBitsSet(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.AreNoBitsSet(this double, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |
| [BitwiseToInt64(this double)](Jcd.BitManipulation.DoubleExtensions.BitwiseToInt64(thisdouble) 'Jcd.BitManipulation.DoubleExtensions.BitwiseToInt64(this double)') | Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to the bit-wise identical [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |
| [BitwiseToUInt64(this double)](Jcd.BitManipulation.DoubleExtensions.BitwiseToUInt64(thisdouble) 'Jcd.BitManipulation.DoubleExtensions.BitwiseToUInt64(this double)') | Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to the bit-wise identical [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [ClearBit(this double, int)](Jcd.BitManipulation.DoubleExtensions.ClearBit(thisdouble,int) 'Jcd.BitManipulation.DoubleExtensions.ClearBit(this double, int)') | Sets the specified bit to "off" and returns the modified value. |
| [ClearBits(this double, int, int)](Jcd.BitManipulation.DoubleExtensions.ClearBits(thisdouble,int,int) 'Jcd.BitManipulation.DoubleExtensions.ClearBits(this double, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.ClearBits(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.ClearBits(this double, Jcd.BitManipulation.BitMask)') | Sets all bits from the provided mask to "off" and returns the modified value. |
| [ReadBit(this double, int)](Jcd.BitManipulation.DoubleExtensions.ReadBit(thisdouble,int) 'Jcd.BitManipulation.DoubleExtensions.ReadBit(this double, int)') | Reads a single bit from the specified position. |
| [ReadBits(this double, int, int)](Jcd.BitManipulation.DoubleExtensions.ReadBits(thisdouble,int,int) 'Jcd.BitManipulation.DoubleExtensions.ReadBits(this double, int, int)') | Reads the bits specified and returns the result shifted to the right by the offset. |
| [ReadBits(this double, int, BitMask)](Jcd.BitManipulation.DoubleExtensions.ReadBits(thisdouble,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.ReadBits(this double, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadBits(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.ReadBits(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.ReadBits(this double, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadByte(this double, int, Endian)](Jcd.BitManipulation.DoubleExtensions.ReadByte(thisdouble,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.DoubleExtensions.ReadByte(this double, int, Jcd.BitManipulation.Endian)') | Reads a single byte from the value at the specified byte offset. |
| [ReadBytes(this double, int, int, Endian)](Jcd.BitManipulation.DoubleExtensions.ReadBytes(thisdouble,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.DoubleExtensions.ReadBytes(this double, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified byte location within the value. |
| [SetBit(this double, int)](Jcd.BitManipulation.DoubleExtensions.SetBit(thisdouble,int) 'Jcd.BitManipulation.DoubleExtensions.SetBit(this double, int)') | Sets the bit at the specified to 1 and returns the modified value. |
| [SetBits(this double, int, int)](Jcd.BitManipulation.DoubleExtensions.SetBits(thisdouble,int,int) 'Jcd.BitManipulation.DoubleExtensions.SetBits(this double, int, int)') | Sets all specified bits to 1 and returns the modified value. |
| [SetBits(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.SetBits(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.SetBits(this double, Jcd.BitManipulation.BitMask)') | Sets all specified bits to 1 and returns the modified value. |
| [StoreBit(this double, bool, int)](Jcd.BitManipulation.DoubleExtensions.StoreBit(thisdouble,bool,int) 'Jcd.BitManipulation.DoubleExtensions.StoreBit(this double, bool, int)') | Store a single bit at the specified offset and returns the modified value. |
| [StoreBits(this double, ulong, int, int)](Jcd.BitManipulation.DoubleExtensions.StoreBits(thisdouble,ulong,int,int) 'Jcd.BitManipulation.DoubleExtensions.StoreBits(this double, ulong, int, int)') | Stores a range of bits to the value, from a source value, and returns the modified value. |
| [StoreBits(this double, ulong, int, BitMask)](Jcd.BitManipulation.DoubleExtensions.StoreBits(thisdouble,ulong,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.StoreBits(this double, ulong, int, Jcd.BitManipulation.BitMask)') | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value. |
| [StoreByte(this double, byte, int, Endian)](Jcd.BitManipulation.DoubleExtensions.StoreByte(thisdouble,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.DoubleExtensions.StoreByte(this double, byte, int, Jcd.BitManipulation.Endian)') | Stores a single byte to the value at the specified byte offset and returns the modified value. |
| [StoreBytes(this double, byte[], int, int, Endian)](Jcd.BitManipulation.DoubleExtensions.StoreBytes(thisdouble,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.DoubleExtensions.StoreBytes(this double, byte[], int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value. |
| [StoreBytes(this double, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.DoubleExtensions.StoreBytes(thisdouble,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.DoubleExtensions.StoreBytes(this double, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value. |
| [ToBooleanArray(this double)](Jcd.BitManipulation.DoubleExtensions.ToBooleanArray(thisdouble) 'Jcd.BitManipulation.DoubleExtensions.ToBooleanArray(this double)') | Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') into an array of  values with the lease significant bit at index 0.. |
| [ToByteArray(this double, Endian)](Jcd.BitManipulation.DoubleExtensions.ToByteArray(thisdouble,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.DoubleExtensions.ToByteArray(this double, Jcd.BitManipulation.Endian)') | Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this double, int)](Jcd.BitManipulation.DoubleExtensions.ToggleBit(thisdouble,int) 'Jcd.BitManipulation.DoubleExtensions.ToggleBit(this double, int)') | Toggles a bit at the specified offset and returns the modified value. |
| [ToggleBits(this double, int, int)](Jcd.BitManipulation.DoubleExtensions.ToggleBits(thisdouble,int,int) 'Jcd.BitManipulation.DoubleExtensions.ToggleBits(this double, int, int)') | Toggles the specified range of bits and returns the modified value. |
| [ToggleBits(this double, BitMask)](Jcd.BitManipulation.DoubleExtensions.ToggleBits(thisdouble,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.DoubleExtensions.ToggleBits(this double, Jcd.BitManipulation.BitMask)') | Toggle all the bits specified in the provided bit mask and returns the modified value. |