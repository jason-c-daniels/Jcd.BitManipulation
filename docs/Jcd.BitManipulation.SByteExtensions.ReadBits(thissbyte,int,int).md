#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.ReadBits(this sbyte, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static sbyte ReadBits(this sbyte value, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,int).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The source of the bits to read.

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.SByteExtensions.ReadBits(thissbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The value stored in the range of bits specified, right shifted by the offset..