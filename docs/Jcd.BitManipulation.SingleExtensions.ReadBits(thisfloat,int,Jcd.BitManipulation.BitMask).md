### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions.md 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.ReadBits(this float, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static uint ReadBits(this float value, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

the source of bits to read

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bitmask of which bits to read.
Zeroed bits in the mask will always extract 0 from the source.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The right shifted extracted bits