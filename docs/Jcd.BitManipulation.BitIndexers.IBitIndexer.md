#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## IBitIndexer Interface

The basic interface for indexing bits within an integer data type.

```csharp
public interface IBitIndexer :
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Derived
&#8627; [BitIndexerDouble](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble')
&#8627; [BitIndexerInt16](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16')
&#8627; [BitIndexerInt32](Jcd.BitManipulation.BitIndexers.BitIndexerInt32.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt32')
&#8627; [BitIndexerInt64](Jcd.BitManipulation.BitIndexers.BitIndexerInt64.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt64')
&#8627; [BitIndexerSByte](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte')
&#8627; [BitIndexerSingle](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle')
&#8627; [BitIndexerUInt16](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16')
&#8627; [BitIndexerUInt32](Jcd.BitManipulation.BitIndexers.BitIndexerUInt32.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt32')
&#8627; [BitIndexerUInt64](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Properties | |
| :--- | :--- |
| [Length](Jcd.BitManipulation.BitIndexers.IBitIndexer.Length.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer.Length') | The number of addressable bits |
| [this[int]](Jcd.BitManipulation.BitIndexers.IBitIndexer.this[int].md 'Jcd.BitManipulation.BitIndexers.IBitIndexer.this[int]') | Gets or sets a bit |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.IBitIndexer.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.IBitIndexer.Slice(int, int)') | Gets a slice of bits from the backing store |
| [ToString()](Jcd.BitManipulation.BitIndexers.IBitIndexer.ToString().md 'Jcd.BitManipulation.BitIndexers.IBitIndexer.ToString()') | Format as a bit representation |
