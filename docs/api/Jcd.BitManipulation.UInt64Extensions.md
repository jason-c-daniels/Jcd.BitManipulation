#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## UInt64Extensions Class

Provides easy to read methods for bit manipulation operations on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

```csharp
public static class UInt64Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt64Extensions

### Example

```csharp
ulong data = 0;

// turn on all the bits
data = data.SetBits(0, 64); // value is now
// 0b1111111111111111111111111111111111111111111111111111111111111111
// this is the equivalent as above
data = data.SetBits();

// Clear the middle 4 bits.
data = data.ClearBits(4, 8); // value is now
// 0b1111111111111111111111111111111111111111111111111111000000001111

// Toggle all the bits.
data = data.ToggleBits(); // value is now
// 0b0000000000000000000000000000000000000000000000000000111111110000

var finalData = data;

// read the second byte
var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

// write 0b1011 into the upper nybble
secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

// chaining operations, the same steps and end results
data.ClearBits();
data = data.SetBits(0, 64) // value is now 0b1111111111111111111111111111111111111111111111111111111111111111
           .SetBits() // this is the equivalent as above
           .ClearBits(4, 8) // value is now 0b1111111111111111111111111111111111111111111111111111000000001111
           .ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
                         .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now
// secondByte is now 0b10111111

// finalData is 0b0000000000000000000000000000000000000000000000000000111111110000
var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big)
                           .StoreByte(0b01010101, 0, Endian.Little)
;
// mutatedData is now 0b1011111100000000000000000000000000000000000000000000111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00000000, 0b00000000,
                                                //       0b00000000, 0b00000000, 0b00001111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b00000000,
                                                   //       0b00000000, 0b00000000, 0b00000000, 0b10111111]

var leBaToUInt64Le = leBa.ToUInt64(Endian.Little); // leBaToUInt64Le = 0b1011111100000000000000000000000000000000000000000000111101010101

var leBaToUInt64Be = leBa.ToUInt64(Endian.Big); // leBaToUInt64Be = 0b0101010100001111000000000000000000000000000000000000000010111111
```

| Methods | |
| :--- | :--- |
| [AreAllBitsSet(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.AreAllBitsSet(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.AreAllBitsSet(this ulong, Jcd.BitManipulation.BitMask)') | Tests if all of the bits from the bitmask are set on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [AreAnyBitsSet(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.AreAnyBitsSet(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.AreAnyBitsSet(this ulong, Jcd.BitManipulation.BitMask)') | Tests if any bits from the bitmask are set on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [AreNoBitsSet(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.AreNoBitsSet(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.AreNoBitsSet(this ulong, Jcd.BitManipulation.BitMask)') | Tests if none of the bits from the bitmask are set on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [BitwiseToDouble(this ulong)](Jcd.BitManipulation.UInt64Extensions.BitwiseToDouble(thisulong) 'Jcd.BitManipulation.UInt64Extensions.BitwiseToDouble(this ulong)') | Converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to the bit-wise identical [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') |
| [ClearBit(this ulong, int)](Jcd.BitManipulation.UInt64Extensions.ClearBit(thisulong,int) 'Jcd.BitManipulation.UInt64Extensions.ClearBit(this ulong, int)') | Sets the specified bit to "off" and returns the modified value. |
| [ClearBits(this ulong, int, int)](Jcd.BitManipulation.UInt64Extensions.ClearBits(thisulong,int,int) 'Jcd.BitManipulation.UInt64Extensions.ClearBits(this ulong, int, int)') | Sets all specified bits to "off" and returns the modified value. |
| [ClearBits(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.ClearBits(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.ClearBits(this ulong, Jcd.BitManipulation.BitMask)') | Sets all bits from the provided mask to "off" and returns the modified value. |
| [ReadBit(this ulong, int)](Jcd.BitManipulation.UInt64Extensions.ReadBit(thisulong,int) 'Jcd.BitManipulation.UInt64Extensions.ReadBit(this ulong, int)') | Reads a single bit from the specified position. |
| [ReadBits(this ulong, int, int)](Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,int) 'Jcd.BitManipulation.UInt64Extensions.ReadBits(this ulong, int, int)') | Reads the bits specified and returns the result shifted to the right by the offset. |
| [ReadBits(this ulong, int, BitMask)](Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.ReadBits(this ulong, int, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask and right align the bits by the offset. |
| [ReadBits(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.ReadBits(this ulong, Jcd.BitManipulation.BitMask)') | Extract a subset of bits specified by a bitmask. |
| [ReadByte(this ulong, int, Endian)](Jcd.BitManipulation.UInt64Extensions.ReadByte(thisulong,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt64Extensions.ReadByte(this ulong, int, Jcd.BitManipulation.Endian)') | Reads a single byte from the value at the specified byte offset. |
| [ReadBytes(this ulong, int, int, Endian)](Jcd.BitManipulation.UInt64Extensions.ReadBytes(thisulong,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt64Extensions.ReadBytes(this ulong, int, int, Jcd.BitManipulation.Endian)') | Reads a set of bytes starting at the specified byte location within the value. |
| [SetBit(this ulong, int)](Jcd.BitManipulation.UInt64Extensions.SetBit(thisulong,int) 'Jcd.BitManipulation.UInt64Extensions.SetBit(this ulong, int)') | Sets the bit at the specified to 1 and returns the modified value. |
| [SetBits(this ulong, int, int)](Jcd.BitManipulation.UInt64Extensions.SetBits(thisulong,int,int) 'Jcd.BitManipulation.UInt64Extensions.SetBits(this ulong, int, int)') | Sets all specified bits to 1 and returns the modified value. |
| [SetBits(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.SetBits(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.SetBits(this ulong, Jcd.BitManipulation.BitMask)') | Sets all specified bits to 1 and returns the modified value. |
| [StoreBit(this ulong, bool, int)](Jcd.BitManipulation.UInt64Extensions.StoreBit(thisulong,bool,int) 'Jcd.BitManipulation.UInt64Extensions.StoreBit(this ulong, bool, int)') | Store a single bit at the specified offset and returns the modified value. |
| [StoreBits(this ulong, ulong, int, int)](Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,int) 'Jcd.BitManipulation.UInt64Extensions.StoreBits(this ulong, ulong, int, int)') | Stores a range of bits to the value, from a source value, and returns the modified value. |
| [StoreBits(this ulong, ulong, int, BitMask)](Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.StoreBits(this ulong, ulong, int, Jcd.BitManipulation.BitMask)') | Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified value. |
| [StoreByte(this ulong, byte, int, Endian)](Jcd.BitManipulation.UInt64Extensions.StoreByte(thisulong,byte,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt64Extensions.StoreByte(this ulong, byte, int, Jcd.BitManipulation.Endian)') | Stores a single byte to the value at the specified byte offset and returns the modified value. |
| [StoreBytes(this ulong, byte[], int, int, Endian)](Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,byte[],int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt64Extensions.StoreBytes(this ulong, byte[], int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value. |
| [StoreBytes(this ulong, ReadOnlySpan&lt;byte&gt;, int, int, Endian)](Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt64Extensions.StoreBytes(this ulong, System.ReadOnlySpan<byte>, int, int, Jcd.BitManipulation.Endian)') | Stores a set of bytes starting at the specified byte offset and returns the modified value. |
| [ToBooleanArray(this ulong)](Jcd.BitManipulation.UInt64Extensions.ToBooleanArray(thisulong) 'Jcd.BitManipulation.UInt64Extensions.ToBooleanArray(this ulong)') | Converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') into an array of  values with the lease significant bit at index 0. |
| [ToByteArray(this ulong, Endian)](Jcd.BitManipulation.UInt64Extensions.ToByteArray(thisulong,Jcd.BitManipulation.Endian) 'Jcd.BitManipulation.UInt64Extensions.ToByteArray(this ulong, Jcd.BitManipulation.Endian)') | Converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian'). |
| [ToggleBit(this ulong, int)](Jcd.BitManipulation.UInt64Extensions.ToggleBit(thisulong,int) 'Jcd.BitManipulation.UInt64Extensions.ToggleBit(this ulong, int)') | Toggles a bit at the specified offset and returns the modified value. |
| [ToggleBits(this ulong, int, int)](Jcd.BitManipulation.UInt64Extensions.ToggleBits(thisulong,int,int) 'Jcd.BitManipulation.UInt64Extensions.ToggleBits(this ulong, int, int)') | Toggles the specified range of bits and returns the modified value. |
| [ToggleBits(this ulong, BitMask)](Jcd.BitManipulation.UInt64Extensions.ToggleBits(thisulong,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.UInt64Extensions.ToggleBits(this ulong, Jcd.BitManipulation.BitMask)') | Toggle all the bits specified in the provided bit mask and returns the modified value. |
