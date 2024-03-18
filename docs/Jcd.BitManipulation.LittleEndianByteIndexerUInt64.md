### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## LittleEndianByteIndexerUInt64 Struct

Provides byte level indexing operations (set, get) on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerUInt64 :
Jcd.BitManipulation.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerUInt64(ulong)](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.LittleEndianByteIndexerUInt64(ulong).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.LittleEndianByteIndexerUInt64(ulong)') | Constructs a [LittleEndianByteIndexerUInt64](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.ByteSize.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.MaxByteIndex.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.MaxByteIndex') | The largest byte index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.Data.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.Data') | The backing store. |
| [Length](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.Length.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.Length') | The length of the indexer. |
| [this[int]](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.this[int].md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.Slice(int,int).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator LittleEndianByteIndexerUInt64(ulong)](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexerUInt64(ulong).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexerUInt64(ulong)') | Converts the underlying data type to the indexer type. |
| [implicit operator ulong(LittleEndianByteIndexerUInt64)](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.op_Implicitulong(Jcd.BitManipulation.LittleEndianByteIndexerUInt64).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64.op_Implicit ulong(Jcd.BitManipulation.LittleEndianByteIndexerUInt64)') | Converts the byte indexer to its underlying data type. |
