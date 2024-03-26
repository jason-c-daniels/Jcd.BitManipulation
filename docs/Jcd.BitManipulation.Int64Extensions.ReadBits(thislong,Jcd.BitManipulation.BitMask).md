### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ReadBits(this long, BitMask) Method

Extract a subset of bits specified by a bitmask.

```csharp
public static long ReadBits(this long value, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

the source of bits to read

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bitmask of which bits to read.
Zeroed bits in the mask will always extract 0 from the source.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The unshifted extracted bits