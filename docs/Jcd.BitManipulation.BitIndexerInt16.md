### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerInt16 Struct

Provides enumeration and indexed access to the bits on a
stored [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').

```csharp
public struct BitIndexerInt16 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerInt16.BitSize.md 'Jcd.BitManipulation.BitIndexerInt16.BitSize') | The number of bits this type will index |

| Properties                                                                                                    |                                                        |
|:--------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [Bits](Jcd.BitManipulation.BitIndexerInt16.Bits.md 'Jcd.BitManipulation.BitIndexerInt16.Bits')                | The backing store                                      |
| [Length](Jcd.BitManipulation.BitIndexerInt16.Length.md 'Jcd.BitManipulation.BitIndexerInt16.Length')          | The number of bits indexable by this indexer.          |
| [this[int]](Jcd.BitManipulation.BitIndexerInt16.this[int].md 'Jcd.BitManipulation.BitIndexerInt16.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerInt16.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt16.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerInt16.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerInt16.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexerInt16.ToString().md 'Jcd.BitManipulation.BitIndexerInt16.ToString()') | Format as a bit representation |

| Operators                                                                                                                                                                                                                             |                                                                                                                                           |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator BitIndexerInt16(short)](Jcd.BitManipulation.BitIndexerInt16.op_ImplicitJcd.BitManipulation.BitIndexerInt16(short).md 'Jcd.BitManipulation.BitIndexerInt16.op_Implicit Jcd.BitManipulation.BitIndexerInt16(short)') | Automatically Convert from a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') to a BitIndexerInt16 |
| [implicit operator short(BitIndexerInt16)](Jcd.BitManipulation.BitIndexerInt16.op_Implicitshort(Jcd.BitManipulation.BitIndexerInt16).md 'Jcd.BitManipulation.BitIndexerInt16.op_Implicit short(Jcd.BitManipulation.BitIndexerInt16)') | Automatically convert from a BitIndexerInt16 to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerInt16.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt16.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
