### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ReadBits(this ushort, int, int) Method

For a given value return the specified bits from within it, right shifted pos bits.

```csharp
public static ushort ReadBits(this ushort value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the source of bits to read

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBits(thisushort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The numeric value stored at that bit location