### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.StoreBits(this byte, byte, int, BitMask) Method

Store a masked set of bits from a value to an offset in the destination
The mask must apply to the destination bits.

```csharp
public static byte StoreBits(this byte value, byte source, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

the destination for the stored bits

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

the source of the bits to store

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination offset of where to store the bits

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the mask of which bits to store

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The modified value.