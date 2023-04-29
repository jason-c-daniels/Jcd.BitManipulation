#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerUInt16 Struct

Provides byte level indexing operations (set, get) on a UInt16. Zero is the least significant byte.

```csharp
public struct ByteIndexerUInt16 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerUInt16(ushort)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.ByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.ByteIndexerUInt16(ushort)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator ByteIndexerUInt16(ushort)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16(ushort)') | Converts the underlying data type to the buffer type. |
| [implicit operator ushort(ByteIndexerUInt16)](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16)') | Converts the byte indexer to its underlying data type. |
