#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers').[BitIndexerInt16](Jcd.BitManipulation.BitIndexers.BitIndexerInt16.md 'Jcd.BitManipulation.BitIndexers.BitIndexerInt16')

## BitIndexerInt16.Slice(int, int) Method

Get a subset of bits given a starting offset and length.

```csharp
public bool[] Slice(int start, int length);
```

#### Parameters

<a name='Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The starting bit offset

<a name='Jcd.BitManipulation.BitIndexers.BitIndexerInt16.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to extract

Implements [Slice(int, int)](Jcd.BitManipulation.BitIndexers.IBitIndexer.Slice(int,int).md 'Jcd.BitManipulation.BitIndexers.IBitIndexer.Slice(int, int)')

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
an array of bools for the subset of bits