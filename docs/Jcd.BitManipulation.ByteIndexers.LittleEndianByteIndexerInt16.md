#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerInt16 Struct

Provides byte level indexing operations (set, get) on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerInt16 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerInt16(short)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.LittleEndianByteIndexerInt16(short).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.LittleEndianByteIndexerInt16(short)') | Constructs a [LittleEndianByteIndexerInt16](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16') from an [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.MaxByteIndex') | The largest byte index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator LittleEndianByteIndexerInt16(short)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16(short).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16(short)') | Converts the underlying data type to the buffer type. |
| [implicit operator short(LittleEndianByteIndexerInt16)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.op_Implicitshort(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.op_Implicit short(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16)') | Converts the byte indexer to its underlying data type. |
