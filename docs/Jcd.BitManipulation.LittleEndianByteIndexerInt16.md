### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## LittleEndianByteIndexerInt16 Struct

Provides byte level indexing operations (set, get) on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerInt16 :
Jcd.BitManipulation.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerInt16(short)](Jcd.BitManipulation.LittleEndianByteIndexerInt16.LittleEndianByteIndexerInt16(short).md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.LittleEndianByteIndexerInt16(short)') | Constructs a [LittleEndianByteIndexerInt16](Jcd.BitManipulation.LittleEndianByteIndexerInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16') from an [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |

| Fields                                                                                                                                           |                                                                                                                   |
|:-------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.LittleEndianByteIndexerInt16.ByteSize.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.LittleEndianByteIndexerInt16.MaxByteIndex.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.LittleEndianByteIndexerInt16.Data.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.LittleEndianByteIndexerInt16.Length.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.LittleEndianByteIndexerInt16.this[int].md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.LittleEndianByteIndexerInt16.Slice(int,int).md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                              |                                                                                                                                        |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator LittleEndianByteIndexerInt16(short)](Jcd.BitManipulation.LittleEndianByteIndexerInt16.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexerInt16(short).md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexerInt16(short)') | Converts the underlying data type to the buffer type.                                                                                  |
| [implicit operator short(LittleEndianByteIndexerInt16)](Jcd.BitManipulation.LittleEndianByteIndexerInt16.op_Implicitshort(Jcd.BitManipulation.LittleEndianByteIndexerInt16).md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16.op_Implicit short(Jcd.BitManipulation.LittleEndianByteIndexerInt16)') | Converts the [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') indexer to its underlying data type. |
