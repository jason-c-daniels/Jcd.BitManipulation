### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ReadBits(this byte, int, int) Method

For a given value return the specified bits from within it, right shifted pos bits.

```csharp
public static byte ReadBits(this byte value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

the source of bits to read

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the bit offset to read from

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The numeric value stored at that bit location