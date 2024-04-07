#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')

## BitIndexer.implicit operator bool[](BitIndexer) Operator

Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

```csharp
public static bool[] implicit operator bool[](Jcd.BitManipulation.BitIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.BitIndexer.op_Implicitbool[](Jcd.BitManipulation.BitIndexer).indexer'></a>

`indexer` [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')

The indexer to convert from.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array of bools for each bit with The Least Significant Bit is at index 0.