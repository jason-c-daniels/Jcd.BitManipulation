#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexerInt64 Struct

Provides byte level indexing operations (set, get) on an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). Zero is the most significant byte.

```csharp
public struct BigEndianByteIndexerInt64 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [BigEndianByteIndexerInt64(long)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.BigEndianByteIndexerInt64(long).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.BigEndianByteIndexerInt64(long)') | Constructs a [BigEndianByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64') from an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |

| Fields                                                                                                                                                               |                                                                                                                   |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties                                                                                                                                                  |                                                |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.Data')                | The backing store.                             |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.Length')          | The number of bytes indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.this[int]') | Access bytes from the underlying data.         |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator BigEndianByteIndexerInt64(long)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64(long).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64(long)') | Converts the underlying data type to the indexer type. |
| [implicit operator long(BigEndianByteIndexerInt64)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.op_Implicitlong(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.op_Implicit long(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64)') | Converts the byte indexer to its underlying data type. |
