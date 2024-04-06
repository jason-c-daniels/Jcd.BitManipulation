#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions.md 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.StoreBytes(this ulong, ReadOnlySpan<byte>, int, int, Endian) Method

Stores a set of bytes starting at the specified byte offset and returns the modified value.

```csharp
public static ulong StoreBytes(this ulong number, System.ReadOnlySpan<byte> bytes, int offset, int size=-1, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to modify.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).bytes'></a>

`bytes` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store. -1 means all bytes.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBytes(thisulong,System.ReadOnlySpan_byte_,int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.