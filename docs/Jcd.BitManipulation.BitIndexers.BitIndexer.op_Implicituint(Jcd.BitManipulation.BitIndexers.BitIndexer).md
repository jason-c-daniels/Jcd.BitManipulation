#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers').[BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer')

## BitIndexer.implicit operator uint(BitIndexer) Operator

Automatically convert from a BitIndexer to
a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

```csharp
public static uint implicit operator uint(Jcd.BitManipulation.BitIndexers.BitIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.BitIndexers.BitIndexer.op_Implicituint(Jcd.BitManipulation.BitIndexers.BitIndexer).indexer'></a>

`indexer` [BitIndexer](Jcd.BitManipulation.BitIndexers.BitIndexer.md 'Jcd.BitManipulation.BitIndexers.BitIndexer')

the indexer to convert from

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
the lower 32 bits converted to
a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')