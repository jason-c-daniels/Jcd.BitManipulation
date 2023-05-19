#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this short, short, int, BitMask) Method

Store a masked set of bits from a value to an offset in the destination  
The mask must apply to the destination bits.

```csharp
public static short StoreBits(this short value, short source, int offset, Jcd.BitManipulation.BitIndexers.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitIndexers.BitMask).value'></a>

`value` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

the destination for the stored bits

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitIndexers.BitMask).source'></a>

`source` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

the source of the bits to store

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitIndexers.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination offset of where to store the bits

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitIndexers.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask')

the mask of which bits to store

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')