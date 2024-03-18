#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this float, uint, int, BitMask) Method

Store a masked set of bits from a value to an offset in the destination
The mask must apply to the destination bits.

```csharp
public static float StoreBits(this float value, uint source, int offset, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisfloat,uint,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

the destination for the stored bits

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisfloat,uint,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

the source of the bits to store

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisfloat,uint,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination offset of where to store the bits

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisfloat,uint,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the mask of which bits to store

#### Returns

[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
The modified value.