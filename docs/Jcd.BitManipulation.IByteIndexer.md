### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## IByteIndexer Interface

The basic interface for indexing bytes within an integral data type.

```csharp
public interface IByteIndexer :
System.Collections.Generic.IEnumerable<byte>,
System.Collections.IEnumerable
```

Derived
&#8627; [BigEndianByteIndexerInt16](Jcd.BitManipulation.BigEndianByteIndexerInt16.md 'Jcd.BitManipulation.BigEndianByteIndexerInt16')
&#8627; [BigEndianByteIndexerInt32](Jcd.BitManipulation.BigEndianByteIndexerInt32.md 'Jcd.BitManipulation.BigEndianByteIndexerInt32')
&#8627; [BigEndianByteIndexerInt64](Jcd.BitManipulation.BigEndianByteIndexerInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64')
&#8627; [BigEndianByteIndexerUInt16](Jcd.BitManipulation.BigEndianByteIndexerUInt16.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt16')
&#8627; [BigEndianByteIndexerUInt32](Jcd.BitManipulation.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt32')
&#8627; [BigEndianByteIndexerUInt64](Jcd.BitManipulation.BigEndianByteIndexerUInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt64')
&#8627; [LittleEndianByteIndexerInt16](Jcd.BitManipulation.LittleEndianByteIndexerInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt16')
&#8627; [LittleEndianByteIndexerInt32](Jcd.BitManipulation.LittleEndianByteIndexerInt32.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt32')
&#8627; [LittleEndianByteIndexerInt64](Jcd.BitManipulation.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt64')
&#8627; [LittleEndianByteIndexerUInt16](Jcd.BitManipulation.LittleEndianByteIndexerUInt16.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt16')
&#8627; [LittleEndianByteIndexerUInt32](Jcd.BitManipulation.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt32')
&#8627; [LittleEndianByteIndexerUInt64](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Properties | |
| :--- | :--- |
| [Length](Jcd.BitManipulation.IByteIndexer.Length.md 'Jcd.BitManipulation.IByteIndexer.Length') | The number of addressable bytes. |
| [this[int]](Jcd.BitManipulation.IByteIndexer.this[int].md 'Jcd.BitManipulation.IByteIndexer.this[int]') | Gets or sets a bit |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.IByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.IByteIndexer.Slice(int, int)') | Gets a slice of bytes from the backing store |
