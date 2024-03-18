### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerUInt32 Struct

Provides enumeration and indexed access to the bits on a stored uint.

```csharp
public struct BitIndexerUInt32 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerUInt32.BitSize.md 'Jcd.BitManipulation.BitIndexerUInt32.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexerUInt32.Bits.md 'Jcd.BitManipulation.BitIndexerUInt32.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexerUInt32.Length.md 'Jcd.BitManipulation.BitIndexerUInt32.Length') | The length of enumerated bits |
| [this[int]](Jcd.BitManipulation.BitIndexerUInt32.this[int].md 'Jcd.BitManipulation.BitIndexerUInt32.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerUInt32.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt32.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerUInt32.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerUInt32.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexerUInt32.ToString().md 'Jcd.BitManipulation.BitIndexerUInt32.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerUInt32(uint)](Jcd.BitManipulation.BitIndexerUInt32.op_ImplicitJcd.BitManipulation.BitIndexerUInt32(uint).md 'Jcd.BitManipulation.BitIndexerUInt32.op_Implicit Jcd.BitManipulation.BitIndexerUInt32(uint)') | Automatically Convert from a uint to a BitIndexerUInt32 |
| [implicit operator uint(BitIndexerUInt32)](Jcd.BitManipulation.BitIndexerUInt32.op_Implicituint(Jcd.BitManipulation.BitIndexerUInt32).md 'Jcd.BitManipulation.BitIndexerUInt32.op_Implicit uint(Jcd.BitManipulation.BitIndexerUInt32)') | Automatically convert from a BitIndexerUInt32 to a uint |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerUInt32.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt32.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
