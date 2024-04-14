#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.ReadBits(this sbyte, BitMask) Method

Extract a subset of bits specified by a bitmask.

```csharp
public static sbyte ReadBits(this sbyte number, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The source of the bits to read.

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The unshifted extracted bits