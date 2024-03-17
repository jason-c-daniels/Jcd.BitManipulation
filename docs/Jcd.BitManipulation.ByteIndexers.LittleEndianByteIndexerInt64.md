﻿#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## LittleEndianByteIndexerInt64 Struct

Provides byte level indexing operations (set, get) on
a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). Zero is the least significant
byte.

```csharp
public struct LittleEndianByteIndexerInt64 :
Jcd.BitManipulation.ByteIndexers.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.ByteIndexers.IByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [LittleEndianByteIndexerInt64(long)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.LittleEndianByteIndexerInt64(long).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.LittleEndianByteIndexerInt64(long)') | Constructs a [LittleEndianByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64') from an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |

| Fields                                                                                                                                                                     |                                          |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------|
| [ByteSize](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.ByteSize.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.ByteSize')             | The number of bytes this type will index |
| [MaxByteIndex](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.MaxByteIndex.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.MaxByteIndex') | The largest byte index available.        |

| Properties                                                                                                                                                        |                                        |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------|
| [Data](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.Data.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.Data')                | The backing store.                     |
| [Length](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.Length.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.Length')          | The length of the buffer.              |
| [this[int]](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.this[int].md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.this[int]') | Access bytes from the underlying data. |

| Methods                                                                                                                                                                            |                                                           |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                                                               |                                                        |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [implicit operator LittleEndianByteIndexerInt64(long)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.op_ImplicitJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64(long).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.op_Implicit Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64(long)') | Converts the underlying data type to the buffer type.  |
| [implicit operator long(LittleEndianByteIndexerInt64)](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.op_Implicitlong(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64).md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.op_Implicit long(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64)') | Converts the byte indexer to its underlying data type. |