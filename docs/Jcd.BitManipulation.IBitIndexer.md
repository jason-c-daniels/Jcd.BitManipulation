### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## IBitIndexer Interface

The basic interface for indexing bits within an integer data type.

```csharp
public interface IBitIndexer :
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Derived
&#8627; [BitIndexerByte](Jcd.BitManipulation.BitIndexerByte.md 'Jcd.BitManipulation.BitIndexerByte')
&#8627; [BitIndexerInt16](Jcd.BitManipulation.BitIndexerInt16.md 'Jcd.BitManipulation.BitIndexerInt16')
&#8627; [BitIndexerInt32](Jcd.BitManipulation.BitIndexerInt32.md 'Jcd.BitManipulation.BitIndexerInt32')
&#8627; [BitIndexerInt64](Jcd.BitManipulation.BitIndexerInt64.md 'Jcd.BitManipulation.BitIndexerInt64')
&#8627; [BitIndexerSByte](Jcd.BitManipulation.BitIndexerSByte.md 'Jcd.BitManipulation.BitIndexerSByte')
&#8627; [BitIndexerUInt16](Jcd.BitManipulation.BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexerUInt16')
&#8627; [BitIndexerUInt32](Jcd.BitManipulation.BitIndexerUInt32.md 'Jcd.BitManipulation.BitIndexerUInt32')
&#8627; [BitIndexerUInt64](Jcd.BitManipulation.BitIndexerUInt64.md 'Jcd.BitManipulation.BitIndexerUInt64')

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Properties                                                                                            |                                |
|:------------------------------------------------------------------------------------------------------|:-------------------------------|
| [Length](Jcd.BitManipulation.IBitIndexer.Length.md 'Jcd.BitManipulation.IBitIndexer.Length')          | The number of addressable bits |
| [this[int]](Jcd.BitManipulation.IBitIndexer.this[int].md 'Jcd.BitManipulation.IBitIndexer.this[int]') | Gets or sets a bit             |

| Methods                                                                                                                |                                             |
|:-----------------------------------------------------------------------------------------------------------------------|:--------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.IBitIndexer.Slice(int,int).md 'Jcd.BitManipulation.IBitIndexer.Slice(int, int)') | Gets a slice of bits from the backing store |
| [ToString()](Jcd.BitManipulation.IBitIndexer.ToString().md 'Jcd.BitManipulation.IBitIndexer.ToString()')               | Format as a bit representation              |
