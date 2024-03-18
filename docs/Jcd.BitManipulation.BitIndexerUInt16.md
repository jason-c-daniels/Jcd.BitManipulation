### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexerUInt16 Struct

Provides enumeration and indexed access to the bits on a
stored [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').

```csharp
public struct BitIndexerUInt16 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields | |
| :--- | :--- |
| [BitSize](Jcd.BitManipulation.BitIndexerUInt16.BitSize.md 'Jcd.BitManipulation.BitIndexerUInt16.BitSize') | The number of bits this type will index |

| Properties                                                                                                      |                                                        |
|:----------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [Bits](Jcd.BitManipulation.BitIndexerUInt16.Bits.md 'Jcd.BitManipulation.BitIndexerUInt16.Bits')                | The backing store                                      |
| [Length](Jcd.BitManipulation.BitIndexerUInt16.Length.md 'Jcd.BitManipulation.BitIndexerUInt16.Length')          | The number of bits indexable by this indexer.          |
| [this[int]](Jcd.BitManipulation.BitIndexerUInt16.this[int].md 'Jcd.BitManipulation.BitIndexerUInt16.this[int]') | Gets or sets individual bits within the backing store. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd.BitManipulation.BitIndexerUInt16.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt16.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexerUInt16.Slice(int,int).md 'Jcd.BitManipulation.BitIndexerUInt16.Slice(int, int)') | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexerUInt16.ToString().md 'Jcd.BitManipulation.BitIndexerUInt16.ToString()') | Format as a bit representation |

| Operators                                                                                                                                                                                                                                     |                                                                                                                                               |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator BitIndexerUInt16(ushort)](Jcd.BitManipulation.BitIndexerUInt16.op_ImplicitJcd.BitManipulation.BitIndexerUInt16(ushort).md 'Jcd.BitManipulation.BitIndexerUInt16.op_Implicit Jcd.BitManipulation.BitIndexerUInt16(ushort)') | Automatically Convert from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to a BitIndexerUInt16 |
| [implicit operator ushort(BitIndexerUInt16)](Jcd.BitManipulation.BitIndexerUInt16.op_Implicitushort(Jcd.BitManipulation.BitIndexerUInt16).md 'Jcd.BitManipulation.BitIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.BitIndexerUInt16)') | Automatically convert from a BitIndexerUInt16 to a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexerUInt16.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt16.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
