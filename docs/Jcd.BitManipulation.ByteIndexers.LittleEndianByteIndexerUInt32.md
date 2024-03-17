#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerUInt32 Struct

Provides byte level indexing operations (set, get) on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerUInt32 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerUInt32(uint)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.LittleEndianByteIndexerUInt32(uint).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.LittleEndianByteIndexerUInt32(uint)') | Constructs a [LittleEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32') from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.MaxByteIndex') | The largest byte index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator LittleEndianByteIndexerUInt32(uint)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32(uint).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32(uint)') | Converts the underlying data type to the buffer type. |
| [implicit operator uint(LittleEndianByteIndexerUInt32)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.op_Implicituint(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.op_Implicit uint(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32)') | Converts the byte indexer to its underlying data type. |
