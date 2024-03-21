#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerDouble Struct

Provides byte level indexing operations (set, get) on
a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). Zero is the least
significant byte.

```csharp
public struct LittleEndianByteIndexerDouble :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                                                     |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [LittleEndianByteIndexerDouble(double)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.LittleEndianByteIndexerDouble(double).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.LittleEndianByteIndexerDouble(double)') | Constructs a [LittleEndianByteIndexerDouble](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble') from a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |

| Fields                                                                                                                                                                       |                                                                                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties                                                                                                                                                          |                                                |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.Data')                | The backing store.                             |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.Length')          | The number of bytes indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.this[int]') | Access bytes from the underlying data.         |

| Methods                                                                                                                                                                              |                                                           |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                                                                          |                                                                                                                                        |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator double(LittleEndianByteIndexerDouble)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.op_Implicitdouble(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.op_Implicit double(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble)') | Converts the [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') indexer to its underlying data type. |
| [implicit operator LittleEndianByteIndexerDouble(double)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble(double).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerDouble(double)') | Converts the underlying data type to the indexer type.                                                                                 |
