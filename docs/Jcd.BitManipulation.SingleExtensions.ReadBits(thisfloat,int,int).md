### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions.md 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.ReadBits(this float, int, int) Method

For a given value return the specified bits from within it, right shifted pos bits.

```csharp
public static uint ReadBits(this float value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,int).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

the source of bits to read

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The numeric value stored at that bit location