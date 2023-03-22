### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerSByte Struct

Provides enumeration and indexed access to the bits on a stored sbyte.

```csharp
public struct BitIndexerSByte :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerSByte.BitSize.md 'Jcd.BitManipulation.BitIndexerSByte.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexerSByte.Bits.md 'Jcd.BitManipulation.BitIndexerSByte.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexerSByte.Length.md 'Jcd.BitManipulation.BitIndexerSByte.Length') | The length of enumerated bits |
| [this[int]](Jcd.BitManipulation.BitIndexerSByte.this[int].md 'Jcd.BitManipulation.BitIndexerSByte.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerSByte.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerSByte.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerSByte.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerSByte.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexerSByte.ToString().md 'Jcd.BitManipulation.BitIndexerSByte.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerSByte(sbyte)](Jcd.BitManipulation.BitIndexerSByte.op_ImplicitJcd.BitManipulation.BitIndexerSByte(sbyte).md 'Jcd.BitManipulation.BitIndexerSByte.op_Implicit Jcd.BitManipulation.BitIndexerSByte(sbyte)') | Automatically Convert from an sbyte to a BitIndexerSByte |
| [implicit operator sbyte(BitIndexerSByte)](Jcd.BitManipulation.BitIndexerSByte.op_Implicitsbyte(Jcd.BitManipulation.BitIndexerSByte).md 'Jcd.BitManipulation.BitIndexerSByte.op_Implicit sbyte(Jcd.BitManipulation.BitIndexerSByte)') | Automatically convert from a BitIndexerSByte to an sbyte |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerSByte.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerSByte.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
