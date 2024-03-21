#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexerSingle Struct

Provides byte level indexing operations (set, get) on
a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'). Zero is the most
significant byte.

```csharp
public struct BigEndianByteIndexerSingle :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                            |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexerSingle(float)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.BigEndianByteIndexerSingle(float).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.BigEndianByteIndexerSingle(float)') | Constructs a [BigEndianByteIndexerSingle](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle') from a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'). |

| Fields                                                                                                                                                                 |                                                                                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties                                                                                                                                                    |                                                |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.Data')                | The backing store.                             |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.Length')          | The number of bytes indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.this[int]') | Access bytes from the underlying data.         |

| Methods                                                                                                                                                                        |                                                           |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                                                        |                                                        |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator float(BigEndianByteIndexerSingle)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.op_Implicitfloat(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.op_Implicit float(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle)') | Converts the byte indexer to its underlying data type. |
| [implicit operator BigEndianByteIndexerSingle(float)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle(float).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerSingle(float)') | Converts the underlying data type to the indexer type. |
