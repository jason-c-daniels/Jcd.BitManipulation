### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## LittleEndianByteIndexerUInt16 Struct

Provides byte level indexing operations (set, get) on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). Zero is the least significant byte.

```csharp
public struct LittleEndianByteIndexerUInt16 :
Jcd.BitManipulation.IByteIndexer,
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Implements [IByteIndexer](Jcd.BitManipulation.IByteIndexer.md 'Jcd.BitManipulation.IByteIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [LittleEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.LittleEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.LittleEndianByteIndexerUInt16(ushort)') | Constructs a [LittleEndianByteIndexerUInt16](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16') from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |

| Fields                                                                                                                                             |                                                                                                                   |
|:---------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------|
| [ByteSize](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.ByteSize.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.ByteSize')             | The number of bytes this type will index                                                                          |
| [MaxByteIndex](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.MaxByteIndex.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.MaxByteIndex') | The largest [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') index available. |

| Properties | |
| :--- | :--- |
| [Data](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.Data.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.Data') | The backing store. |
| [Length](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.Length.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.Length') | The length of the buffer. |
| [this[int]](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.this[int].md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |

| Operators                                                                                                                                                                                                                                                                                                      |                                                                                                                                        |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator LittleEndianByteIndexerUInt16(ushort)](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexerUInt16(ushort).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexerUInt16(ushort)') | Converts the underlying data type to the buffer type.                                                                                  |
| [implicit operator ushort(LittleEndianByteIndexerUInt16)](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.LittleEndianByteIndexerUInt16).md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.LittleEndianByteIndexerUInt16)') | Converts the [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') indexer to its underlying data type. |
