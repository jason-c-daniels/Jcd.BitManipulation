### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerInt16 Struct
Provides enumeration and indexed access to the bits on a stored short.   
```csharp
public struct BitIndexerInt16 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerInt16_BitSize.md 'Jcd.BitManipulation.BitIndexerInt16.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerInt16_Bits.md 'Jcd.BitManipulation.BitIndexerInt16.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerInt16_Length.md 'Jcd.BitManipulation.BitIndexerInt16.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerInt16_this_int_.md 'Jcd.BitManipulation.BitIndexerInt16.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerInt16_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt16.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerInt16_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerInt16.Slice(int, int)') | Get a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerInt16_ToString().md 'Jcd.BitManipulation.BitIndexerInt16.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerInt16(short)](Jcd_BitManipulation_BitIndexerInt16_op_ImplicitJcd_BitManipulation_BitIndexerInt16(short).md 'Jcd.BitManipulation.BitIndexerInt16.op_Implicit Jcd.BitManipulation.BitIndexerInt16(short)') | Automatically Convert from a short to a BitIndexerInt16<br/> |
| [implicit operator short(BitIndexerInt16)](Jcd_BitManipulation_BitIndexerInt16_op_Implicitshort(Jcd_BitManipulation_BitIndexerInt16).md 'Jcd.BitManipulation.BitIndexerInt16.op_Implicit short(Jcd.BitManipulation.BitIndexerInt16)') | Automatically convert from a BitIndexerInt16 to a short<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerInt16_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt16.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
