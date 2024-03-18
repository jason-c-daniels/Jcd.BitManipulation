#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerUInt64 Struct

Provides enumeration and indexed access to the bits on a
stored [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').

```csharp
public struct BitIndexerUInt64 :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.BitSize') | The number of bits this type will index |

| Properties                                                                                                                              |                                                        |
|:----------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.Bits')                | The backing store                                      |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.Length')          | The number of bits indexable by this indexer.          |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.ToString()') | Format as a bit representation |

| Operators                                                                                                                                                                                                                                                                                  |                                                                                                                                               |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator BitIndexerUInt64(ulong)](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerUInt64(ulong).md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerUInt64(ulong)') | Automatically Convert from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to a BitIndexerUInt64 |
| [implicit operator ulong(BitIndexerUInt64)](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.op_Implicitulong(Jcd.BitManipulation.BitIndexers.BitIndexerUInt64).md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.op_Implicit ulong(Jcd.BitManipulation.BitIndexers.BitIndexerUInt64)') | Automatically convert from a BitIndexerUInt64 to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerUInt64.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
