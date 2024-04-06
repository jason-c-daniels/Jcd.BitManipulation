#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ReadBits(this byte, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static byte ReadBits(this byte number, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The source of the bits to read.

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.ByteExtensions.ReadBits(thisbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The value stored in the range of bits specified, right shifted by the offset..