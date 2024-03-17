#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## BigEndianByteIndexerInt32 Struct

Provides byte level indexing operations (set, get) on
a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). Zero is the most significant
byte.

```csharp
public struct BigEndianByteIndexerInt32 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                               |                                                                                                                                                                                                                                                                       |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexerInt32(int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.BigEndianByteIndexerInt32(int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.BigEndianByteIndexerInt32(int)') | Constructs a [BigEndianByteIndexerInt32](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32') from an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |

| Fields                                                                                                                                                               |                                          |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.ByteSize')             | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.MaxByteIndex') | The largest byte index available.        |

| Properties                                                                                                                                                  |                                        |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.Data.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.Data')                | The backing store.                     |
| [Length](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.Length.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.Length')          | The length of the indexer.             |
| [this[int]](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.this[int].md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.this[int]') | Access bytes from the underlying data. |

| Methods                                                                                                                                                                      |                                                           |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                                             |                                                        |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator int(BigEndianByteIndexerInt32)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.op_Implicitint(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.op_Implicit int(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32)') | Converts the byte indexer to its underlying data type. |
| [implicit operator BigEndianByteIndexerInt32(int)](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.op_ImplicitJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32(int).md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.op_Implicit Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32(int)') | Converts the underlying data type to the indexer type. |
