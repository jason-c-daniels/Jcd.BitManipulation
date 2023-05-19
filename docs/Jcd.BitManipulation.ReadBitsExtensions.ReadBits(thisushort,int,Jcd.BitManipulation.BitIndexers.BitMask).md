#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')

## ReadBitsExtensions.ReadBits(this ushort, int, BitMask) Method

Extract a subset of bits specified by a bitmask and right align the bits by the offset.

```csharp
public static ushort ReadBits(this ushort value, int offset, Jcd.BitManipulation.BitIndexers.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitIndexers.BitMask).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the source of bits to read

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitIndexers.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisushort,int,Jcd.BitManipulation.BitIndexers.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask')

the bitmask of which bits to read.  
            Zeroed bits in the mask will always extract 0 from the source.

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The right shifted value extracted from the value