#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.StoreBits(this long, long, int, BitMask) Method

Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified
value.

```csharp
public static long StoreBits(this long value, long source, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

the destination for the stored bits

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The source of the bits to store.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The destination offset of where to store the bits.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The mask specifying the bits to store

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The modified value.