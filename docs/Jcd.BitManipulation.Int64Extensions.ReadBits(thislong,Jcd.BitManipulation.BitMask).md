#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ReadBits(this long, BitMask) Method

Extract a subset of bits specified by a bitmask.

```csharp
public static long ReadBits(this long number, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The source of the bits to read.

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The unshifted extracted bits