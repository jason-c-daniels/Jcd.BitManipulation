### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## ByteExtensions Class

Provides methods to perform easy to read bit manipulations on a single [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

```csharp
public static class ByteExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ByteExtensions

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.AreAllBitsSet(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.AreAllBitsSet(this byte, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [AreAnyBitsSet(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.AreAnyBitsSet(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.AreAnyBitsSet(this byte, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [AreNoBitsSet(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.AreNoBitsSet(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.AreNoBitsSet(this byte, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [ClearBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.ClearBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.ClearBit(this byte, int)') | Sets bit to "off" and returns the modified value. |
| [ClearBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.ClearBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.ClearBits(this byte, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.ClearBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ClearBits(this byte, Jcd.BitManipulation.BitMask)') | Sets all bits from a provided mask to "off" and returns the modified value. |
| [ReadBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.ReadBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.ReadBit(this byte, int)') | Read a single bit from the specified offset. |
| [ReadBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.ReadBits(this byte, int, int)') | For a given value return the specified bits from within it, right shifted pos bits. |
| [ReadBits(this byte, int, BitMask)](Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ReadBits(this byte, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [SetBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.SetBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.SetBit(this byte, int)') | Sets specified bit to "on" |
| [SetBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.SetBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.SetBits(this byte, int, int)') | Sets all specified bits to "on" |
| [SetBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.SetBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.SetBits(this byte, Jcd.BitManipulation.BitMask)') | Sets all specified bits to "on" |
| [StoreBit(this byte, bool, int)](Jcd.BitManipulation.ByteExtensions.StoreBit(thisbyte,bool,int).md 'Jcd.BitManipulation.ByteExtensions.StoreBit(this byte, bool, int)') | Store a single bit at the specified offset. |
| [StoreBits(this byte, byte, int, int)](Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,int).md 'Jcd.BitManipulation.ByteExtensions.StoreBits(this byte, byte, int, int)') | Stores a value at the specified bit location within the variable. |
| [StoreBits(this byte, byte, int, BitMask)](Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.StoreBits(this byte, byte, int, Jcd.BitManipulation.BitMask)') | Store a masked set of bits from a value to an offset in the destination The mask must apply to the destination bits. |
| [ToBooleanArray(this byte)](Jcd.BitManipulation.ByteExtensions.ToBooleanArray(thisbyte).md 'Jcd.BitManipulation.ByteExtensions.ToBooleanArray(this byte)') | Convert a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') into an array of bools |
| [ToByteArray(this byte)](Jcd.BitManipulation.ByteExtensions.ToByteArray(thisbyte).md 'Jcd.BitManipulation.ByteExtensions.ToByteArray(this byte)') | Convert a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') into an array of bytes |
| [ToggleBit(this byte, int)](Jcd.BitManipulation.ByteExtensions.ToggleBit(thisbyte,int).md 'Jcd.BitManipulation.ByteExtensions.ToggleBit(this byte, int)') | Toggles a bit. |
| [ToggleBits(this byte, int, int)](Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,int,int).md 'Jcd.BitManipulation.ByteExtensions.ToggleBits(this byte, int, int)') | Toggles bits and size. The default values result in toggling all bits. |
| [ToggleBits(this byte, BitMask)](Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.ByteExtensions.ToggleBits(this byte, Jcd.BitManipulation.BitMask)') | Toggle all the bits according to the provided mask |