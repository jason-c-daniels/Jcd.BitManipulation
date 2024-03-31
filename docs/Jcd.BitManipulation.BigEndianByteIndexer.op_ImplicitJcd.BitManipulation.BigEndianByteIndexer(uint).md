### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator BigEndianByteIndexer(uint) Operator

Implicitly converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer').

```csharp
public static Jcd.BitManipulation.BigEndianByteIndexer implicit operator BigEndianByteIndexer(uint data);
```
#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(uint).data'></a>

`data` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The initial value for the bytes of data.

#### Returns
[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')
The newly created [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer').

### Example

```csharp
uint number = 0xDEADBEEF;
BigEndianByteIndexer indexer = number; // implicit cast.

var b0 = indexer[0]; // b0 is 0xDE
indexer[1] = 0xFF;
var result = indexer.ToString(); // result is "DE FF BE EF"
```