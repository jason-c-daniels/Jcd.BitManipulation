#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.StoreBits(this ulong, ulong, int, BitMask) Method

Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified
value.

```csharp
public static ulong StoreBits(this ulong number, ulong source, int offset, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the destination for the stored bits

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The source of the bits to store.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The destination offset of where to store the bits.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The mask specifying the bits to store

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.