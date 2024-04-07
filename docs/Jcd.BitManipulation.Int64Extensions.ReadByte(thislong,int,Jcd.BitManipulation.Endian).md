#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ReadByte(this long, int, Endian) Method

Reads a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this long number, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ReadByte(thislong,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to read the byte from.

<a name='Jcd.BitManipulation.Int64Extensions.ReadByte(thislong,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.Int64Extensions.ReadByte(thislong,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.