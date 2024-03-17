#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerInt16 Struct

Provides enumeration and indexed access to the bits on a stored short.

```csharp
public struct BitIndexerInt16 :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields                                                                                                                          |                                         |
|:--------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------|
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.BitSize') | The number of bits this type will index |

| Properties                                                                                                                            |                                                        |
|:--------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Bits')                | The backing store                                      |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Length')          | The length of enumerated bits                          |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.this[int]') | Gets or sets individual bits within the backing store. |

| Methods                                                                                                                                                 |                                                          |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------|
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.GetEnumerator()') | Get an enumerator to enumerate the bits with.            |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Slice(int, int)')  | Get a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.ToString()')                | Format as a bit representation                           |

| Operators                                                                                                                                                                                                                                                                             |                                                         |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------|
| [implicit operator BitIndexerInt16(short)](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerInt16(short).md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerInt16(short)') | Automatically Convert from a short to a BitIndexerInt16 |
| [implicit operator short(BitIndexerInt16)](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.op_Implicitshort(Jcd.BitManipulation.BitIndexers.BitIndexerInt16).md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.op_Implicit short(Jcd.BitManipulation.BitIndexers.BitIndexerInt16)') | Automatically convert from a BitIndexerInt16 to a short |

| Explicit Interface Implementations                                                                                                                                                                                                                   |                                               |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------|
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
