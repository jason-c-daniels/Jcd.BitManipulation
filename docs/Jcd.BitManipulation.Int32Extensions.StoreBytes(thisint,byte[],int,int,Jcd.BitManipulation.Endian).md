### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.StoreBytes(this int, byte[], int, int, Endian) Method

Stores a set of bytes starting at the specified byte location within the value.

```csharp
public static int StoreBytes(this int value, byte[] bytes, int offset, int size=-1, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,byte[],int,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be modified.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,byte[],int,int,Jcd.BitManipulation.Endian).bytes'></a>

`bytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,byte[],int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,byte[],int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store. -1 means all bytes.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBytes(thisint,byte[],int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The modified value.