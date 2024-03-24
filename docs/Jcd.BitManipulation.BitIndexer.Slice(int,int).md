### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')

## BitIndexer.Slice(int, int) Method

Get a subset of bits given a starting offset and length.

```csharp
public readonly bool[] Slice(int start, int length);
```
#### Parameters

<a name='Jcd.BitManipulation.BitIndexer.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The starting bit offset

<a name='Jcd.BitManipulation.BitIndexer.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to extract

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
an array of bools for the subset of bits