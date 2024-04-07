#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.StoreBits(this sbyte, sbyte, int, BitMask) Method

Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified
value.

```csharp
public static sbyte StoreBits(this sbyte number, sbyte source, int offset, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

the destination for the stored bits

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The source of the bits to store.

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The destination offset of where to store the bits.

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The mask specifying the bits to store

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The modified value.