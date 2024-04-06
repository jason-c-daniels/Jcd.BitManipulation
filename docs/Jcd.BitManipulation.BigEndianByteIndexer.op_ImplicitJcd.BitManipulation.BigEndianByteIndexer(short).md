#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator BigEndianByteIndexer(short) Operator

Implicitly converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer').

```csharp
public static Jcd.BitManipulation.BigEndianByteIndexer implicit operator BigEndianByteIndexer(short data);
```

#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(short).data'></a>

`data` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The initial value for the bytes of data.

#### Returns

[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')
The [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer') instance.

### Example

```csharp
short number = 0x7EAD;
BigEndianByteIndexer indexer = number; // implicit cast.

var b0 = indexer[0]; // b0 is 0xDE
indexer[1] = 0xFF;
var result = indexer.ToString(); // result is "7E FF"
```