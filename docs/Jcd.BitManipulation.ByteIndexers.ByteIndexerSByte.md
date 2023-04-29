#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerSByte Struct

Provides byte level indexing operations (set, get) on a SByte. Zero is the least significant byte.  
This type was provided for completeness sake. It's really not that useful.

```csharp
public struct ByteIndexerSByte :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerSByte(sbyte)](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.ByteIndexerSByte(sbyte).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.ByteIndexerSByte(sbyte)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.Length') | The length of the data in bytes. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator ByteIndexerSByte(sbyte)](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerSByte(sbyte).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte(sbyte)') | Converts the underlying data type to the buffer type. |
| [implicit operator sbyte(ByteIndexerSByte)](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.op_Implicitsbyte(Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.op_Implicit sbyte(Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte)') | Converts the byte indexer to its underlying data type. |
