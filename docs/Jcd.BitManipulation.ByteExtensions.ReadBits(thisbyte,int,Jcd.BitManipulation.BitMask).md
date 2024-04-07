#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ReadBits(this byte, int, BitMask) Method

Reads the bits specified by a mask and right shifts it .

```csharp
public static byte ReadBits(this byte number, int shift, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The source of the bits to read.

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,Jcd.BitManipulation.BitMask).shift'></a>

`shift` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to right shift the result of applying the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask').

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The extracted bits right shifted by the specified amount.