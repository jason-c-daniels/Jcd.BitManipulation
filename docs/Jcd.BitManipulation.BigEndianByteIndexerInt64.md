### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BigEndianByteIndexerInt64 Struct

Provides byte level indexing operations (set, get) on
an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). Zero is the most significant
byte.

```csharp
public struct BigEndianByteIndexerInt64 :
Jcd.BitManipulation.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                        |                                                                                                                                                                                                                                             |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexerInt64(long)](Jcd.BitManipulation.BigEndianByteIndexerInt64.BigEndianByteIndexerInt64(long).md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.BigEndianByteIndexerInt64(long)') | Constructs a [BigEndianByteIndexerInt64](Jcd.BitManipulation.BigEndianByteIndexerInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64') from an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |

| Fields                                                                                                                                     |                                          |
|:-------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------|
| [ByteSize](Jcd.BitManipulation.BigEndianByteIndexerInt64.ByteSize.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.ByteSize')             | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.BigEndianByteIndexerInt64.MaxByteIndex.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.MaxByteIndex') | The largest byte index available.        |

| Properties                                                                                                                        |                                        |
|:----------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------|
| [Data](Jcd.BitManipulation.BigEndianByteIndexerInt64.Data.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.Data')                | The backing store.                     |
| [Length](Jcd.BitManipulation.BigEndianByteIndexerInt64.Length.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.Length')          | The length of the indexer.             |
| [this[int]](Jcd.BitManipulation.BigEndianByteIndexerInt64.this[int].md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.this[int]') | Access bytes from the underlying data. |

| Methods                                                                                                                                            |                                                           |
|:---------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.BigEndianByteIndexerInt64.Slice(int,int).md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                            |                                                        |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator BigEndianByteIndexerInt64(long)](Jcd.BitManipulation.BigEndianByteIndexerInt64.op_ImplicitJcd.BitManipulation.BigEndianByteIndexerInt64(long).md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.op_Implicit Jcd.BitManipulation.BigEndianByteIndexerInt64(long)') | Converts the underlying data type to the indexer type. |
| [implicit operator long(BigEndianByteIndexerInt64)](Jcd.BitManipulation.BigEndianByteIndexerInt64.op_Implicitlong(Jcd.BitManipulation.BigEndianByteIndexerInt64).md 'Jcd.BitManipulation.BigEndianByteIndexerInt64.op_Implicit long(Jcd.BitManipulation.BigEndianByteIndexerInt64)') | Converts the byte indexer to its underlying data type. |
