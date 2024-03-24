### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.StoreBits(this ushort, ushort, int, BitMask) Method

Store a masked set of bits from a value to an offset in the destination
The mask must apply to the destination bits.

```csharp
public static ushort StoreBits(this ushort value, ushort source, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the destination for the stored bits

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the source of the bits to store

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination offset of where to store the bits

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the mask of which bits to store

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The modified value.