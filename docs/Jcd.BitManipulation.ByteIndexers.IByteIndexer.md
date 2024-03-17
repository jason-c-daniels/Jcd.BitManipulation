#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers')

## IByteIndexer Interface

The basic interface for indexing bits within an integer data type.

```csharp
public interface IByteIndexer :
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Derived
&#8627; [BigEndianByteIndexerInt16](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt16.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt16')
&#8627; [BigEndianByteIndexerInt32](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt32')
&#8627; [BigEndianByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerInt64')
&#8627; [BigEndianByteIndexerUInt16](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt16')
&#8627; [BigEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32')
&#8627; [BigEndianByteIndexerUInt64](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt64.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt64')
&#8627; [LittleEndianByteIndexerInt16](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt16')
&#8627; [LittleEndianByteIndexerInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt32')
&#8627; [LittleEndianByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64')
&#8627; [LittleEndianByteIndexerUInt16](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt16')
&#8627; [LittleEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32')
&#8627; [LittleEndianByteIndexerUInt64](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt64.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt64')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Properties | |
| :--- | :--- |
| [Length](Jcd.BitManipulation.ByteIndexers.IByteIndexer.Length.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.Length') | The number of addressable bytes. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.IByteIndexer.this[int].md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.this[int]') | Gets or sets a bit |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int, int)') | Gets a slice of bytes from the backing store |
