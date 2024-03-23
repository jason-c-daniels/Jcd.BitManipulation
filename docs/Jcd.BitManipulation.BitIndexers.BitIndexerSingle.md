#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerSingle Struct

Provides enumeration and indexed access to the bits on a stored [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public struct BitIndexerSingle :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.Length') | The number of bits indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator float(BitIndexerSingle)](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.op_Implicitfloat(Jcd.BitManipulation.BitIndexers.BitIndexerSingle).md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.op_Implicit float(Jcd.BitManipulation.BitIndexers.BitIndexerSingle)') | Automatically convert from a [BitIndexerSingle](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle') to a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') |
| [implicit operator BitIndexerSingle(float)](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerSingle(float).md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerSingle(float)') | Automatically Convert from a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') to a [BitIndexerSingle](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerSingle.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerSingle.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
