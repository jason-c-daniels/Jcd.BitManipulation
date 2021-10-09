### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation')
## IBitIndexer Interface
The basic interface for indexing bits within an integer data type.  
```csharp
public interface IBitIndexer :
System.Collections.Generic.IEnumerable<bool>,
System.Collections.IEnumerable
```

Derived  
&#8627; [BitIndexerByte](Jcd_BitManipulation_BitIndexerByte.md 'Jcd.BitManipulation.BitIndexerByte')  
&#8627; [BitIndexerInt16](Jcd_BitManipulation_BitIndexerInt16.md 'Jcd.BitManipulation.BitIndexerInt16')  
&#8627; [BitIndexerInt32](Jcd_BitManipulation_BitIndexerInt32.md 'Jcd.BitManipulation.BitIndexerInt32')  
&#8627; [BitIndexerInt64](Jcd_BitManipulation_BitIndexerInt64.md 'Jcd.BitManipulation.BitIndexerInt64')  
&#8627; [BitIndexerSByte](Jcd_BitManipulation_BitIndexerSByte.md 'Jcd.BitManipulation.BitIndexerSByte')  
&#8627; [BitIndexerUInt16](Jcd_BitManipulation_BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexerUInt16')  
&#8627; [BitIndexerUInt32](Jcd_BitManipulation_BitIndexerUInt32.md 'Jcd.BitManipulation.BitIndexerUInt32')  
&#8627; [BitIndexerUInt64](Jcd_BitManipulation_BitIndexerUInt64.md 'Jcd.BitManipulation.BitIndexerUInt64')  

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Properties | |
| :--- | :--- |
| [Length](Jcd_BitManipulation_IBitIndexer_Length.md 'Jcd.BitManipulation.IBitIndexer.Length') | The number of addressable bits<br/> |
| [this[int]](Jcd_BitManipulation_IBitIndexer_this_int_.md 'Jcd.BitManipulation.IBitIndexer.this[int]') | gets or sets a bit<br/> |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd_BitManipulation_IBitIndexer_Slice(int_int).md 'Jcd.BitManipulation.IBitIndexer.Slice(int, int)') | Gets a slice of bits from the backing store<br/> |
| [ToString()](Jcd_BitManipulation_IBitIndexer_ToString().md 'Jcd.BitManipulation.IBitIndexer.ToString()') | Format as a bit representation<br/> |
