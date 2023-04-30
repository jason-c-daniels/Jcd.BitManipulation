#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers').[IBitIndexer](Jcd.BitManipulation.BitIndexers.IBitIndexer.md 'Jcd.BitManipulation.BitIndexers.IBitIndexer')

## IBitIndexer.Slice(int, int) Method

Gets a slice of bits from the backing store

```csharp
bool[] Slice(int start, int length);
```
#### Parameters

<a name='Jcd.BitManipulation.BitIndexers.IBitIndexer.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

starting offset of the bits to retrieve

<a name='Jcd.BitManipulation.BitIndexers.IBitIndexer.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to get

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of bits extracted