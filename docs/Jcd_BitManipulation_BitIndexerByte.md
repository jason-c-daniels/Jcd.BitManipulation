### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerByte Struct
Provides enumeration and indexed access to the bits on a stored byte.   
```csharp
public struct BitIndexerByte :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerByte_BitSize.md 'Jcd.BitManipulation.BitIndexerByte.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerByte_Bits.md 'Jcd.BitManipulation.BitIndexerByte.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerByte_Length.md 'Jcd.BitManipulation.BitIndexerByte.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerByte_this_int_.md 'Jcd.BitManipulation.BitIndexerByte.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerByte_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerByte.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerByte_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerByte.Slice(int, int)') | Gets a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerByte_ToString().md 'Jcd.BitManipulation.BitIndexerByte.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator byte(BitIndexerByte)](Jcd_BitManipulation_BitIndexerByte_op_Implicitbyte(Jcd_BitManipulation_BitIndexerByte).md 'Jcd.BitManipulation.BitIndexerByte.op_Implicit byte(Jcd.BitManipulation.BitIndexerByte)') | Automatically convert from a BitIndexerByte to a byte<br/> |
| [implicit operator BitIndexerByte(byte)](Jcd_BitManipulation_BitIndexerByte_op_ImplicitJcd_BitManipulation_BitIndexerByte(byte).md 'Jcd.BitManipulation.BitIndexerByte.op_Implicit Jcd.BitManipulation.BitIndexerByte(byte)') | Automatically Convert from a byte to a BitIndexerByte<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerByte_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerByte.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
