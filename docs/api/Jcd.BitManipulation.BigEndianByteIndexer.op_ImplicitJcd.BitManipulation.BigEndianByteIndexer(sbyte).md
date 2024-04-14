#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator BigEndianByteIndexer(sbyte) Operator

Implicitly converts a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer').

```csharp
public static Jcd.BitManipulation.BigEndianByteIndexer implicit operator BigEndianByteIndexer(sbyte data);
```

#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(sbyte).data'></a>

`data` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The initial value for the bytes of data.

#### Returns

[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer')
The [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') instance.

### Example

```csharp
sbyte number = 0xDE;
BigEndianByteIndexer indexer = number; // implicit cast.

var b0 = indexer[0]; // b0 is 0xDE
indexer[0] = 0xFF;
var result = indexer.ToString(); // result is "FF"
```