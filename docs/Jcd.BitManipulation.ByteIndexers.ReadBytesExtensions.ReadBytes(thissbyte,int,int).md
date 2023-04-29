#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ReadBytesExtensions](Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.md 'Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this sbyte, int, int) Method

Reads a set of bytes starting at the specified byte location within the value.

```csharp
public static byte[] ReadBytes(this sbyte value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thissbyte,int,int).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value to be read.

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thissbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thissbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')