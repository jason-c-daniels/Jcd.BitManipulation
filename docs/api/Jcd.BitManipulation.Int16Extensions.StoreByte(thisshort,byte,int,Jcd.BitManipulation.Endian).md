#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.StoreByte(this short, byte, int, Endian) Method

Stores a single byte to the value at the specified byte offset and returns the modified value.

```csharp
public static short StoreByte(this short number, byte @byte, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.StoreByte(thisshort,byte,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to modify.

<a name='Jcd.BitManipulation.Int16Extensions.StoreByte(thisshort,byte,int,Jcd.BitManipulation.Endian).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') value to store.

<a name='Jcd.BitManipulation.Int16Extensions.StoreByte(thisshort,byte,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.Int16Extensions.StoreByte(thisshort,byte,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endianness for indexing into the bytes.

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The modified value.