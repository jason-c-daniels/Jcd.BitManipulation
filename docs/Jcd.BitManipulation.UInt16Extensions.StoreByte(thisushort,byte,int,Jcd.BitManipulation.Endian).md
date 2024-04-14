#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.StoreByte(this ushort, byte, int, Endian) Method

Stores a single byte to the value at the specified byte offset and returns the modified value.

```csharp
public static ushort StoreByte(this ushort number, byte @byte, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.StoreByte(thisushort,byte,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to modify.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreByte(thisushort,byte,int,Jcd.BitManipulation.Endian).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') value to store.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreByte(thisushort,byte,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreByte(thisushort,byte,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endianness for indexing into the bytes.

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The modified value.