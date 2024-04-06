#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator BigEndianByteIndexer(long) Operator

Implicitly converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer').

```csharp
public static Jcd.BitManipulation.BigEndianByteIndexer implicit operator BigEndianByteIndexer(long data);
```

#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(long).data'></a>

`data` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The initial value for the bytes of data.

#### Returns

[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')
The newly created [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer').

### Example

```csharp
long number = 0x7EADBEEFFA17C0DE;
BigEndianByteIndexer indexer = number; // implicit cast.

var b0 = indexer[0]; // b0 is 0x7E
indexer[1] = 0xFF;
var result = indexer.ToString(); // result is "7E FF BE EF FA 17 C0 DE"
```