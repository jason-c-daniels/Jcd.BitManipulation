### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.ReadByte(this double, int, Endian) Method

Read a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this double value, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.ReadByte(thisdouble,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to be read.

<a name='Jcd.BitManipulation.DoubleExtensions.ReadByte(thisdouble,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

<a name='Jcd.BitManipulation.DoubleExtensions.ReadByte(thisdouble,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.