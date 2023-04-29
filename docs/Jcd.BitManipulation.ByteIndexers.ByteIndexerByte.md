#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## ByteIndexerByte Struct

Provides byte level indexing operations (set, get) on a Byte. Zero is the least significant byte.  
This type was provided for completeness sake. It's really not that useful.

```csharp
public struct ByteIndexerByte :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [ByteIndexerByte(byte)](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.ByteIndexerByte(byte).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.ByteIndexerByte(byte)') | Constructs a byte indexer from the underlying data type. |

| Fields | |
| :--- | :--- |
| [ByteSize](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.ByteSize') | The number of bytes this type will index |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.Data.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.Data') | The backing store. |
| [Length](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.Length.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.Length') | The length of the data in bytes. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.this[int].md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator byte(ByteIndexerByte)](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.op_Implicitbyte(Jcd.BitManipulation.ByteIndexers.ByteIndexerByte).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.op_Implicit byte(Jcd.BitManipulation.ByteIndexers.ByteIndexerByte)') | Converts the byte indexer to its underlying data type. |
| [implicit operator ByteIndexerByte(byte)](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.op_ImplicitJcd.BitManipulation.ByteIndexers.ByteIndexerByte(byte).md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.op_Implicit Jcd.BitManipulation.ByteIndexers.ByteIndexerByte(byte)') | Converts the underlying data type to the buffer type. |
