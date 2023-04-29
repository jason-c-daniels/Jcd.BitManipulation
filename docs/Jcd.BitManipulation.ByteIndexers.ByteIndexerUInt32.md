#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerUInt32 Struct

Provides byte level indexing operations (set, get) on a UInt32. Zero is the least significant byte.

```csharp
public struct ByteIndexerUInt32 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerUInt32(uint)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.ByteIndexerUInt32(uint).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.ByteIndexerUInt32(uint)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator ByteIndexerUInt32(uint)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerUInt32(uint).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32(uint)') | Converts the underlying data type to the buffer type. |
| [implicit operator uint(ByteIndexerUInt32)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.op_Implicituint(Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.op_Implicit uint(Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32)') | Converts the byte indexer to its underlying data type. |
