### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BitIndexerUInt16](Jcd_BitManipulation_BitIndexerUInt16.md 'Jcd.BitManipulation.BitIndexerUInt16')
## BitIndexerUInt16.Slice(int, int) Method
Get a subset of bits given a starting offset and length.  
```csharp
public bool[] Slice(int start, int length);
```
#### Parameters
<a name='Jcd_BitManipulation_BitIndexerUInt16_Slice(int_int)_start'></a>
`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The starting bit offset
  
<a name='Jcd_BitManipulation_BitIndexerUInt16_Slice(int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of bits to extract
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
an array of bools for the subset of bits

Implements [Slice(int, int)](Jcd_BitManipulation_IBitIndexer_Slice(int_int).md 'Jcd.BitManipulation.IBitIndexer.Slice(int, int)')  
