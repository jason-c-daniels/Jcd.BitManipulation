#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ReadBits(this ushort, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static ushort ReadBits(this ushort number, int shift, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The source of the bits to read.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitMask).shift'></a>

`shift` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The extracted bits right shifted by the specified amount.