#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexerDouble Struct

Provides byte level indexing operations (set, get) on
a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). Zero is the most
significant byte.

```csharp
public struct BigEndianByteIndexerDouble :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                            |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexerDouble(double)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.BigEndianByteIndexerDouble(double).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.BigEndianByteIndexerDouble(double)') | Constructs a [BigEndianByteIndexerDouble](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble') from a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |

| Fields                                                                                                                                                                 |                                                                                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties                                                                                                                                                    |                                                |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.Data')                | The backing store.                             |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.Length')          | The number of bytes indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.this[int]') | Access bytes from the underlying data.         |

| Methods                                                                                                                                                                        |                                                           |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                                                           |                                                        |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator double(BigEndianByteIndexerDouble)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.op_Implicitdouble(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.op_Implicit double(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble)') | Converts the byte indexer to its underlying data type. |
| [implicit operator BigEndianByteIndexerDouble(double)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble(double).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerDouble(double)') | Converts the underlying data type to the indexer type. |
