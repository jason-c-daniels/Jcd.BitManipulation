### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')

## ReadBitsExtensions.ReadBits(this ulong, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static ulong ReadBits(this ulong value, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the source of bits to read

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bitmask of which bits to read.
Zeroed bits in the mask will always extract 0 from the source.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The right shifted value extracted from the value