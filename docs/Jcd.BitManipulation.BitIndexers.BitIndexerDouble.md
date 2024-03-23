#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerDouble Struct

Provides enumeration and indexed access to the bits on a stored [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public struct BitIndexerDouble :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.Length') | The number of bits indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator double(BitIndexerDouble)](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.op_Implicitdouble(Jcd.BitManipulation.BitIndexers.BitIndexerDouble).md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.op_Implicit double(Jcd.BitManipulation.BitIndexers.BitIndexerDouble)') | Automatically convert from a [BitIndexerDouble](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble') to a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') |
| [implicit operator BitIndexerDouble(double)](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerDouble(double).md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerDouble(double)') | Automatically Convert from a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to a [BitIndexerDouble](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerDouble.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerDouble.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
