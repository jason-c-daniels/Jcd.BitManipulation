#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.ReadByte(this short, int, Endian) Method

Reads a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this short number, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.ReadByte(thisshort,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to read the byte from.

<a name='Jcd.BitManipulation.Int16Extensions.ReadByte(thisshort,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.Int16Extensions.ReadByte(thisshort,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.