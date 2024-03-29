### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')

## BitIndexer.implicit operator BitIndexer(bool[]) Operator

Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to an array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

```csharp
public static Jcd.BitManipulation.BitIndexer implicit operator BitIndexer(bool[] array);
```
#### Parameters

<a name='Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(bool[]).array'></a>

`array` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The indexer to convert from.

#### Returns
[BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')
The lower 8 bits converted to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').