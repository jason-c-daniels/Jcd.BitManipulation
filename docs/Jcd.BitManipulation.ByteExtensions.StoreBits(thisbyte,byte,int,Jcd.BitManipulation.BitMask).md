#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.StoreBits(this byte, byte, int, BitMask) Method

Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified
value.

```csharp
public static byte StoreBits(this byte number, byte source, int offset, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

the destination for the stored bits

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The source of the bits to store.

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The destination offset of where to store the bits.

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The mask specifying the bits to store

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The modified value.