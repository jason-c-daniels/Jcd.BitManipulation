### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerInt64 Struct

Provides enumeration and indexed access to the bits on a stored [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').

```csharp
public struct BitIndexerInt64 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerInt64.BitSize.md 'Jcd.BitManipulation.BitIndexerInt64.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexerInt64.Bits.md 'Jcd.BitManipulation.BitIndexerInt64.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexerInt64.Length.md 'Jcd.BitManipulation.BitIndexerInt64.Length') | The number of bits indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.BitIndexerInt64.this[int].md 'Jcd.BitManipulation.BitIndexerInt64.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerInt64.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt64.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerInt64.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerInt64.Slice(int, int)') | Get an enumerator to enumerate the bits with. |
| [ToString()](Jcd.BitManipulation.BitIndexerInt64.ToString().md 'Jcd.BitManipulation.BitIndexerInt64.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerInt64(long)](Jcd.BitManipulation.BitIndexerInt64.op_ImplicitJcd.BitManipulation.BitIndexerInt64(long).md 'Jcd.BitManipulation.BitIndexerInt64.op_Implicit Jcd.BitManipulation.BitIndexerInt64(long)') | Automatically Convert from a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to a BitIndexerInt64 |
| [implicit operator long(BitIndexerInt64)](Jcd.BitManipulation.BitIndexerInt64.op_Implicitlong(Jcd.BitManipulation.BitIndexerInt64).md 'Jcd.BitManipulation.BitIndexerInt64.op_Implicit long(Jcd.BitManipulation.BitIndexerInt64)') | Automatically convert from a BitIndexerInt64 to a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerInt64.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt64.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
