#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions.md 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.StoreByte(this float, byte, int, Endian) Method

Stores a single byte to the value at the specified byte offset and returns the modified value.

```csharp
public static float StoreByte(this float number, byte @byte, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.StoreByte(thisfloat,byte,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value to modify.

<a name='Jcd.BitManipulation.SingleExtensions.StoreByte(thisfloat,byte,int,Jcd.BitManipulation.Endian).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') value to store.

<a name='Jcd.BitManipulation.SingleExtensions.StoreByte(thisfloat,byte,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.SingleExtensions.StoreByte(thisfloat,byte,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the indexing within the value.

#### Returns

[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
The modified value.