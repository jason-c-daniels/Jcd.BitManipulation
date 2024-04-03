#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions.md 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ReadBits(this ulong, BitMask) Method

Extract a subset of bits specified by a bitmask.

```csharp
public static ulong ReadBits(this ulong value, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The source of the bits to read.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The unshifted extracted bits