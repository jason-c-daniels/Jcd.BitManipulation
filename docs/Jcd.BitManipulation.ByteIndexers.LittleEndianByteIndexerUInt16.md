#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerUInt16 Struct

Provides byte level indexing operations (set, get) on a UInt16. Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerUInt16 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.LittleEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.LittleEndianByteIndexerUInt16(ushort)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.MaxByteIndex') | The largest byte index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator LittleEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16(ushort)') | Converts the underlying data type to the buffer type. |
| [implicit operator ushort(LittleEndianByteIndexerUInt16)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16)') | Converts the byte indexer to its underlying data type. |
