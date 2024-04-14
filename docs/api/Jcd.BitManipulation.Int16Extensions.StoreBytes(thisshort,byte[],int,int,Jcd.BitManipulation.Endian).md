#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.StoreBytes(this short, byte[], int, int, Endian) Method

Stores a set of bytes starting at the specified byte offset and returns the modified value.

```csharp
public static short StoreBytes(this short number, byte[] bytes, int offset, int size=-1, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,byte[],int,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to modify.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,byte[],int,int,Jcd.BitManipulation.Endian).bytes'></a>

`bytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,byte[],int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,byte[],int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store. -1 means all bytes.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBytes(thisshort,byte[],int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The modified value.