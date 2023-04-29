#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerInt32 Struct

Provides byte level indexing operations (set, get) on a Int32. Zero is the least significant byte.

```csharp
public struct ByteIndexerInt32 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerInt32(int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.ByteIndexerInt32(int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.ByteIndexerInt32(int)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator int(ByteIndexerInt32)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.op_Implicitint(Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.op_Implicit int(Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32)') | Converts the byte indexer to its underlying data type. |
| [implicit operator ByteIndexerInt32(int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerInt32(int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32(int)') | Converts the underlying data type to the buffer type. |
