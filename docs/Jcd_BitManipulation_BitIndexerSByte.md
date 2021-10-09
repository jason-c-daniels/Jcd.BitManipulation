### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerSByte Struct
Provides enumeration and indexed access to the bits on a stored sbyte.   
```csharp
public struct BitIndexerSByte :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerSByte_BitSize.md 'Jcd.BitManipulation.BitIndexerSByte.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerSByte_Bits.md 'Jcd.BitManipulation.BitIndexerSByte.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerSByte_Length.md 'Jcd.BitManipulation.BitIndexerSByte.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerSByte_this_int_.md 'Jcd.BitManipulation.BitIndexerSByte.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerSByte_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerSByte.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerSByte_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerSByte.Slice(int, int)') | Get a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerSByte_ToString().md 'Jcd.BitManipulation.BitIndexerSByte.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerSByte(sbyte)](Jcd_BitManipulation_BitIndexerSByte_op_ImplicitJcd_BitManipulation_BitIndexerSByte(sbyte).md 'Jcd.BitManipulation.BitIndexerSByte.op_Implicit Jcd.BitManipulation.BitIndexerSByte(sbyte)') | Automatically Convert from an sbyte to a BitIndexerSByte<br/> |
| [implicit operator sbyte(BitIndexerSByte)](Jcd_BitManipulation_BitIndexerSByte_op_Implicitsbyte(Jcd_BitManipulation_BitIndexerSByte).md 'Jcd.BitManipulation.BitIndexerSByte.op_Implicit sbyte(Jcd.BitManipulation.BitIndexerSByte)') | Automatically convert from a BitIndexerSByte to an sbyte<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerSByte_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerSByte.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
