### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.ReadBits(this int, int, int) Method

For a given value return the specified bits from within it, right shifted pos bits.

```csharp
public static int ReadBits(this int value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the source of bits to read

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The numeric value stored at that bit location