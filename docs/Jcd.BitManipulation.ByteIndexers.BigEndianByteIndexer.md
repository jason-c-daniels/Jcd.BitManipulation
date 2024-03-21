#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexer Struct

Provides byte level indexing operations (set, get) on
a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). Zero is the most
significant byte.

```csharp
public struct BigEndianByteIndexer :
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                          |                                                                                                                                                                                                                                                          |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexer(ulong, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.BigEndianByteIndexer(ulong,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.BigEndianByteIndexer(ulong, int)') | Constructs a [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [BigEndianByteIndexer(ulong)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.BigEndianByteIndexer(ulong).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.BigEndianByteIndexer(ulong)')               | Constructs a [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |

| Properties                                                                                                                                                 |                                                                                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.ByteSize')             | The number of bytes this type will index                                                                          |
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.Data')                         | The backing store.                                                                                                |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.Length')                   | The number of bytes indexable by this indexer.                                                                    |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.this[int]')          | Access bytes from the underlying data.                                                                            |

| Methods                                                                                                                                                            |                                                           |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                             |                                                        |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator byte[](BigEndianByteIndexer)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicitbyte[](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicit byte[](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer)') | Converts the byte indexer to its underlying data type. |
| [implicit operator double(BigEndianByteIndexer)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicitdouble(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicit double(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer)') | Converts the byte indexer to its underlying data type. |
| [implicit operator float(BigEndianByteIndexer)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicitfloat(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicit float(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer)')    | Converts the byte indexer to its underlying data type. |
| [implicit operator BigEndianByteIndexer(ulong)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexer(ulong).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer(ulong)')    | Converts the underlying data type to the indexer type. |
| [implicit operator ulong(BigEndianByteIndexer)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicitulong(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicit ulong(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer)')    | Converts the byte indexer to its underlying data type. |
