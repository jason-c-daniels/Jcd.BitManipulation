#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[LittleEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32')

## LittleEndianByteIndexerUInt32.this[int] Property

Access bytes from the underlying data.

```csharp
public byte this[int index] { get; set; }
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.this[int].index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index of the byte to get or set. 0 is the least significant byte from the underlying storage.

Implements [this[int]](Jcd.BitManipulation.ByteIndexers.IByteIndexer.this[int].md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.this[int]')

#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
When index < 0 or gt;= Length