### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.StoreBits(this double, ulong, int, BitMask) Method

Store a masked set of bits from a value to an offset in the destination
The mask must apply to the destination bits.

```csharp
public static double StoreBits(this double value, ulong source, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.StoreBits(thisdouble,ulong,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the destination for the stored bits

<a name='Jcd.BitManipulation.DoubleExtensions.StoreBits(thisdouble,ulong,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the source of the bits to store

<a name='Jcd.BitManipulation.DoubleExtensions.StoreBits(thisdouble,ulong,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the destination offset of where to store the bits

<a name='Jcd.BitManipulation.DoubleExtensions.StoreBits(thisdouble,ulong,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the mask of which bits to store

#### Returns

[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The modified value.