#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.ReadBytes(this double, int, int, Endian) Method

Reads a set of bytes starting at the specified byte location within the value.

```csharp
public static byte[] ReadBytes(this double value, int offset, int size, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.ReadBytes(thisdouble,int,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to read the bytes from.

<a name='Jcd.BitManipulation.DoubleExtensions.ReadBytes(thisdouble,int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte offset to starting reading from.

<a name='Jcd.BitManipulation.DoubleExtensions.ReadBytes(thisdouble,int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The requested number of bytes to read.

<a name='Jcd.BitManipulation.DoubleExtensions.ReadBytes(thisdouble,int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endianness of the indexing for the byte read.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
A byte array of the value in the specified endian.