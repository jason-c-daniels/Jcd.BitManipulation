### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BigEndianByteIndexerUInt64 Struct

Provides byte level indexing operations (set, get) on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). Zero is the most significant byte.

```csharp
public struct BigEndianByteIndexerUInt64 :
Jcd.BitManipulation.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [BigEndianByteIndexerUInt64(ulong)](Jcd.BitManipulation.BigEndianByteIndexerUInt64.BigEndianByteIndexerUInt64(ulong).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.BigEndianByteIndexerUInt64(ulong)') | Constructs a [BigEndianByteIndexerUInt64](Jcd.BitManipulation.BigEndianByteIndexerUInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.BigEndianByteIndexerUInt64.ByteSize.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.BigEndianByteIndexerUInt64.MaxByteIndex.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.BigEndianByteIndexerUInt64.Data.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.Data') | The backing store. |
| [Length](Jcd.BitManipulation.BigEndianByteIndexerUInt64.Length.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.Length') | The number of bytes indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.BigEndianByteIndexerUInt64.this[int].md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.BigEndianByteIndexerUInt64.Slice(int,int).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator BigEndianByteIndexerUInt64(ulong)](Jcd.BitManipulation.BigEndianByteIndexerUInt64.op_ImplicitJcd.BitManipulation.BigEndianByteIndexerUInt64(ulong).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.op_Implicit Jcd.BitManipulation.BigEndianByteIndexerUInt64(ulong)') | Converts the underlying data type to the indexer type. |
| [implicit operator ulong(BigEndianByteIndexerUInt64)](Jcd.BitManipulation.BigEndianByteIndexerUInt64.op_Implicitulong(Jcd.BitManipulation.BigEndianByteIndexerUInt64).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64.op_Implicit ulong(Jcd.BitManipulation.BigEndianByteIndexerUInt64)') | Converts the byte indexer to its underlying data type. |
