#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.ReadBits(this int, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static int ReadBits(this int number, int shift, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The source of the bits to read.

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,Jcd.BitManipulation.BitMask).shift'></a>

`shift` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to right shift the result of applying the [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask').

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The extracted bits right shifted by the specified amount.