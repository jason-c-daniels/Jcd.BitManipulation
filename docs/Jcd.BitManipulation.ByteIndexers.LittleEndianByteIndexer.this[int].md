#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[LittleEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer')

## LittleEndianByteIndexer.this[int] Property

Access bytes from the underlying data.

```csharp
public byte this[int index] { get; set; }
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.this[int].index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index of the byte to get or set.

#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
When index < 0 or gt;= Length