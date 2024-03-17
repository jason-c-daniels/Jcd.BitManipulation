#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerInt32 Struct

Provides byte level indexing operations (set, get) on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerInt32 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerInt32(int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.LittleEndianByteIndexerInt32(int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.LittleEndianByteIndexerInt32(int)') | Constructs a [LittleEndianByteIndexerInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32') from an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.MaxByteIndex') | The largest byte index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator int(LittleEndianByteIndexerInt32)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.op_Implicitint(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.op_Implicit int(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32)') | Converts the byte indexer to its underlying data type. |
| [implicit operator LittleEndianByteIndexerInt32(int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32(int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32(int)') | Converts the underlying data type to the buffer type. |
