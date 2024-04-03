#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.ReadBits(this sbyte, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static sbyte ReadBits(this sbyte value, int shift, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The source of the bits to read.

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,Jcd.BitManipulation.BitMask).shift'></a>

`shift` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to right shift the result of applying the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask').

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The extracted bits right shifted by the specified amount.