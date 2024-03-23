#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerUInt16 Struct

Provides enumeration and indexed access to the bits on a stored [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').

```csharp
public struct BitIndexerUInt16 :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.Length') | The number of bits indexable by this indexer. |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerUInt16(ushort)](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerUInt16(ushort).md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerUInt16(ushort)') | Automatically Convert from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to a [BitIndexerUInt16](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16') |
| [implicit operator ushort(BitIndexerUInt16)](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.BitIndexers.BitIndexerUInt16).md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.BitIndexers.BitIndexerUInt16)') | Automatically convert from a BitIndexerUInt16 to a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt16.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
