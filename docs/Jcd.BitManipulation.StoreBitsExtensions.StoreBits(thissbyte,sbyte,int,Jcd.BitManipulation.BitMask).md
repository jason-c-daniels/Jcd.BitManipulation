#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this sbyte, sbyte, int, BitMask) Method

Store a masked set of bits from a value to an offset in the destination  
The mask must apply to the destination bits.

```csharp
public static sbyte StoreBits(this sbyte value, sbyte source, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

the destination for the stored bits

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

the source of the bits to store

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination offset of where to store the bits

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thissbyte,sbyte,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the mask of which bits to store

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')