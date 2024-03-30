### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator BigEndianByteIndexer(float) Operator

Implicitly converts a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') to
a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer').

```csharp
public static Jcd.BitManipulation.BigEndianByteIndexer implicit operator BigEndianByteIndexer(float data);
```

#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(float).data'></a>

`data` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The initial value for the bytes of data.

#### Returns

[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')
The [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')
instance.

### Remarks

Example:

```csharp
float number = -6.259853398707798016E18f; // 0xDEADBEEF
BigEndianByteIndexer indexer = number; // implicit cast.

var b0 = indexer[0]; // b0 is 0xDE
indexer[1] = 0xFF;
var result = indexer.ToString(); // result is "DE FF BE EF"
```