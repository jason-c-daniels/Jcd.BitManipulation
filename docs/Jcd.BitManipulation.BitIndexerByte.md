#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerByte Struct

Provides enumeration and indexed access to the bits on a stored byte.

```csharp
public struct BitIndexerByte :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerByte.BitSize.md 'Jcd.BitManipulation.BitIndexerByte.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexerByte.Bits.md 'Jcd.BitManipulation.BitIndexerByte.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexerByte.Length.md 'Jcd.BitManipulation.BitIndexerByte.Length') | The length of enumerated bits |
| [this[int]](Jcd.BitManipulation.BitIndexerByte.this[int].md 'Jcd.BitManipulation.BitIndexerByte.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerByte.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerByte.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerByte.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerByte.Slice(int, int)') | Gets a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexerByte.ToString().md 'Jcd.BitManipulation.BitIndexerByte.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator byte(BitIndexerByte)](Jcd.BitManipulation.BitIndexerByte.op_Implicitbyte(Jcd.BitManipulation.BitIndexerByte).md 'Jcd.BitManipulation.BitIndexerByte.op_Implicit byte(Jcd.BitManipulation.BitIndexerByte)') | Automatically convert from a BitIndexerByte to a byte |
| [implicit operator BitIndexerByte(byte)](Jcd.BitManipulation.BitIndexerByte.op_ImplicitJcd.BitManipulation.BitIndexerByte(byte).md 'Jcd.BitManipulation.BitIndexerByte.op_Implicit Jcd.BitManipulation.BitIndexerByte(byte)') | Automatically Convert from a byte to a BitIndexerByte |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerByte.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerByte.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
