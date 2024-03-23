#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexerUInt16 Struct

Provides byte level indexing operations (set, get) on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). Zero is the most significant byte.

```csharp
public struct BigEndianByteIndexerUInt16 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [BigEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.BigEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.BigEndianByteIndexerUInt16(ushort)') | Constructs a [BigEndianByteIndexerUInt16](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16') from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.Length') | The number of bytes indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator BigEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16(ushort)') | Converts the underlying data type to the indexer type. |
| [implicit operator ushort(BigEndianByteIndexerUInt16)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16)') | Converts the byte indexer to its underlying data type. |
