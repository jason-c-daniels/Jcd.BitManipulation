#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers').[BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer')

## BitIndexer.implicit operator BitIndexer(bool[]) Operator

Automatically convert from
a [BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer') to an array
of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

```csharp
public static Jcd.BitManipulation.BitIndexers.BitIndexer implicit operator BitIndexer(bool[] array);
```

#### Parameters

<a name='Jcd.BitManipulation.BitIndexers.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexers.BitIndexer(bool[]).array'></a>

`array` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the indexer to convert from

#### Returns

[BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer')
the lower 8 bits converted to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')