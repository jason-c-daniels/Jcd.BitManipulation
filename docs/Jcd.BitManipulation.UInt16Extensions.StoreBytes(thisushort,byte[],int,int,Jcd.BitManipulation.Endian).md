#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.StoreBytes(this ushort, byte[], int, int, Endian) Method

Stores a set of bytes starting at the specified byte offset and returns the modified value.

```csharp
public static ushort StoreBytes(this ushort value, byte[] bytes, int offset, int size=-1, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,byte[],int,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to modify.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,byte[],int,int,Jcd.BitManipulation.Endian).bytes'></a>

`bytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,byte[],int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,byte[],int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store. -1 means all bytes.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBytes(thisushort,byte[],int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The modified value.