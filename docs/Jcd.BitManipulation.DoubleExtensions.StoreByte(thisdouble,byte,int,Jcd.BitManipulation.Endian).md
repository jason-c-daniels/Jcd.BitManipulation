#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.StoreByte(this double, byte, int, Endian) Method

Stores a single byte to the value at the specified byte offset and returns the modified value.

```csharp
public static double StoreByte(this double value, byte @byte, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.StoreByte(thisdouble,byte,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to modify.

<a name='Jcd.BitManipulation.DoubleExtensions.StoreByte(thisdouble,byte,int,Jcd.BitManipulation.Endian).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') value to store.

<a name='Jcd.BitManipulation.DoubleExtensions.StoreByte(thisdouble,byte,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.DoubleExtensions.StoreByte(thisdouble,byte,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the indexing within the value.

#### Returns

[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The modified value.