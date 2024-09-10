#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer 'Jcd.BitManipulation.LittleEndianByteIndexer')

## LittleEndianByteIndexer.explicit operator ReadOnlySpan<byte>(LittleEndianByteIndexer) Operator

Explicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer 'Jcd.BitManipulation.LittleEndianByteIndexer') to an array of bytes.

```csharp
public static System.ReadOnlySpan<byte> explicit operator ReadOnlySpan<byte>(Jcd.BitManipulation.LittleEndianByteIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.LittleEndianByteIndexer.op_ExplicitSystem.ReadOnlySpan_byte_(Jcd.BitManipulation.LittleEndianByteIndexer).indexer'></a>

`indexer` [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer 'Jcd.BitManipulation.LittleEndianByteIndexer')

The indexer to convert.

#### Returns

[System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan
`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')
The raw data converted to an array, serialized as big endian.