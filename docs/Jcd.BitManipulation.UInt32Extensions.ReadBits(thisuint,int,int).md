### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.ReadBits(this uint, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static uint ReadBits(this uint value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.ReadBits(thisuint,int,int).value'></a>

`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The source of bits to read.

<a name='Jcd.BitManipulation.UInt32Extensions.ReadBits(thisuint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.UInt32Extensions.ReadBits(thisuint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The value stored in the range of bits specified, right shifted by the offset..