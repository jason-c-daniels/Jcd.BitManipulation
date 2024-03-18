### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[LittleEndianByteIndexerUInt16](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16')

## LittleEndianByteIndexerUInt16.this[int] Property

Access bytes from the underlying data.

```csharp
public byte this[int index] { get; set; }
```
#### Parameters

<a name='Jcd.BitManipulation.LittleEndianByteIndexerUInt16.this[int].index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index of the byte to get or set.

Implements [this[int]](Jcd.BitManipulation.IByteIndexer.this[int].md 'Jcd.BitManipulation.IByteIndexer.this[int]')

#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
When index < 0 or gt;= Length