#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ReadBytesExtensions](Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.md 'Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this long, int, int) Method

Reads a set of bytes starting at the specified byte location within the value.

```csharp
public static byte[] ReadBytes(this long value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thislong,int,int).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to be read.

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thislong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thislong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte size of the value.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')