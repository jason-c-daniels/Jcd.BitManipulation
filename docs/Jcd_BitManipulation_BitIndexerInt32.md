### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerInt32 Struct
Provides enumeration and indexed access to the bits on a stored int.   
```csharp
public struct BitIndexerInt32 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerInt32_BitSize.md 'Jcd.BitManipulation.BitIndexerInt32.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerInt32_Bits.md 'Jcd.BitManipulation.BitIndexerInt32.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerInt32_Length.md 'Jcd.BitManipulation.BitIndexerInt32.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerInt32_this_int_.md 'Jcd.BitManipulation.BitIndexerInt32.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerInt32_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt32.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerInt32_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerInt32.Slice(int, int)') | Get a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerInt32_ToString().md 'Jcd.BitManipulation.BitIndexerInt32.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator int(BitIndexerInt32)](Jcd_BitManipulation_BitIndexerInt32_op_Implicitint(Jcd_BitManipulation_BitIndexerInt32).md 'Jcd.BitManipulation.BitIndexerInt32.op_Implicit int(Jcd.BitManipulation.BitIndexerInt32)') | Automatically convert from a BitIndexerInt32 to an int<br/> |
| [implicit operator BitIndexerInt32(int)](Jcd_BitManipulation_BitIndexerInt32_op_ImplicitJcd_BitManipulation_BitIndexerInt32(int).md 'Jcd.BitManipulation.BitIndexerInt32.op_Implicit Jcd.BitManipulation.BitIndexerInt32(int)') | Automatically Convert from an int to a BitIndexerInt32<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerInt32_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerInt32.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
