### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[IBitIndexer](Jcd_BitManipulation_IBitIndexer.md 'Jcd.BitManipulation.IBitIndexer')
## IBitIndexer.Slice(int, int) Method
Gets a slice of bits from the backing store  
```csharp
bool[] Slice(int start, int length);
```
#### Parameters
<a name='Jcd_BitManipulation_IBitIndexer_Slice(int_int)_start'></a>
`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
starting offset of the bits to retrieve
  
<a name='Jcd_BitManipulation_IBitIndexer_Slice(int_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the number of bits to get
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of bits extracted
