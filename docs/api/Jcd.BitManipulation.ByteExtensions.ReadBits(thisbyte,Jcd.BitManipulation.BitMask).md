#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ReadBits(this byte, BitMask) Method

Extract a subset of bits specified by a bitmask.

```csharp
public static byte ReadBits(this byte number, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The source of the bits to read.

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The unshifted extracted bits