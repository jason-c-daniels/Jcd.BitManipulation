### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')

## ReadBitsExtensions.ReadBits(this sbyte, int, int) Method

For a given value return the specified bits from within it, right shifted pos bits.

```csharp
public static sbyte ReadBits(this sbyte value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thissbyte,int,int).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

the source of bits to read

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thissbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thissbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The numeric value stored at that bit location