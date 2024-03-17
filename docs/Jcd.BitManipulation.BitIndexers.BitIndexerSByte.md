#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerSByte Struct

Provides enumeration and indexed access to the bits on a stored sbyte.

```csharp
public struct BitIndexerSByte :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.Length') | The length of enumerated bits |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerSByte(sbyte)](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerSByte(sbyte).md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerSByte(sbyte)') | Automatically Convert from an sbyte to a BitIndexerSByte |
| [implicit operator sbyte(BitIndexerSByte)](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.op_Implicitsbyte(Jcd.BitManipulation.BitIndexers.BitIndexerSByte).md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.op_Implicit sbyte(Jcd.BitManipulation.BitIndexers.BitIndexerSByte)') | Automatically convert from a BitIndexerSByte to an sbyte |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerSByte.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerSByte.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
