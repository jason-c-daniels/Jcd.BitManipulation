#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerUInt64 Struct

Provides byte level indexing operations (set, get) on a UInt64. Zero is the least significant byte.

```csharp
public struct ByteIndexerUInt64 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerUInt64(ulong)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.ByteIndexerUInt64(ulong).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.ByteIndexerUInt64(ulong)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.Length') | The length of the indexer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator ByteIndexerUInt64(ulong)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerUInt64(ulong).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64(ulong)') | Converts the underlying data type to the indexer type. |
| [implicit operator ulong(ByteIndexerUInt64)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.op_Implicitulong(Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.op_Implicit ulong(Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64)') | Converts the byte indexer to its underlying data type. |
