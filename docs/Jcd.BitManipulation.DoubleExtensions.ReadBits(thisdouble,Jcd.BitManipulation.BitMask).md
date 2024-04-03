#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.ReadBits(this double, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static ulong ReadBits(this double value, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.ReadBits(thisdouble,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The source of the bits to read.

<a name='Jcd.BitManipulation.DoubleExtensions.ReadBits(thisdouble,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The extracted bits right shifted by the specified amount.