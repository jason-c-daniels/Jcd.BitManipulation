#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ReadBits(this ushort, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static ushort ReadBits(this ushort number, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The source of the bits to read.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The value stored in the range of bits specified, right shifted by the offset..