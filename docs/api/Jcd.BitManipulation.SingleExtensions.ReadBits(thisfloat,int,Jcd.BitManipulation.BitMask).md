#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.ReadBits(this float, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static uint ReadBits(this float number, int shift, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The source of the bits to read.

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,Jcd.BitManipulation.BitMask).shift'></a>

`shift` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The extracted bits right shifted by the specified amount.