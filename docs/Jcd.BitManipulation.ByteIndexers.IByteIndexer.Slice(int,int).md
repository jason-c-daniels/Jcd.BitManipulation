#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer')

## IByteIndexer.Slice(int, int) Method

Gets a slice of bytes from the backing store

```csharp
byte[] Slice(int start, int length);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

starting offset of the bits to retrieve

<a name='Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to get

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
Array of bits extracted