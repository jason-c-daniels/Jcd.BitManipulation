#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerInt16 Struct

Provides byte level indexing operations (set, get) on a Int16. Zero is the least significant byte.

```csharp
public struct ByteIndexerInt16 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerInt16(short)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.ByteIndexerInt16(short).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.ByteIndexerInt16(short)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator ByteIndexerInt16(short)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerInt16(short).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16(short)') | Converts the underlying data type to the buffer type. |
| [implicit operator short(ByteIndexerInt16)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.op_Implicitshort(Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.op_Implicit short(Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16)') | Converts the byte indexer to its underlying data type. |