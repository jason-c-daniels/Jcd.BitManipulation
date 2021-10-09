### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## BitIndexerUInt16 Struct
Provides enumeration and indexed access to the bits on a stored ushort.   
```csharp
public struct BitIndexerUInt16 :
Jcd.BitManipulation.IBitIndexer,
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Implements [IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer'), [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Fields | |
| :--- | :--- |
| [BitSize](Jcd_BitManipulation_BitIndexerUInt16_BitSize.md 'Jcd.BitManipulation.BitIndexerUInt16.BitSize') | The number of bits this type will index<br/> |

| Properties | |
| :--- | :--- |
| [Bits](Jcd_BitManipulation_BitIndexerUInt16_Bits.md 'Jcd.BitManipulation.BitIndexerUInt16.Bits') | The backing store<br/> |
| [Length](Jcd_BitManipulation_BitIndexerUInt16_Length.md 'Jcd.BitManipulation.BitIndexerUInt16.Length') | The length of enumerated bits<br/> |
| [this[int]](Jcd_BitManipulation_BitIndexerUInt16_this_int_.md 'Jcd.BitManipulation.BitIndexerUInt16.this[int]') | Gets or sets individual bits within the backing store. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_BitManipulation_BitIndexerUInt16_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt16.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
| [Slice(int, int)](Jcd_BitManipulation_BitIndexerUInt16_Slice(int_int).md 'Jcd.BitManipulation.BitIndexerUInt16.Slice(int, int)') | Get a subset of bits given a starting offset and length.<br/> |
| [ToString()](Jcd_BitManipulation_BitIndexerUInt16_ToString().md 'Jcd.BitManipulation.BitIndexerUInt16.ToString()') | Format as a bit representation<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator BitIndexerUInt16(ushort)](Jcd_BitManipulation_BitIndexerUInt16_op_ImplicitJcd_BitManipulation_BitIndexerUInt16(ushort).md 'Jcd.BitManipulation.BitIndexerUInt16.op_Implicit Jcd.BitManipulation.BitIndexerUInt16(ushort)') | Automatically Convert from a ushort to a BitIndexerUInt16<br/> |
| [implicit operator ushort(BitIndexerUInt16)](Jcd_BitManipulation_BitIndexerUInt16_op_Implicitushort(Jcd_BitManipulation_BitIndexerUInt16).md 'Jcd.BitManipulation.BitIndexerUInt16.op_Implicit ushort(Jcd.BitManipulation.BitIndexerUInt16)') | Automatically convert from a BitIndexerUInt16 to a ushort<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_BitManipulation_BitIndexerUInt16_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.BitManipulation.BitIndexerUInt16.System.Collections.IEnumerable.GetEnumerator()') | Get an enumerator to enumerate the bits with.<br/> |
