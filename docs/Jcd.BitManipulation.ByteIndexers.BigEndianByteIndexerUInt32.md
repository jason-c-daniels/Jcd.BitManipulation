#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexerUInt32 Struct

Provides byte level indexing operations (set, get) on
a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). Zero is the most
significant byte.

```csharp
public struct BigEndianByteIndexerUInt32 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                                       |                                                                                                                                                                                                                                                                            |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexerUInt32(uint)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.BigEndianByteIndexerUInt32(uint).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.BigEndianByteIndexerUInt32(uint)') | Constructs a [BigEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32') from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). |

| Fields                                                                                                                                                                 |                                          |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.ByteSize')             | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.MaxByteIndex') | The largest byte index available.        |

| Properties                                                                                                                                                    |                                        |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.Data')                | The backing store.                     |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.Length')          | The length of the indexer.             |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.this[int]') | Access bytes from the underlying data. |

| Methods                                                                                                                                                                        |                                                           |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                                                     |                                                        |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator BigEndianByteIndexerUInt32(uint)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32(uint).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32(uint)') | Converts the underlying data type to the indexer type. |
| [implicit operator uint(BigEndianByteIndexerUInt32)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.op_Implicituint(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.op_Implicit uint(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32)') | Converts the byte indexer to its underlying data type. |
