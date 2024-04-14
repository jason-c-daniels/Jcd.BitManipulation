#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.StoreBits(this int, int, int, BitMask) Method

Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified
value.

```csharp
public static int StoreBits(this int number, int source, int offset, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination for the stored bits

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The source of the bits to store.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The destination offset of where to store the bits.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The mask specifying the bits to store

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The modified value.