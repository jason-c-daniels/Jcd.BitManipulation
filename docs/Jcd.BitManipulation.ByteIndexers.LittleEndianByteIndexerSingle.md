#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerSingle Struct

Provides byte level indexing operations (set, get) on a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerSingle :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerSingle(float)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.LittleEndianByteIndexerSingle(float).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.LittleEndianByteIndexerSingle(float)') | Constructs a [LittleEndianByteIndexerSingle](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle') from a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'). |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.ByteSize') | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator float(LittleEndianByteIndexerSingle)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.op_Implicitfloat(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.op_Implicit float(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle)') | Converts the [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') indexer to its underlying data type. |
| [implicit operator LittleEndianByteIndexerSingle(float)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle(float).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle(float)') | Converts the underlying data type to the buffer type. |
