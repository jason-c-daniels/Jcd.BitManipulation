#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers')

## BitIndexerByte Struct

Provides enumeration and indexed access to the bits on a stored byte.

```csharp
public struct BitIndexerByte :
Jcd.BitManipulation.BitIndexers.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Fields                                                                                                                        |                                         |
|:------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------|
| [BitSize](Jcd.BitManipulation.BitIndexers.BitIndexerByte.BitSize.md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.BitSize') | The number of bits this type will index |

| Properties                                                                                                                          |                                                        |
|:------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------|
| [Bits](Jcd.BitManipulation.BitIndexers.BitIndexerByte.Bits.md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.Bits')                | The backing store                                      |
| [Length](Jcd.BitManipulation.BitIndexers.BitIndexerByte.Length.md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.Length')          | The length of enumerated bits                          |
| [this[int]](Jcd.BitManipulation.BitIndexers.BitIndexerByte.this[int].md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.this[int]') | Gets or sets individual bits within the backing store. |

| Methods                                                                                                                                               |                                                           |
|:------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerByte.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.GetEnumerator()') | Get an enumerator to enumerate the bits with.             |
| [Slice(int, int)](Jcd.BitManipulation.BitIndexers.BitIndexerByte.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.Slice(int, int)')  | Gets a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexers.BitIndexerByte.ToString().md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.ToString()')                | Format as a bit representation                            |

| Operators                                                                                                                                                                                                                                                                     |                                                       |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------|
| [implicit operator byte(BitIndexerByte)](Jcd.BitManipulation.BitIndexers.BitIndexerByte.op_Implicitbyte(Jcd.BitManipulation.BitIndexers.BitIndexerByte).md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.op_Implicit byte(Jcd.BitManipulation.BitIndexers.BitIndexerByte)') | Automatically convert from a BitIndexerByte to a byte |
| [implicit operator BitIndexerByte(byte)](Jcd.BitManipulation.BitIndexers.BitIndexerByte.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexerByte(byte).md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.op_Implicit Jcd.BitManipulation.BitIndexers.BitIndexerByte(byte)') | Automatically Convert from a byte to a BitIndexerByte |

| Explicit Interface Implementations                                                                                                                                                                                                                 |                                               |
|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------|
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.BitManipulation.BitIndexers.BitIndexerByte.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.BitManipulation.BitIndexers.BitIndexerByte.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with. |
