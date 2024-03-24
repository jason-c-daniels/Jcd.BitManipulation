#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBitsExtensions](Jcd.BitManipulation.ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')

## ReadBitsExtensions.ReadBits(this double, int, int) Method

For a given value return the specified bits from within it, right shifted pos bits.

```csharp
public static ulong ReadBits(this double value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisdouble,int,int).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the source of bits to read

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisdouble,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.ReadBitsExtensions.ReadBits(thisdouble,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The numeric value stored at that bit location