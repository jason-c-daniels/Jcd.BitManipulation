### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerUInt32 Struct
Provides enumeration and indexed access to the bits on a stored uint.   
```csharp
public struct BitIndexerUInt32 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerUInt32_BitSize.md 'Jcd.BitManipulation.BitIndexerUInt32.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerUInt32_Bits.md 'Jcd.BitManipulation.BitIndexerUInt32.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerUInt32_Length.md 'Jcd.BitManipulation.BitIndexerUInt32.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerUInt32_this_int_.md 'Jcd.BitManipulation.BitIndexerUInt32.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerUInt32_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt32.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerUInt32_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerUInt32.Slice(int, int)') | Get a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerUInt32_ToString().md 'Jcd.BitManipulation.BitIndexerUInt32.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerUInt32(uint)](Jcd_BitManipulation_BitIndexerUInt32_op_ImplicitJcd_BitManipulation_BitIndexerUInt32(uint).md 'Jcd.BitManipulation.BitIndexerUInt32.op_Implicit Jcd.BitManipulation.BitIndexerUInt32(uint)') | Automatically Convert from a uint to a BitIndexerUInt32<br/> |
| [implicit operator uint(BitIndexerUInt32)](Jcd_BitManipulation_BitIndexerUInt32_op_Implicituint(Jcd_BitManipulation_BitIndexerUInt32).md 'Jcd.BitManipulation.BitIndexerUInt32.op_Implicit uint(Jcd.BitManipulation.BitIndexerUInt32)') | Automatically convert from a BitIndexerUInt32 to a uint<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerUInt32_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt32.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
