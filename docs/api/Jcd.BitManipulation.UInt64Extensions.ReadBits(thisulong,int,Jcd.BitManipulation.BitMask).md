#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ReadBits(this ulong, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static ulong ReadBits(this ulong number, int shift, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The source of the bits to read.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask).shift'></a>

`shift` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The extracted bits right shifted by the specified amount.