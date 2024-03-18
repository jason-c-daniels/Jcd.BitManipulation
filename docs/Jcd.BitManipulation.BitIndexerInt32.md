### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerInt32 Struct

Provides enumeration and indexed access to the bits on a
stored [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

```csharp
public struct BitIndexerInt32 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerInt32.BitSize.md 'Jcd.BitManipulation.BitIndexerInt32.BitSize') | The number of bits this type will index |

| Properties | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitIndexerInt32.Bits.md 'Jcd.BitManipulation.BitIndexerInt32.Bits') | The backing store |
| [Length](Jcd.BitManipulation.BitIndexerInt32.Length.md 'Jcd.BitManipulation.BitIndexerInt32.Length') | The length of enumerated bits |
| [this[int]](Jcd.BitManipulation.BitIndexerInt32.this[int].md 'Jcd.BitManipulation.BitIndexerInt32.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerInt32.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt32.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerInt32.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerInt32.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexerInt32.ToString().md 'Jcd.BitManipulation.BitIndexerInt32.ToString()') | Format as a bit representation |

| Operators                                                                                                                                                                                                                       |                                                                                                                                            |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator int(BitIndexerInt32)](Jcd.BitManipulation.BitIndexerInt32.op_Implicitint(Jcd.BitManipulation.BitIndexerInt32).md 'Jcd.BitManipulation.BitIndexerInt32.op_Implicit int(Jcd.BitManipulation.BitIndexerInt32)') | Automatically convert from a BitIndexerInt32 to an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') |
| [implicit operator BitIndexerInt32(int)](Jcd.BitManipulation.BitIndexerInt32.op_ImplicitJcd.BitManipulation.BitIndexerInt32(int).md 'Jcd.BitManipulation.BitIndexerInt32.op_Implicit Jcd.BitManipulation.BitIndexerInt32(int)') | Automatically Convert from an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to a BitIndexerInt32 |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerInt32.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt32.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
