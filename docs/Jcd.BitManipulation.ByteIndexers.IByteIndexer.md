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
&#8627; [ByteIndexerByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerByte')  
&#8627; [ByteIndexerInt16](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16')  
&#8627; [ByteIndexerInt32](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt32')  
&#8627; [ByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt64')  
&#8627; [ByteIndexerSByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte')  
&#8627; [ByteIndexerUInt16](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt16')  
&#8627; [ByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt32')  
&#8627; [ByteIndexerUInt64](Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerUInt64')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Properties | |
| :--- | :--- |
| [Length](Jcd.BitManipulation.ByteIndexers.IByteIndexer.Length.md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.Length') | The number of addressable bytes. |
| [this[int]](Jcd.BitManipulation.ByteIndexers.IByteIndexer.this[int].md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.this[int]') | Gets or sets a bit |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int, int)') | Gets a slice of bytes from the backing store |
