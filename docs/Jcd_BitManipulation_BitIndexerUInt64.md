### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerUInt64 Struct
Provides enumeration and indexed access to the bits on a stored ulong.   
```csharp
public struct BitIndexerUInt64 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerUInt64_BitSize.md 'Jcd.BitManipulation.BitIndexerUInt64.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerUInt64_Bits.md 'Jcd.BitManipulation.BitIndexerUInt64.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerUInt64_Length.md 'Jcd.BitManipulation.BitIndexerUInt64.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerUInt64_this_int_.md 'Jcd.BitManipulation.BitIndexerUInt64.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerUInt64_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt64.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerUInt64_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerUInt64.Slice(int, int)') | Get a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerUInt64_ToString().md 'Jcd.BitManipulation.BitIndexerUInt64.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerUInt64(ulong)](Jcd_BitManipulation_BitIndexerUInt64_op_ImplicitJcd_BitManipulation_BitIndexerUInt64(ulong).md 'Jcd.BitManipulation.BitIndexerUInt64.op_Implicit Jcd.BitManipulation.BitIndexerUInt64(ulong)') | Automatically Convert from a ulong to a BitIndexerUInt64<br/> |
| [implicit operator ulong(BitIndexerUInt64)](Jcd_BitManipulation_BitIndexerUInt64_op_Implicitulong(Jcd_BitManipulation_BitIndexerUInt64).md 'Jcd.BitManipulation.BitIndexerUInt64.op_Implicit ulong(Jcd.BitManipulation.BitIndexerUInt64)') | Automatically convert from a BitIndexerUInt64 to a ulong<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerUInt64_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt64.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
