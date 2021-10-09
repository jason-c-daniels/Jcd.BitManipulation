### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerInt64 Struct
Provides enumeration and indexed access to the bits on a stored long.   
```csharp
public struct BitIndexerInt64 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerInt64_BitSize.md 'Jcd.BitManipulation.BitIndexerInt64.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerInt64_Bits.md 'Jcd.BitManipulation.BitIndexerInt64.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerInt64_Length.md 'Jcd.BitManipulation.BitIndexerInt64.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerInt64_this_int_.md 'Jcd.BitManipulation.BitIndexerInt64.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerInt64_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt64.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerInt64_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerInt64.Slice(int, int)') | Get an enumerator to enumerate the bits with.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerInt64_ToString().md 'Jcd.BitManipulation.BitIndexerInt64.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerInt64(long)](Jcd_BitManipulation_BitIndexerInt64_op_ImplicitJcd_BitManipulation_BitIndexerInt64(long).md 'Jcd.BitManipulation.BitIndexerInt64.op_Implicit Jcd.BitManipulation.BitIndexerInt64(long)') | Automatically Convert from a long to a BitIndexerInt64<br/> |
| [implicit operator long(BitIndexerInt64)](Jcd_BitManipulation_BitIndexerInt64_op_Implicitlong(Jcd_BitManipulation_BitIndexerInt64).md 'Jcd.BitManipulation.BitIndexerInt64.op_Implicit long(Jcd.BitManipulation.BitIndexerInt64)') | Automatically convert from a BitIndexerInt64 to a long<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerInt64_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt64.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
