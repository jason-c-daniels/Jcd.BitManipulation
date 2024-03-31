### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ReadBit(this byte, int) Method

Reads a single bit from the specified position.

```csharp
public static bool ReadBit(this byte value, int offset);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ReadBit(thisbyte,int).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The source of the bits to read.

<a name='Jcd.BitManipulation.ByteExtensions.ReadBit(thisbyte,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bit to read.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
The bit at the specified position returned as a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean').