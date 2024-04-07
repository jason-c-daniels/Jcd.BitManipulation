#### [Jcd.BitManipulation](index.md 'index')

## Jcd.BitManipulation.Algorithms Namespace

Provides various software implementations of common bit manipulation
algorithms, for C# supported types.

### Example

```csharp
var ul = ulong.MaxValue;

var bitCount = ul.CountBitsSet(); // bitCount = 64;
bitCount = ul.PopCount(); // also 64; this alias is provided for those who like the assembly language term.

var hbs = (ul >> 1).GetHighestBitSet(); // 63

var lbs = (ul << 1).GetLowestBitSet(); // 1

var np2 = 63.RoundUpToPowerOfTwo(); // 64
np2 = 64.RoundUpToPowerOfTwo(); // also 64.

var ip2 = 63.IsPowerOfTwo(); // false
ip2 = 64.IsPowerOfTwo(); // true
ip2 = (-64).IsPowerOfTwo(); // false

var ip = 63.IsPositive(); // true
ip = (-1).IsPositive(); // false

var ie = 63.IsEven(); // false
ie = 64.IsEven(); // true
```

| Classes                                                                                                                                                |                                                                                                                                                                          |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')       | Provides bit counting and other niche bit manipulation facilities for [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') values.       |
| [Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')    | Provides bit counting and other niche bit manipulation facilities for [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') values.    |
| [Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')    | Provides bit counting and other niche bit manipulation facilities for [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') values.    |
| [Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')    | Provides bit counting and other niche bit manipulation facilities for [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') values.    |
| [SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')    | Provides bit counting and other niche bit manipulation facilities for [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') values.    |
| [UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions') | Provides bit counting and other niche bit manipulation facilities for [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') values. |
| [UInt32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions') | Provides bit counting and other niche bit manipulation facilities for [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') values. |
| [UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions') | Provides bit counting and other niche bit manipulation facilities for [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') values. |
