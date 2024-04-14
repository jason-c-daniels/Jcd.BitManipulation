#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ReadBytes(this ulong, int, int, Endian) Method

Reads a set of bytes starting at the specified byte location within the value.

```csharp
public static byte[] ReadBytes(this ulong number, int offset, int size, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBytes(thisulong,int,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to read the bytes from.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBytes(thisulong,int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte offset to starting reading from.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBytes(thisulong,int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The requested number of bytes to read.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBytes(thisulong,int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endianness of the indexing for the byte read.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
A byte array of the value in the specified endian.