#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.explicit operator ReadOnlySpan<byte>(BigEndianByteIndexer) Operator

Explicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1') of bytes.

```csharp
public static System.ReadOnlySpan<byte> explicit operator ReadOnlySpan<byte>(Jcd.BitManipulation.BigEndianByteIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_ExplicitSystem.ReadOnlySpan_byte_(Jcd.BitManipulation.BigEndianByteIndexer).indexer'></a>

`indexer` [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

The indexer to convert.

#### Returns

[System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')
The raw data converted to an array, serialized as big endian.