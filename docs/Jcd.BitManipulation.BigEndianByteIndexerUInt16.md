### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BigEndianByteIndexerUInt16 Struct

Provides byte level indexing operations (set, get) on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). Zero is the most significant byte.

```csharp
public struct BigEndianByteIndexerUInt16 :
Jcd.BitManipulation.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [BigEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.BigEndianByteIndexerUInt16.BigEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.BigEndianByteIndexerUInt16(ushort)') | Constructs a [BigEndianByteIndexerUInt16](Jcd.BitManipulation.BigEndianByteIndexerUInt16.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16') from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |

| Fields                                                                                                                                       |                                                                                                                   |
|:---------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.BigEndianByteIndexerUInt16.ByteSize.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.BigEndianByteIndexerUInt16.MaxByteIndex.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.BigEndianByteIndexerUInt16.Data.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.BigEndianByteIndexerUInt16.Length.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.Length') | The length of the indexer. |
| [this[int]](Jcd.BitManipulation.BigEndianByteIndexerUInt16.this[int].md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.BigEndianByteIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators | |
| :--- | :--- |
| [implicit operator BigEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.BigEndianByteIndexerUInt16.op_ImplicitJcd.BitManipulation.BigEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.op_Implicit Jcd.BitManipulation.BigEndianByteIndexerUInt16(ushort)') | Converts the underlying data type to the indexer type. |
| [implicit operator ushort(BigEndianByteIndexerUInt16)](Jcd.BitManipulation.BigEndianByteIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.BigEndianByteIndexerUInt16).md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.BigEndianByteIndexerUInt16)') | Converts the byte indexer to its underlying data type. |
