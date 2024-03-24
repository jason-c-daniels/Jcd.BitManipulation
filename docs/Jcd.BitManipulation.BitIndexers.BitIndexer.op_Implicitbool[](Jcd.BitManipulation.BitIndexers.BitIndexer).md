#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers').[BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer')

## BitIndexer.implicit operator bool[](BitIndexer) Operator

Automatically convert from
a [BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer') to an array
of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

```csharp
public static bool[] implicit operator bool[](Jcd.BitManipulation.BitIndexers.BitIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.BitIndexers.BitIndexer.op_Implicitbool[](Jcd.BitManipulation.BitIndexers.BitIndexer).indexer'></a>

`indexer` [BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer')

the indexer to convert from

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array of bools for each bit with Least Significant Bit at index 0.